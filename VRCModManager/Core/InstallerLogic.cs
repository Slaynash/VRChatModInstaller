using VRCModManager.DataModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

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
        #endregion

        #region Constructor
        public InstallerLogic(List<ReleaseInfo> _releases, string _installDirectory)
        {
            releases = _releases;
            installDirectory = _installDirectory;
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
                            StatusUpdate(string.Format("Downloading {0}...", release.title));
                            byte[] file = Helper.GetFile(release.downloadLink);
                            StatusUpdate(string.Format("Unzipping {0}...", release.title));
                            Helper.UnzipFile(file, installDirectory);
                            StatusUpdate(string.Format("Unzipped {0}", release.title));
                        }
                    }
                    catch (Exception ex)
                    {
                        StatusUpdate("Install failed! (" + release.title + ")");
                        MessageBox.Show("Install failed!\nUnable to install mod " + release.title + " :\n" + ex.ToString());
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
