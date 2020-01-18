namespace VRCModManager
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.buttonFolderBrowser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInstall = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageCore = new System.Windows.Forms.TabPage();
            this.listViewMods = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLoader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGameVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageCreditsHelp = new System.Windows.Forms.TabPage();
            this.linkLabelDiscord = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDiscordInfo = new System.Windows.Forms.Label();
            this.linkLabelUmbranox = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.ResetBTN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPageExternal = new System.Windows.Forms.TabPage();
            this.buttonViewInfo = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.tableLayoutPanelInfo = new System.Windows.Forms.TableLayoutPanel();
            this.helpInfoLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPluginsPath = new System.Windows.Forms.TextBox();
            this.helpInfoLabel3 = new System.Windows.Forms.Label();
            this.buttonOculus = new System.Windows.Forms.Button();
            this.buttonSteam = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonModsFolderOpen = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageCore.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.tabPageCreditsHelp.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tabPageExternal.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.tableLayoutPanelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDirectory.Enabled = false;
            this.textBoxDirectory.Location = new System.Drawing.Point(10, 25);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(381, 22);
            this.textBoxDirectory.TabIndex = 0;
            this.textBoxDirectory.TextChanged += new System.EventHandler(this.textBoxDirectory_TextChanged);
            // 
            // buttonFolderBrowser
            // 
            this.buttonFolderBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFolderBrowser.Location = new System.Drawing.Point(524, 24);
            this.buttonFolderBrowser.Name = "buttonFolderBrowser";
            this.buttonFolderBrowser.Size = new System.Drawing.Size(50, 23);
            this.buttonFolderBrowser.TabIndex = 1;
            this.buttonFolderBrowser.Text = "..";
            this.buttonFolderBrowser.UseVisualStyleBackColor = true;
            this.buttonFolderBrowser.Click += new System.EventHandler(this.buttonFolderBrowser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "VRChat Folder Path:";
            // 
            // buttonInstall
            // 
            this.buttonInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInstall.Location = new System.Drawing.Point(462, 401);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(112, 23);
            this.buttonInstall.TabIndex = 4;
            this.buttonInstall.Text = "Install / Update";
            this.buttonInstall.UseVisualStyleBackColor = true;
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.Location = new System.Drawing.Point(7, 406);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(285, 14);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Status: Null";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageCore);
            this.tabControlMain.Controls.Add(this.tabPageCreditsHelp);
            this.tabControlMain.Controls.Add(this.tabPageSettings);
            this.tabControlMain.Controls.Add(this.tabPageExternal);
            this.tabControlMain.Enabled = false;
            this.tabControlMain.Location = new System.Drawing.Point(10, 140);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(566, 255);
            this.tabControlMain.TabIndex = 8;
            // 
            // tabPageCore
            // 
            this.tabPageCore.Controls.Add(this.listViewMods);
            this.tabPageCore.Location = new System.Drawing.Point(4, 22);
            this.tabPageCore.Name = "tabPageCore";
            this.tabPageCore.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCore.Size = new System.Drawing.Size(558, 229);
            this.tabPageCore.TabIndex = 0;
            this.tabPageCore.Text = "Mods";
            this.tabPageCore.UseVisualStyleBackColor = true;
            // 
            // listViewMods
            // 
            this.listViewMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMods.CheckBoxes = true;
            this.listViewMods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderLoader,
            this.columnHeaderGameVersion,
            this.columnHeaderAuthor,
            this.columnHeaderVersion});
            this.listViewMods.ContextMenuStrip = this.contextMenuStripMain;
            this.listViewMods.FullRowSelect = true;
            this.listViewMods.HideSelection = false;
            this.listViewMods.Location = new System.Drawing.Point(6, 6);
            this.listViewMods.Name = "listViewMods";
            this.listViewMods.Size = new System.Drawing.Size(546, 217);
            this.listViewMods.TabIndex = 0;
            this.listViewMods.UseCompatibleStateImageBehavior = false;
            this.listViewMods.View = System.Windows.Forms.View.Details;
            this.listViewMods.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewMods_ItemChecked);
            this.listViewMods.SelectedIndexChanged += new System.EventHandler(this.listViewMods_SelectedIndexChanged);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 172;
            // 
            // columnHeaderLoader
            // 
            this.columnHeaderLoader.Text = "Loader";
            this.columnHeaderLoader.Width = 75;
            // 
            // columnHeaderGameVersion
            // 
            this.columnHeaderGameVersion.Text = "Game Version";
            this.columnHeaderGameVersion.Width = 90;
            // 
            // columnHeaderAuthor
            // 
            this.columnHeaderAuthor.Text = "Author";
            this.columnHeaderAuthor.Width = 113;
            // 
            // columnHeaderVersion
            // 
            this.columnHeaderVersion.Text = "Version";
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInfoToolStripMenuItem});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(124, 26);
            // 
            // viewInfoToolStripMenuItem
            // 
            this.viewInfoToolStripMenuItem.Name = "viewInfoToolStripMenuItem";
            this.viewInfoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.viewInfoToolStripMenuItem.Text = "View Info";
            this.viewInfoToolStripMenuItem.Click += new System.EventHandler(this.viewInfoToolStripMenuItem_Click);
            // 
            // tabPageCreditsHelp
            // 
            this.tabPageCreditsHelp.Controls.Add(this.linkLabelDiscord);
            this.tabPageCreditsHelp.Controls.Add(this.linkLabel2);
            this.tabPageCreditsHelp.Controls.Add(this.label6);
            this.tabPageCreditsHelp.Controls.Add(this.linkLabel1);
            this.tabPageCreditsHelp.Controls.Add(this.label4);
            this.tabPageCreditsHelp.Controls.Add(this.label5);
            this.tabPageCreditsHelp.Controls.Add(this.labelDiscordInfo);
            this.tabPageCreditsHelp.Controls.Add(this.linkLabelUmbranox);
            this.tabPageCreditsHelp.Controls.Add(this.label3);
            this.tabPageCreditsHelp.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreditsHelp.Name = "tabPageCreditsHelp";
            this.tabPageCreditsHelp.Size = new System.Drawing.Size(558, 229);
            this.tabPageCreditsHelp.TabIndex = 1;
            this.tabPageCreditsHelp.Text = "Credits and Help";
            this.tabPageCreditsHelp.UseVisualStyleBackColor = true;
            this.tabPageCreditsHelp.Click += new System.EventHandler(this.tabPageCredits_Click);
            // 
            // linkLabelDiscord
            // 
            this.linkLabelDiscord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelDiscord.AutoSize = true;
            this.linkLabelDiscord.Location = new System.Drawing.Point(216, 169);
            this.linkLabelDiscord.Name = "linkLabelDiscord";
            this.linkLabelDiscord.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLabelDiscord.Size = new System.Drawing.Size(108, 13);
            this.linkLabelDiscord.TabIndex = 1;
            this.linkLabelDiscord.TabStop = true;
            this.linkLabelDiscord.Text = "discord.gg/rCqKSvR";
            this.linkLabelDiscord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelDiscord.Click += new System.EventHandler(this.linkLabelDiscord_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(281, 84);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(58, 13);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Janni9009";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "QoL changes by";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(292, 60);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Slaynash";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Need more help?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "VRChat version by";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelDiscordInfo
            // 
            this.labelDiscordInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDiscordInfo.AutoSize = true;
            this.labelDiscordInfo.Location = new System.Drawing.Point(194, 153);
            this.labelDiscordInfo.Name = "labelDiscordInfo";
            this.labelDiscordInfo.Size = new System.Drawing.Size(143, 13);
            this.labelDiscordInfo.TabIndex = 0;
            this.labelDiscordInfo.Text = "Join the VRCTools discord!";
            this.labelDiscordInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabelUmbranox
            // 
            this.linkLabelUmbranox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelUmbranox.AutoSize = true;
            this.linkLabelUmbranox.Location = new System.Drawing.Point(329, 37);
            this.linkLabelUmbranox.Name = "linkLabelUmbranox";
            this.linkLabelUmbranox.Size = new System.Drawing.Size(60, 13);
            this.linkLabelUmbranox.TabIndex = 4;
            this.linkLabelUmbranox.TabStop = true;
            this.linkLabelUmbranox.Text = "Umbranox";
            this.linkLabelUmbranox.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelUmbranox_LinkClicked);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mod Installer originally created by ";
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.label10);
            this.tabPageSettings.Controls.Add(this.buttonModsFolderOpen);
            this.tabPageSettings.Controls.Add(this.label8);
            this.tabPageSettings.Controls.Add(this.ResetBTN);
            this.tabPageSettings.Controls.Add(this.label7);
            this.tabPageSettings.Controls.Add(this.comboBox1);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(558, 229);
            this.tabPageSettings.TabIndex = 2;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Reset install button:";
            // 
            // ResetBTN
            // 
            this.ResetBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetBTN.Location = new System.Drawing.Point(157, 71);
            this.ResetBTN.Name = "ResetBTN";
            this.ResetBTN.Size = new System.Drawing.Size(34, 23);
            this.ResetBTN.TabIndex = 13;
            this.ResetBTN.Text = "X";
            this.ResetBTN.UseVisualStyleBackColor = true;
            this.ResetBTN.Click += new System.EventHandler(this.ResetBTN_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Oculus install drive:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(157, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.DropDown += new System.EventHandler(this.ComboBox1_DropDown);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            this.comboBox1.TextUpdate += new System.EventHandler(this.ComboBox1_TextUpdate);
            // 
            // tabPageExternal
            // 
            this.tabPageExternal.Controls.Add(this.label9);
            this.tabPageExternal.Location = new System.Drawing.Point(4, 22);
            this.tabPageExternal.Name = "tabPageExternal";
            this.tabPageExternal.Size = new System.Drawing.Size(558, 229);
            this.tabPageExternal.TabIndex = 3;
            this.tabPageExternal.Text = "External Mods";
            this.tabPageExternal.UseVisualStyleBackColor = true;
            // 
            // buttonViewInfo
            // 
            this.buttonViewInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewInfo.Enabled = false;
            this.buttonViewInfo.Location = new System.Drawing.Point(298, 401);
            this.buttonViewInfo.Name = "buttonViewInfo";
            this.buttonViewInfo.Size = new System.Drawing.Size(158, 23);
            this.buttonViewInfo.TabIndex = 9;
            this.buttonViewInfo.Text = "View Selected Mod Info";
            this.buttonViewInfo.UseVisualStyleBackColor = true;
            this.buttonViewInfo.Click += new System.EventHandler(this.buttonViewInfo_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.BackColor = System.Drawing.SystemColors.Info;
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.tableLayoutPanelInfo);
            this.panelInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelInfo.Location = new System.Drawing.Point(10, 54);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(564, 80);
            this.panelInfo.TabIndex = 10;
            // 
            // tableLayoutPanelInfo
            // 
            this.tableLayoutPanelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelInfo.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanelInfo.ColumnCount = 1;
            this.tableLayoutPanelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelInfo.Controls.Add(this.helpInfoLabel1, 0, 0);
            this.tableLayoutPanelInfo.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanelInfo.Controls.Add(this.textBoxPluginsPath, 0, 1);
            this.tableLayoutPanelInfo.Controls.Add(this.helpInfoLabel3, 0, 3);
            this.tableLayoutPanelInfo.Location = new System.Drawing.Point(-1, 3);
            this.tableLayoutPanelInfo.Name = "tableLayoutPanelInfo";
            this.tableLayoutPanelInfo.RowCount = 5;
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelInfo.Size = new System.Drawing.Size(564, 79);
            this.tableLayoutPanelInfo.TabIndex = 13;
            // 
            // helpInfoLabel1
            // 
            this.helpInfoLabel1.AutoSize = true;
            this.helpInfoLabel1.Location = new System.Drawing.Point(3, 0);
            this.helpInfoLabel1.Name = "helpInfoLabel1";
            this.helpInfoLabel1.Size = new System.Drawing.Size(469, 13);
            this.helpInfoLabel1.TabIndex = 0;
            this.helpInfoLabel1.Text = "Most mods will install a .dll into the Mods folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Right click on a mod in the list below to view more info about that mod.";
            // 
            // textBoxPluginsPath
            // 
            this.textBoxPluginsPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPluginsPath.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxPluginsPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPluginsPath.Location = new System.Drawing.Point(6, 17);
            this.textBoxPluginsPath.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textBoxPluginsPath.Name = "textBoxPluginsPath";
            this.textBoxPluginsPath.ReadOnly = true;
            this.textBoxPluginsPath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxPluginsPath.Size = new System.Drawing.Size(555, 15);
            this.textBoxPluginsPath.TabIndex = 5;
            this.textBoxPluginsPath.Click += new System.EventHandler(this.textBoxPluginsPath_Click);
            this.textBoxPluginsPath.Leave += new System.EventHandler(this.textBoxPluginsPath_Leave);
            // 
            // helpInfoLabel3
            // 
            this.helpInfoLabel3.AutoSize = true;
            this.helpInfoLabel3.Location = new System.Drawing.Point(3, 42);
            this.helpInfoLabel3.Name = "helpInfoLabel3";
            this.helpInfoLabel3.Size = new System.Drawing.Size(502, 13);
            this.helpInfoLabel3.TabIndex = 3;
            this.helpInfoLabel3.Text = "You can uninstall mods by removing the .dll from that folder. Its accessible from" +
    " the Settings tab.";
            // 
            // buttonOculus
            // 
            this.buttonOculus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOculus.Location = new System.Drawing.Point(462, 23);
            this.buttonOculus.Name = "buttonOculus";
            this.buttonOculus.Size = new System.Drawing.Size(56, 23);
            this.buttonOculus.TabIndex = 11;
            this.buttonOculus.Text = "Oculus";
            this.buttonOculus.UseVisualStyleBackColor = true;
            this.buttonOculus.Click += new System.EventHandler(this.buttonOculus_Click);
            // 
            // buttonSteam
            // 
            this.buttonSteam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSteam.Location = new System.Drawing.Point(397, 23);
            this.buttonSteam.Name = "buttonSteam";
            this.buttonSteam.Size = new System.Drawing.Size(59, 23);
            this.buttonSteam.TabIndex = 12;
            this.buttonSteam.Text = "Steam";
            this.buttonSteam.UseVisualStyleBackColor = true;
            this.buttonSteam.Click += new System.EventHandler(this.buttonSteam_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Location = new System.Drawing.Point(217, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 14);
            this.label9.TabIndex = 13;
            this.label9.Text = "Work in Progress";
            // 
            // buttonModsFolderOpen
            // 
            this.buttonModsFolderOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModsFolderOpen.Location = new System.Drawing.Point(157, 109);
            this.buttonModsFolderOpen.Name = "buttonModsFolderOpen";
            this.buttonModsFolderOpen.Size = new System.Drawing.Size(121, 23);
            this.buttonModsFolderOpen.TabIndex = 13;
            this.buttonModsFolderOpen.Text = "Open Mods Folder";
            this.buttonModsFolderOpen.UseVisualStyleBackColor = true;
            this.buttonModsFolderOpen.Click += new System.EventHandler(this.ButtonModsFolderOpen_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Manually manage Mods:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 436);
            this.Controls.Add(this.buttonSteam);
            this.Controls.Add(this.buttonOculus);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.buttonViewInfo);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonInstall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFolderBrowser);
            this.Controls.Add(this.textBoxDirectory);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VRChat Mod Installer 1.0.4";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageCore.ResumeLayout(false);
            this.contextMenuStripMain.ResumeLayout(false);
            this.tabPageCreditsHelp.ResumeLayout(false);
            this.tabPageCreditsHelp.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.tabPageExternal.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.tableLayoutPanelInfo.ResumeLayout(false);
            this.tableLayoutPanelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.Button buttonFolderBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageCore;
        private System.Windows.Forms.ListView listViewMods;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderAuthor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem viewInfoToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageCreditsHelp;
        private System.Windows.Forms.Button buttonViewInfo;
        private System.Windows.Forms.ColumnHeader columnHeaderVersion;
        private System.Windows.Forms.LinkLabel linkLabelUmbranox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInfo;
        private System.Windows.Forms.Label helpInfoLabel1;
        private System.Windows.Forms.Label helpInfoLabel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPluginsPath;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.LinkLabel linkLabelDiscord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ColumnHeader columnHeaderLoader;
        private System.Windows.Forms.ColumnHeader columnHeaderGameVersion;
        private System.Windows.Forms.Button buttonOculus;
        private System.Windows.Forms.Button buttonSteam;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDiscordInfo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ResetBTN;
        private System.Windows.Forms.TabPage tabPageExternal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonModsFolderOpen;
    }
}
