using System;
using System.Linq;
using System.Windows.Forms;
using VRCModManager.Core;
using System.Threading;
using System.Collections.Generic;
using VRCModManager.DataModels;
using System.Diagnostics;
using System.Drawing;
using SemVer;
using System.IO;
using Version = SemVer.Version;

namespace VRCModManager
{
    public partial class FormMain : Form
    {

        #region Instances
        PathLogic path;
        UpdateLogic updater;
        RemoteLogic remote;
        InstallerLogic installer;
        bool finishedLoading = false;
        #endregion

        #region Constructor
        public FormMain()
        {
            InitializeComponent();
            path = new PathLogic();
            updater = new UpdateLogic();
            remote = new RemoteLogic();
        }
        #endregion

        #region Loading
        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                #if !DEBUG
                updater.CheckForUpdates();
                #endif
                textBoxDirectory.Text = path.GetInstallationPath();
             
                new Thread(() => { RemoteLoad(); }).Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to start, error: " + ex.ToString());
                Environment.Exit(0);
            }
        }

        private void RemoteLoad()
        {
            UpdateStatus("Loading releases...");
            remote.PopulateReleases();
            installer = new InstallerLogic(remote.releases, path.installPath);
            installer.StatusUpdate += Installer_StatusUpdate;
            this.Invoke((MethodInvoker)(() => { ShowReleases(); }));
        }

        private void ShowReleases()
        {
            Dictionary<string, int> groups = new Dictionary<string, int>();

            listViewMods.Groups.Clear();
            int other = listViewMods.Groups.Add(new ListViewGroup("Other", HorizontalAlignment.Left));
            groups.Add("Other", other);

            foreach (ReleaseInfo release in remote.releases)
            {
                ListViewItem item = new ListViewItem
                {
                    Text = release.modName,
                    Tag = release
                };

                item.SubItems.Add(release.melonVersion);
                item.SubItems.Add(release.gameVersion);
                item.SubItems.Add(release.modAuthor);
                item.SubItems.Add(release.modVersion);

                if (release.modPlatform == path.platform || release.modPlatform == Platform.Default)
                {
                    if (release.modCategory == "")
                    {
                        item.Group = listViewMods.Groups[other];
                    }
                    else if (groups.ContainsKey(release.modCategory))
                    {
                        int index = groups[release.modCategory];
                        item.Group = listViewMods.Groups[index];
                    }
                    else
                    {
                        int index = listViewMods.Groups.Add(new ListViewGroup(release.modCategory, HorizontalAlignment.Left));
                        groups.Add(release.modCategory, index);
                        item.Group = listViewMods.Groups[index];
                    }

                    listViewMods.Items.Add(item);
                    release.itemHandle = item;
                   
                }
            }
            
            ListViewGroup[] sortedGroups = new ListViewGroup[this.listViewMods.Groups.Count];

            listViewMods.Groups.CopyTo(sortedGroups, 0);
            Array.Sort(sortedGroups, new GroupComparer());

            listViewMods.BeginUpdate();
            listViewMods.Groups.Clear();
            listViewMods.Groups.AddRange(sortedGroups);
            listViewMods.EndUpdate();
            finishedLoading = true;
            ReRenderListView();

            UpdateStatus("Releases loaded.");
            tabControlMain.Enabled = true;
        }
        #endregion

        #region Helpers
        private void UpdateStatus(string status)
        {
            string formattedText = string.Format("Status: {0}", status);
            this.Invoke((MethodInvoker)(() =>
            { //Invoke so we can call from any thread
                labelStatus.Text = formattedText;
            }));
        }

        private void CheckDefaultMod(ReleaseInfo release, ListViewItem item)
        {
            string name = release.modName.ToLower();
            if (name == "vrcmodloader")
            {
                item.Text = $"[REQUIRED] {release.modName}";
                item.BackColor = Color.LightGray;
                release.disabled = true;

                release.install = true;
                item.Checked = true;
            }
        }
        #endregion

        #region Event Handlers
        private void Installer_StatusUpdate(string status)
        {
            UpdateStatus(status);
            if (status == "Install complete!") { this.Invoke((MethodInvoker)(() => { buttonInstall.Enabled = true; })); }
        }
        private void buttonInstall_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDirectory.Text))
            {
                MessageBox.Show("No install directory selected!", "No install directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            buttonInstall.Enabled = false;
            new Thread(() => { installer.Run(); }).Start();
        }

        private void buttonFolderBrowser_Click(object sender, EventArgs e)
        {
            textBoxDirectory.Text = path.ManualFind();
            installer.installDirectory = textBoxDirectory.Text;
        }

        private void buttonSteam_Click(object sender, EventArgs e)
        {
            textBoxDirectory.Text = path.GetSteamLocation();
            installer.installDirectory = textBoxDirectory.Text;
        }

        private void buttonOculus_Click(object sender, EventArgs e)
        {
            textBoxDirectory.Text = path.GetMoreValidOculusLocation();
            installer.installDirectory = textBoxDirectory.Text;
        }

        private void listViewMods_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ReleaseInfo release = (ReleaseInfo)e.Item.Tag;
            if (release.disabled)
            {
                e.Item.Checked = release.install;
                return;
            }
            else
            {
                release.install = e.Item.Checked;
            }

            if (e.Item.Checked)
            {
                if (release.modDependsOn.Count > 0)
                {
                    foreach (ModLink dependency in release.modDependsOn)
                    {
                        foreach (ListViewItem lvi in listViewMods.Items)
                        {
                            ReleaseInfo check = (ReleaseInfo)lvi.Tag;
                            if (check.modName == dependency.name)
                            {
                                check.itemHandle.Checked = true;
                            }
                        }
                    }
                }
            }

            if (e.Item.Checked)
            {
                if (release.modConflictsWith.Count > 0)
                {
                    foreach (ModLink dependency in release.modConflictsWith)
                    {
                        foreach (ListViewItem lvi in listViewMods.Items)
                        {
                            ReleaseInfo check = (ReleaseInfo)lvi.Tag;
                            if (check.modName == dependency.name)
                            {
                                check.itemHandle.Checked = false;
                                check.disabled = true;
                            }
                        }
                    }
                }
            }
            else
            {
                if (release.modConflictsWith.Count > 0)
                {
                    foreach (ModLink dependency in release.modConflictsWith)
                    {
                        foreach (ListViewItem lvi in listViewMods.Items)
                        {
                            ReleaseInfo check = (ReleaseInfo)lvi.Tag;
                            if (check.modName == dependency.name)
                            {
                                check.disabled = false;
                            }
                        }
                    }
                }
            }
            if (finishedLoading ){
                ReRenderListView();
            }
        }

        private void ReRenderListView ()
        {
            foreach (ListViewItem item in listViewMods.Items)
            {
                ReleaseInfo release = (ReleaseInfo)item.Tag;
                if (release.disabled)
                {
                    item.Checked = release.install;
                    item.BackColor = Color.LightGray;
                    item.Text = $"[{(release.install ? "REQUIRED" : "CONFLICT")}] {release.modName}";
                }
                else
                {
                    item.Text = release.modName;
                    item.BackColor = Color.White;
                }
                CheckDefaultMod(release, item);
            }
        }

        private void listViewMods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMods.SelectedItems.Count == 1)
            {
                buttonViewInfo.Enabled = true;
            }
            else
            {
                buttonViewInfo.Enabled = false;
            }
        }

        private void buttonViewInfo_Click(object sender, EventArgs e)
        {
            new FormDetailViewer((ReleaseInfo)listViewMods.SelectedItems[0].Tag).ShowDialog();
        }

        private void viewInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewMods.SelectedItems.Count >= 1)
            {
                new FormDetailViewer((ReleaseInfo)listViewMods.SelectedItems[0].Tag).ShowDialog();
            }
        }

        private void linkLabellolPants_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/lolPants");
        }

        private void linkLabelModSaberLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.modsaber.org/faq");
        }

        private void linkLabelUmbranox_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://twitter.com/Umbranoxus");
        }

        private void linkLabelContributors_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Umbranoxio/BeatSaberModInstaller/graphs/contributors");
        }

        private void textBoxDirectory_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDirectory.Text))
            {
                textBoxPluginsPath.Text = "${Install Directory}\\Mods";
            }
            else
            {
                textBoxPluginsPath.Text = textBoxDirectory.Text + "\\Mods";
            }
        }

        private void textBoxPluginsPath_Click(object sender, System.EventArgs e)
        {
            textBoxPluginsPath.SelectAll();
        }

        private void textBoxPluginsPath_Leave(object sender, System.EventArgs e)
        {
            textBoxPluginsPath.DeselectAll();
        }

        private void linkLabelDiscord_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/rCqKSvR");
        }
        #endregion

        private void labelModSaber1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Slaynash");
        }

        private void tabPageCredits_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Janni9009");
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            path.DriveLetter = comboBox1.SelectedItem.ToString();
        }

        private void ComboBox1_TextUpdate(object sender, EventArgs e)
        {
            
        }

        bool Drives = false;
        private void ComboBox1_DropDown(object sender, EventArgs e)
        {
            if (Drives == false)
            {
                DriveInfo[] ListAllDrives = DriveInfo.GetDrives();
                foreach (DriveInfo Drive in ListAllDrives)
                {
                    if (Drive.DriveType == DriveType.Fixed)
                    { comboBox1.Items.Add(Drive); }
                }
                Drives = true;
            }
        }

        private void ResetBTN_Click(object sender, EventArgs e)
        {
            buttonInstall.Enabled = true;
        }

        private void ButtonModsFolderOpen_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", textBoxDirectory.Text);
        }
    }
}
