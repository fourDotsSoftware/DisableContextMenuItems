namespace DisableContextMenuItems
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.chkSelectUsers = new System.Windows.Forms.RadioButton();
            this.chkAllUsers = new System.Windows.Forms.RadioButton();
            this.chkCurrentUser = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstUsers = new System.Windows.Forms.CheckedListBox();
            this.btnAddCurrentUser = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnUnselectAll = new System.Windows.Forms.Button();
            this.btnInvertSelection = new System.Windows.Forms.Button();
            this.btnInvSel = new System.Windows.Forms.Button();
            this.btnUnSelAll = new System.Windows.Forms.Button();
            this.btnSelAll = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.niceLine4 = new DisableContextMenuItems.NiceLine();
            this.chkDoubleClickOpen = new System.Windows.Forms.CheckBox();
            this.niceLine3 = new DisableContextMenuItems.NiceLine();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkProperties = new System.Windows.Forms.CheckBox();
            this.chkRename = new System.Windows.Forms.CheckBox();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.chkCopy = new System.Windows.Forms.CheckBox();
            this.chkCut = new System.Windows.Forms.CheckBox();
            this.niceLine2 = new DisableContextMenuItems.NiceLine();
            this.niceLine1 = new DisableContextMenuItems.NiceLine();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requirePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languages1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languages2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.pleaseShareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareOnFacebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareOnTwitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareOnGooglePlusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareOnLinkedinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareWithEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpUsersManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.pleaseDonateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.followUsOnTwitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visit4dotsSoftwareWebpageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.checkForNewVersionEachWeekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForNewVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkSelectUsers
            // 
            resources.ApplyResources(this.chkSelectUsers, "chkSelectUsers");
            this.chkSelectUsers.BackColor = System.Drawing.Color.Transparent;
            this.chkSelectUsers.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkSelectUsers.Name = "chkSelectUsers";
            this.chkSelectUsers.UseVisualStyleBackColor = false;
            this.chkSelectUsers.CheckedChanged += new System.EventHandler(this.chkSelectUsers_CheckedChanged);
            // 
            // chkAllUsers
            // 
            resources.ApplyResources(this.chkAllUsers, "chkAllUsers");
            this.chkAllUsers.BackColor = System.Drawing.Color.Transparent;
            this.chkAllUsers.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkAllUsers.Name = "chkAllUsers";
            this.chkAllUsers.UseVisualStyleBackColor = false;
            // 
            // chkCurrentUser
            // 
            resources.ApplyResources(this.chkCurrentUser, "chkCurrentUser");
            this.chkCurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.chkCurrentUser.Checked = true;
            this.chkCurrentUser.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkCurrentUser.Name = "chkCurrentUser";
            this.chkCurrentUser.TabStop = true;
            this.chkCurrentUser.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lstUsers);
            this.groupBox1.Controls.Add(this.btnAddCurrentUser);
            this.groupBox1.Controls.Add(this.btnSelectAll);
            this.groupBox1.Controls.Add(this.btnUnselectAll);
            this.groupBox1.Controls.Add(this.btnInvertSelection);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lstUsers
            // 
            resources.ApplyResources(this.lstUsers, "lstUsers");
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Name = "lstUsers";
            // 
            // btnAddCurrentUser
            // 
            this.btnAddCurrentUser.Image = global::DisableContextMenuItems.Properties.Resources.add;
            resources.ApplyResources(this.btnAddCurrentUser, "btnAddCurrentUser");
            this.btnAddCurrentUser.Name = "btnAddCurrentUser";
            this.btnAddCurrentUser.UseVisualStyleBackColor = true;
            this.btnAddCurrentUser.Click += new System.EventHandler(this.btnAddCurrentUser_Click);
            // 
            // btnSelectAll
            // 
            resources.ApplyResources(this.btnSelectAll, "btnSelectAll");
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnUnselectAll
            // 
            resources.ApplyResources(this.btnUnselectAll, "btnUnselectAll");
            this.btnUnselectAll.Name = "btnUnselectAll";
            this.btnUnselectAll.UseVisualStyleBackColor = true;
            this.btnUnselectAll.Click += new System.EventHandler(this.btnUnselectAll_Click);
            // 
            // btnInvertSelection
            // 
            resources.ApplyResources(this.btnInvertSelection, "btnInvertSelection");
            this.btnInvertSelection.Name = "btnInvertSelection";
            this.btnInvertSelection.UseVisualStyleBackColor = true;
            this.btnInvertSelection.Click += new System.EventHandler(this.btnInvertSelection_Click);
            // 
            // btnInvSel
            // 
            resources.ApplyResources(this.btnInvSel, "btnInvSel");
            this.btnInvSel.Name = "btnInvSel";
            this.btnInvSel.UseVisualStyleBackColor = true;
            this.btnInvSel.Click += new System.EventHandler(this.btnInvSel_Click);
            // 
            // btnUnSelAll
            // 
            resources.ApplyResources(this.btnUnSelAll, "btnUnSelAll");
            this.btnUnSelAll.Name = "btnUnSelAll";
            this.btnUnSelAll.UseVisualStyleBackColor = true;
            this.btnUnSelAll.Click += new System.EventHandler(this.btnUnSelAll_Click);
            // 
            // btnSelAll
            // 
            resources.ApplyResources(this.btnSelAll, "btnSelAll");
            this.btnSelAll.Name = "btnSelAll";
            this.btnSelAll.UseVisualStyleBackColor = true;
            this.btnSelAll.Click += new System.EventHandler(this.btnSelAll_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Image = global::DisableContextMenuItems.Properties.Resources.exit;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // niceLine4
            // 
            this.niceLine4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.niceLine4, "niceLine4");
            this.niceLine4.ForeColor = System.Drawing.Color.DarkBlue;
            this.niceLine4.Name = "niceLine4";
            // 
            // chkDoubleClickOpen
            // 
            resources.ApplyResources(this.chkDoubleClickOpen, "chkDoubleClickOpen");
            this.chkDoubleClickOpen.BackColor = System.Drawing.Color.Transparent;
            this.chkDoubleClickOpen.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkDoubleClickOpen.Name = "chkDoubleClickOpen";
            this.chkDoubleClickOpen.UseVisualStyleBackColor = false;
            // 
            // niceLine3
            // 
            this.niceLine3.BackColor = System.Drawing.Color.Transparent;
            this.niceLine3.Caption = "Extras";
            resources.ApplyResources(this.niceLine3, "niceLine3");
            this.niceLine3.ForeColor = System.Drawing.Color.DarkBlue;
            this.niceLine3.Name = "niceLine3";
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Image = global::DisableContextMenuItems.Properties.Resources.check;
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkProperties
            // 
            resources.ApplyResources(this.chkProperties, "chkProperties");
            this.chkProperties.BackColor = System.Drawing.Color.Transparent;
            this.chkProperties.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkProperties.Name = "chkProperties";
            this.chkProperties.UseVisualStyleBackColor = false;
            // 
            // chkRename
            // 
            resources.ApplyResources(this.chkRename, "chkRename");
            this.chkRename.BackColor = System.Drawing.Color.Transparent;
            this.chkRename.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkRename.Name = "chkRename";
            this.chkRename.UseVisualStyleBackColor = false;
            // 
            // chkDelete
            // 
            resources.ApplyResources(this.chkDelete, "chkDelete");
            this.chkDelete.BackColor = System.Drawing.Color.Transparent;
            this.chkDelete.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.UseVisualStyleBackColor = false;
            // 
            // chkCopy
            // 
            resources.ApplyResources(this.chkCopy, "chkCopy");
            this.chkCopy.BackColor = System.Drawing.Color.Transparent;
            this.chkCopy.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkCopy.Name = "chkCopy";
            this.chkCopy.UseVisualStyleBackColor = false;
            // 
            // chkCut
            // 
            resources.ApplyResources(this.chkCut, "chkCut");
            this.chkCut.BackColor = System.Drawing.Color.Transparent;
            this.chkCut.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkCut.Name = "chkCut";
            this.chkCut.UseVisualStyleBackColor = false;
            // 
            // niceLine2
            // 
            this.niceLine2.BackColor = System.Drawing.Color.Transparent;
            this.niceLine2.Caption = "Disable";
            resources.ApplyResources(this.niceLine2, "niceLine2");
            this.niceLine2.ForeColor = System.Drawing.Color.DarkBlue;
            this.niceLine2.Name = "niceLine2";
            // 
            // niceLine1
            // 
            this.niceLine1.BackColor = System.Drawing.Color.Transparent;
            this.niceLine1.Caption = "Disable for :";
            resources.ApplyResources(this.niceLine1, "niceLine1");
            this.niceLine1.ForeColor = System.Drawing.Color.DarkBlue;
            this.niceLine1.Name = "niceLine1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.tsiDownload,
            this.pleaseShareToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::DisableContextMenuItems.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.requirePasswordToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            resources.ApplyResources(this.changePasswordToolStripMenuItem, "changePasswordToolStripMenuItem");
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // requirePasswordToolStripMenuItem
            // 
            this.requirePasswordToolStripMenuItem.Name = "requirePasswordToolStripMenuItem";
            resources.ApplyResources(this.requirePasswordToolStripMenuItem, "requirePasswordToolStripMenuItem");
            this.requirePasswordToolStripMenuItem.Click += new System.EventHandler(this.requirePasswordToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languages1ToolStripMenuItem,
            this.languages2ToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // languages1ToolStripMenuItem
            // 
            this.languages1ToolStripMenuItem.Name = "languages1ToolStripMenuItem";
            resources.ApplyResources(this.languages1ToolStripMenuItem, "languages1ToolStripMenuItem");
            // 
            // languages2ToolStripMenuItem
            // 
            this.languages2ToolStripMenuItem.Name = "languages2ToolStripMenuItem";
            resources.ApplyResources(this.languages2ToolStripMenuItem, "languages2ToolStripMenuItem");
            // 
            // tsiDownload
            // 
            this.tsiDownload.Name = "tsiDownload";
            resources.ApplyResources(this.tsiDownload, "tsiDownload");
            // 
            // pleaseShareToolStripMenuItem
            // 
            this.pleaseShareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shareOnFacebookToolStripMenuItem,
            this.shareOnTwitterToolStripMenuItem,
            this.shareOnGooglePlusToolStripMenuItem,
            this.shareOnLinkedinToolStripMenuItem,
            this.shareWithEmailToolStripMenuItem});
            this.pleaseShareToolStripMenuItem.Name = "pleaseShareToolStripMenuItem";
            resources.ApplyResources(this.pleaseShareToolStripMenuItem, "pleaseShareToolStripMenuItem");
            // 
            // shareOnFacebookToolStripMenuItem
            // 
            this.shareOnFacebookToolStripMenuItem.Image = global::DisableContextMenuItems.Properties.Resources.facebook_24;
            this.shareOnFacebookToolStripMenuItem.Name = "shareOnFacebookToolStripMenuItem";
            resources.ApplyResources(this.shareOnFacebookToolStripMenuItem, "shareOnFacebookToolStripMenuItem");
            this.shareOnFacebookToolStripMenuItem.Click += new System.EventHandler(this.shareOnFacebookToolStripMenuItem_Click);
            // 
            // shareOnTwitterToolStripMenuItem
            // 
            this.shareOnTwitterToolStripMenuItem.Image = global::DisableContextMenuItems.Properties.Resources.twitter_24;
            this.shareOnTwitterToolStripMenuItem.Name = "shareOnTwitterToolStripMenuItem";
            resources.ApplyResources(this.shareOnTwitterToolStripMenuItem, "shareOnTwitterToolStripMenuItem");
            this.shareOnTwitterToolStripMenuItem.Click += new System.EventHandler(this.shareOnTwitterToolStripMenuItem_Click);
            // 
            // shareOnGooglePlusToolStripMenuItem
            // 
            this.shareOnGooglePlusToolStripMenuItem.Image = global::DisableContextMenuItems.Properties.Resources.googleplus_24;
            this.shareOnGooglePlusToolStripMenuItem.Name = "shareOnGooglePlusToolStripMenuItem";
            resources.ApplyResources(this.shareOnGooglePlusToolStripMenuItem, "shareOnGooglePlusToolStripMenuItem");
            this.shareOnGooglePlusToolStripMenuItem.Click += new System.EventHandler(this.shareOnGooglePlusToolStripMenuItem_Click);
            // 
            // shareOnLinkedinToolStripMenuItem
            // 
            this.shareOnLinkedinToolStripMenuItem.Image = global::DisableContextMenuItems.Properties.Resources.linkedin_24;
            this.shareOnLinkedinToolStripMenuItem.Name = "shareOnLinkedinToolStripMenuItem";
            resources.ApplyResources(this.shareOnLinkedinToolStripMenuItem, "shareOnLinkedinToolStripMenuItem");
            this.shareOnLinkedinToolStripMenuItem.Click += new System.EventHandler(this.shareOnLinkedinToolStripMenuItem_Click);
            // 
            // shareWithEmailToolStripMenuItem
            // 
            this.shareWithEmailToolStripMenuItem.Image = global::DisableContextMenuItems.Properties.Resources.mail;
            this.shareWithEmailToolStripMenuItem.Name = "shareWithEmailToolStripMenuItem";
            resources.ApplyResources(this.shareWithEmailToolStripMenuItem, "shareWithEmailToolStripMenuItem");
            this.shareWithEmailToolStripMenuItem.Click += new System.EventHandler(this.shareWithEmailToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpUsersManualToolStripMenuItem,
            this.toolStripMenuItem6,
            this.pleaseDonateToolStripMenuItem1,
            this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem,
            this.followUsOnTwitterToolStripMenuItem,
            this.visit4dotsSoftwareWebpageToolStripMenuItem,
            this.toolStripMenuItem5,
            this.checkForNewVersionEachWeekToolStripMenuItem,
            this.feedbackToolStripMenuItem,
            this.checkForNewVersionToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // helpUsersManualToolStripMenuItem
            // 
            this.helpUsersManualToolStripMenuItem.Image = global::DisableContextMenuItems.Properties.Resources.help2;
            this.helpUsersManualToolStripMenuItem.Name = "helpUsersManualToolStripMenuItem";
            resources.ApplyResources(this.helpUsersManualToolStripMenuItem, "helpUsersManualToolStripMenuItem");
            this.helpUsersManualToolStripMenuItem.Click += new System.EventHandler(this.helpUsersManualToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
            // 
            // pleaseDonateToolStripMenuItem1
            // 
            this.pleaseDonateToolStripMenuItem1.BackColor = System.Drawing.Color.Gold;
            resources.ApplyResources(this.pleaseDonateToolStripMenuItem1, "pleaseDonateToolStripMenuItem1");
            this.pleaseDonateToolStripMenuItem1.Name = "pleaseDonateToolStripMenuItem1";
            this.pleaseDonateToolStripMenuItem1.Click += new System.EventHandler(this.pleaseDonateToolStripMenuItem_Click);
            // 
            // dotsSoftwarePRODUCTCATALOGToolStripMenuItem
            // 
            resources.ApplyResources(this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem, "dotsSoftwarePRODUCTCATALOGToolStripMenuItem");
            this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem.Name = "dotsSoftwarePRODUCTCATALOGToolStripMenuItem";
            this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem.Click += new System.EventHandler(this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem_Click);
            // 
            // followUsOnTwitterToolStripMenuItem
            // 
            this.followUsOnTwitterToolStripMenuItem.Image = global::DisableContextMenuItems.Properties.Resources.twitter_24;
            this.followUsOnTwitterToolStripMenuItem.Name = "followUsOnTwitterToolStripMenuItem";
            resources.ApplyResources(this.followUsOnTwitterToolStripMenuItem, "followUsOnTwitterToolStripMenuItem");
            this.followUsOnTwitterToolStripMenuItem.Click += new System.EventHandler(this.followUsOnTwitterToolStripMenuItem_Click);
            // 
            // visit4dotsSoftwareWebpageToolStripMenuItem
            // 
            this.visit4dotsSoftwareWebpageToolStripMenuItem.Image = global::DisableContextMenuItems.Properties.Resources.earth;
            this.visit4dotsSoftwareWebpageToolStripMenuItem.Name = "visit4dotsSoftwareWebpageToolStripMenuItem";
            resources.ApplyResources(this.visit4dotsSoftwareWebpageToolStripMenuItem, "visit4dotsSoftwareWebpageToolStripMenuItem");
            this.visit4dotsSoftwareWebpageToolStripMenuItem.Click += new System.EventHandler(this.visit4dotsSoftwareWebpageToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            // 
            // checkForNewVersionEachWeekToolStripMenuItem
            // 
            this.checkForNewVersionEachWeekToolStripMenuItem.CheckOnClick = true;
            this.checkForNewVersionEachWeekToolStripMenuItem.Name = "checkForNewVersionEachWeekToolStripMenuItem";
            resources.ApplyResources(this.checkForNewVersionEachWeekToolStripMenuItem, "checkForNewVersionEachWeekToolStripMenuItem");
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            resources.ApplyResources(this.feedbackToolStripMenuItem, "feedbackToolStripMenuItem");
            this.feedbackToolStripMenuItem.Click += new System.EventHandler(this.feedbackToolStripMenuItem_Click);
            // 
            // checkForNewVersionToolStripMenuItem
            // 
            this.checkForNewVersionToolStripMenuItem.Name = "checkForNewVersionToolStripMenuItem";
            resources.ApplyResources(this.checkForNewVersionToolStripMenuItem, "checkForNewVersionToolStripMenuItem");
            this.checkForNewVersionToolStripMenuItem.Click += new System.EventHandler(this.checkForNewVersionToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.chkSelectUsers);
            this.Controls.Add(this.chkAllUsers);
            this.Controls.Add(this.chkCurrentUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInvSel);
            this.Controls.Add(this.btnUnSelAll);
            this.Controls.Add(this.btnSelAll);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.niceLine4);
            this.Controls.Add(this.chkDoubleClickOpen);
            this.Controls.Add(this.niceLine3);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkProperties);
            this.Controls.Add(this.chkRename);
            this.Controls.Add(this.chkDelete);
            this.Controls.Add(this.chkCopy);
            this.Controls.Add(this.chkCut);
            this.Controls.Add(this.niceLine2);
            this.Controls.Add(this.niceLine1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowInTaskbar = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NiceLine niceLine1;
        private System.Windows.Forms.CheckedListBox lstUsers;
        private System.Windows.Forms.Button btnAddCurrentUser;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnUnselectAll;
        private System.Windows.Forms.Button btnInvertSelection;
        private NiceLine niceLine2;
        private System.Windows.Forms.CheckBox chkCut;
        private System.Windows.Forms.CheckBox chkCopy;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.CheckBox chkRename;
        private System.Windows.Forms.CheckBox chkProperties;
        private System.Windows.Forms.Button btnOK;
        private NiceLine niceLine3;
        private System.Windows.Forms.CheckBox chkDoubleClickOpen;
        private NiceLine niceLine4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnInvSel;
        private System.Windows.Forms.Button btnUnSelAll;
        private System.Windows.Forms.Button btnSelAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton chkCurrentUser;
        private System.Windows.Forms.RadioButton chkAllUsers;
        private System.Windows.Forms.RadioButton chkSelectUsers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsiDownload;
        private System.Windows.Forms.ToolStripMenuItem pleaseShareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shareOnFacebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shareOnTwitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shareOnGooglePlusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shareOnLinkedinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shareWithEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpUsersManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem pleaseDonateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dotsSoftwarePRODUCTCATALOGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem followUsOnTwitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visit4dotsSoftwareWebpageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForNewVersionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languages1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languages2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requirePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForNewVersionEachWeekToolStripMenuItem;
    }
}
