using VRCModManager.DataModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace VRCModManager.Core
{
    public class InstallerLogic
    {

        #region Events
        public event StatusUpdateHandler StatusUpdate;
        public delegate void StatusUpdateHandler(string status);
        #endregion

        #region Variables
        List<ReleaseInfo> releases;
        public string installDirectory;
        public DirectoryInfo modsDirectory;
        #endregion

        #region Constructor
        public InstallerLogic(List<ReleaseInfo> _releases, string _installDirectory)
        {
            releases = _releases;
            installDirectory = _installDirectory;
            modsDirectory = new DirectoryInfo(Path.Combine(installDirectory, "Mods"));
        }
        #endregion

        #region Logic
        public void Run()
        {
            try
            {
                StatusUpdate("Starting install sequence...");
                foreach (ReleaseInfo release in releases)
                {
                    try
                    {
                        if (release.install)
                        {
                            StatusUpdate(string.Format("Downloading {0}...", release.modName));
                            if (!modsDirectory.Exists) Directory.CreateDirectory(modsDirectory.FullName);
                            if (release.modDownloadLink.Split('?')[0].EndsWith(".dll"))
                            {
                                foreach(string f in from filepath in (Directory.GetFiles(modsDirectory.FullName))
                                                    where (Path.GetFileName(filepath).ToLower().StartsWith(release.modName.ToLower() + ".") && filepath.ToLower().EndsWith(".dll"))
                                                    select filepath)
                                {
                                    File.Delete(f);
                                }

                                Helper.DownloadFile(release.modDownloadLink, installDirectory, release.modName, release.modVersion);
                            }
                            else
                            {
                                byte[] file = Helper.GetFile(release.modDownloadLink);
                                StatusUpdate(string.Format("Unzipping {0}...", release.modName));
                                Helper.UnzipFile(file, installDirectory);
                                StatusUpdate(string.Format("Unzipped {0}", release.modName));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        StatusUpdate("Install failed! (" + release.modName + ")");
                        MessageBox.Show("Install failed!\nUnable to install mod " + release.modName + " :\n" + ex.ToString());
                        return;
                    }
                }
                Process.Start(installDirectory + @"\IPA.exe", Quoted(installDirectory + @"\VRChat.exe"));
                StatusUpdate("Install complete!");
            }
            catch (Exception ex)
            {
                StatusUpdate("Install failed!");
                MessageBox.Show("Install failed! " + ex.ToString());
            }
            
        }
        #endregion

        #region Helpers
        public string Quoted(string str)
        {
            return "\"" + str + "\"";
        }
        #endregion

    }
}
