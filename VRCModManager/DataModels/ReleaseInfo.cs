using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRCModManager.DataModels
{
    public class ReleaseInfo
    {
        public string modName;
        public string modVersion;
        public string modAuthor;
        public string modDescription;
        public string modCategory;
        public string modDownloadLink;
        public Platform modPlatform;

        public string melonVersion;
        public string gameVersion;

        public bool install;
        public bool disabled;

        public ListViewItem itemHandle;

        public List<ModLink> modDependsOn;
        public List<ModLink> modConflictsWith;

        public ReleaseInfo(
            string modName, string modVersion, string modAuthor, string modDescription, string melonVersion,
            string gameVersion, string modDownloadLink, string modCategory,
            Platform modPlatform, List<ModLink> modDependsOn, List<ModLink> modConflictsWith
        )
        {
            this.modName = modName;
            this.modVersion = modVersion;
            this.modAuthor = modAuthor;
            this.modDescription = modDescription;
            this.melonVersion = melonVersion;
            this.gameVersion = gameVersion;
            this.modDownloadLink = modDownloadLink;
            this.modCategory = modCategory;
            this.modPlatform = modPlatform;
            this.modDependsOn = modDependsOn;
            this.modConflictsWith = modConflictsWith;
        }
    }
}
