namespace FantasyLeagueOrganizer
{
	partial class frmMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            btnRecreateLeague = new Button();
            listItems = new ListBox();
            btnLoadLeague = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnFreeAgents = new Button();
            leagueSummary1 = new FantasyLeagueOrganizer.controls.LeagueSummary();
            btnSaveLeague = new Button();
            grpTeams = new GroupBox();
            btnSetLineup = new Button();
            label5 = new Label();
            listRoster = new ListBox();
            tbTeamNameCurrent = new TextBox();
            label4 = new Label();
            btnSelectTeamColor = new Button();
            label3 = new Label();
            tbNewTeamColor = new TextBox();
            label2 = new Label();
            btnAddOrUpdateTeam = new Button();
            tbTeamNameNew = new TextBox();
            listTeams = new ListBox();
            btnRefreshInterface = new Button();
            grpCategories = new GroupBox();
            nudRequiredCount = new NumericUpDown();
            btnDeleteCategory = new Button();
            listCategories = new ListBox();
            label1 = new Label();
            btnAddOrUpdateCategory = new Button();
            tbNewCategory = new TextBox();
            grpItems = new GroupBox();
            btnDeleteItem = new Button();
            chkListCategories = new CheckedListBox();
            lblCategories = new Label();
            lblName = new Label();
            btnAddOrUpdateItem = new Button();
            tbNewItem = new TextBox();
            tabPage2 = new TabPage();
            tbMessages = new TextBox();
            label6 = new Label();
            nudNumWeeks = new NumericUpDown();
            btnGenerateSchedule = new Button();
            leagueSummary2 = new FantasyLeagueOrganizer.controls.LeagueSummary();
            colorDialog1 = new ColorDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            grpTeams.SuspendLayout();
            grpCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudRequiredCount).BeginInit();
            grpItems.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumWeeks).BeginInit();
            SuspendLayout();
            // 
            // btnRecreateLeague
            // 
            btnRecreateLeague.Location = new Point(215, 35);
            btnRecreateLeague.Name = "btnRecreateLeague";
            btnRecreateLeague.Size = new Size(201, 23);
            btnRecreateLeague.TabIndex = 0;
            btnRecreateLeague.Text = "Recreate League";
            btnRecreateLeague.UseVisualStyleBackColor = true;
            btnRecreateLeague.Click += btnRecreateLeague_Click;
            // 
            // listItems
            // 
            listItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listItems.FormattingEnabled = true;
            listItems.Location = new Point(6, 22);
            listItems.Name = "listItems";
            listItems.Size = new Size(152, 304);
            listItems.TabIndex = 1;
            listItems.SelectedIndexChanged += listItems_SelectedIndexChanged;
            // 
            // btnLoadLeague
            // 
            btnLoadLeague.Location = new Point(8, 6);
            btnLoadLeague.Name = "btnLoadLeague";
            btnLoadLeague.Size = new Size(201, 23);
            btnLoadLeague.TabIndex = 3;
            btnLoadLeague.Text = "Load League from Database";
            btnLoadLeague.UseVisualStyleBackColor = true;
            btnLoadLeague.Click += btnLoadLeague_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1356, 676);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnFreeAgents);
            tabPage1.Controls.Add(leagueSummary1);
            tabPage1.Controls.Add(btnSaveLeague);
            tabPage1.Controls.Add(grpTeams);
            tabPage1.Controls.Add(btnRefreshInterface);
            tabPage1.Controls.Add(grpCategories);
            tabPage1.Controls.Add(grpItems);
            tabPage1.Controls.Add(btnRecreateLeague);
            tabPage1.Controls.Add(btnLoadLeague);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1348, 648);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Setup";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnFreeAgents
            // 
            btnFreeAgents.Location = new Point(422, 6);
            btnFreeAgents.Name = "btnFreeAgents";
            btnFreeAgents.Size = new Size(201, 23);
            btnFreeAgents.TabIndex = 14;
            btnFreeAgents.Text = "Free Agents";
            btnFreeAgents.UseVisualStyleBackColor = true;
            btnFreeAgents.Click += btnFreeAgents_Click;
            // 
            // leagueSummary1
            // 
            leagueSummary1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            leagueSummary1.Location = new Point(921, 64);
            leagueSummary1.Name = "leagueSummary1";
            leagueSummary1.Size = new Size(419, 578);
            leagueSummary1.TabIndex = 13;
            // 
            // btnSaveLeague
            // 
            btnSaveLeague.Location = new Point(215, 6);
            btnSaveLeague.Name = "btnSaveLeague";
            btnSaveLeague.Size = new Size(201, 23);
            btnSaveLeague.TabIndex = 12;
            btnSaveLeague.Text = "Save League to Database";
            btnSaveLeague.UseVisualStyleBackColor = true;
            btnSaveLeague.Click += btnSaveLeague_Click;
            // 
            // grpTeams
            // 
            grpTeams.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpTeams.Controls.Add(btnSetLineup);
            grpTeams.Controls.Add(label5);
            grpTeams.Controls.Add(listRoster);
            grpTeams.Controls.Add(tbTeamNameCurrent);
            grpTeams.Controls.Add(label4);
            grpTeams.Controls.Add(btnSelectTeamColor);
            grpTeams.Controls.Add(label3);
            grpTeams.Controls.Add(tbNewTeamColor);
            grpTeams.Controls.Add(label2);
            grpTeams.Controls.Add(btnAddOrUpdateTeam);
            grpTeams.Controls.Add(tbTeamNameNew);
            grpTeams.Controls.Add(listTeams);
            grpTeams.Location = new Point(441, 64);
            grpTeams.Name = "grpTeams";
            grpTeams.Size = new Size(474, 578);
            grpTeams.TabIndex = 11;
            grpTeams.TabStop = false;
            grpTeams.Text = "Teams";
            // 
            // btnSetLineup
            // 
            btnSetLineup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSetLineup.Location = new Point(226, 139);
            btnSetLineup.Name = "btnSetLineup";
            btnSetLineup.Size = new Size(242, 23);
            btnSetLineup.TabIndex = 21;
            btnSetLineup.Text = "Set Lineup";
            btnSetLineup.UseVisualStyleBackColor = true;
            btnSetLineup.Click += btnSetLineup_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 179);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 16;
            label5.Text = "Roster";
            // 
            // listRoster
            // 
            listRoster.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listRoster.FormattingEnabled = true;
            listRoster.Location = new Point(6, 197);
            listRoster.Name = "listRoster";
            listRoster.SelectionMode = SelectionMode.MultiExtended;
            listRoster.Size = new Size(462, 364);
            listRoster.TabIndex = 15;
            // 
            // tbTeamNameCurrent
            // 
            tbTeamNameCurrent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbTeamNameCurrent.Location = new Point(314, 22);
            tbTeamNameCurrent.Name = "tbTeamNameCurrent";
            tbTeamNameCurrent.Size = new Size(154, 23);
            tbTeamNameCurrent.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(226, 55);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 13;
            label4.Text = "New Name";
            // 
            // btnSelectTeamColor
            // 
            btnSelectTeamColor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelectTeamColor.Location = new Point(420, 81);
            btnSelectTeamColor.Name = "btnSelectTeamColor";
            btnSelectTeamColor.Size = new Size(48, 23);
            btnSelectTeamColor.TabIndex = 12;
            btnSelectTeamColor.Text = "Select";
            btnSelectTeamColor.UseVisualStyleBackColor = true;
            btnSelectTeamColor.Click += btnSelectTeamColor_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 84);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 11;
            label3.Text = "Color";
            // 
            // tbNewTeamColor
            // 
            tbNewTeamColor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbNewTeamColor.Location = new Point(314, 81);
            tbNewTeamColor.Name = "tbNewTeamColor";
            tbNewTeamColor.Size = new Size(100, 23);
            tbNewTeamColor.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 25);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 9;
            label2.Text = "Current Name";
            // 
            // btnAddOrUpdateTeam
            // 
            btnAddOrUpdateTeam.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAddOrUpdateTeam.Location = new Point(226, 110);
            btnAddOrUpdateTeam.Name = "btnAddOrUpdateTeam";
            btnAddOrUpdateTeam.Size = new Size(242, 23);
            btnAddOrUpdateTeam.TabIndex = 8;
            btnAddOrUpdateTeam.Text = "Add/Update Team";
            btnAddOrUpdateTeam.UseVisualStyleBackColor = true;
            btnAddOrUpdateTeam.Click += btnAddTeamToLeague_Click;
            // 
            // tbTeamNameNew
            // 
            tbTeamNameNew.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbTeamNameNew.Location = new Point(314, 52);
            tbTeamNameNew.Name = "tbTeamNameNew";
            tbTeamNameNew.Size = new Size(154, 23);
            tbTeamNameNew.TabIndex = 7;
            // 
            // listTeams
            // 
            listTeams.FormattingEnabled = true;
            listTeams.Location = new Point(6, 22);
            listTeams.Name = "listTeams";
            listTeams.Size = new Size(197, 139);
            listTeams.TabIndex = 6;
            listTeams.SelectedIndexChanged += listTeams_SelectedIndexChanged;
            // 
            // btnRefreshInterface
            // 
            btnRefreshInterface.Location = new Point(8, 35);
            btnRefreshInterface.Name = "btnRefreshInterface";
            btnRefreshInterface.Size = new Size(201, 23);
            btnRefreshInterface.TabIndex = 10;
            btnRefreshInterface.Text = "Refresh Interface";
            btnRefreshInterface.UseVisualStyleBackColor = true;
            btnRefreshInterface.Click += btnRefreshInterface_Click;
            // 
            // grpCategories
            // 
            grpCategories.Controls.Add(nudRequiredCount);
            grpCategories.Controls.Add(btnDeleteCategory);
            grpCategories.Controls.Add(listCategories);
            grpCategories.Controls.Add(label1);
            grpCategories.Controls.Add(btnAddOrUpdateCategory);
            grpCategories.Controls.Add(tbNewCategory);
            grpCategories.Location = new Point(8, 64);
            grpCategories.Name = "grpCategories";
            grpCategories.Size = new Size(427, 203);
            grpCategories.TabIndex = 9;
            grpCategories.TabStop = false;
            grpCategories.Tag = "";
            grpCategories.Text = "Categories";
            // 
            // nudRequiredCount
            // 
            nudRequiredCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudRequiredCount.Location = new Point(239, 51);
            nudRequiredCount.Name = "nudRequiredCount";
            nudRequiredCount.Size = new Size(182, 23);
            nudRequiredCount.TabIndex = 7;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleteCategory.Location = new Point(6, 174);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(152, 23);
            btnDeleteCategory.TabIndex = 6;
            btnDeleteCategory.Text = "Delete Selected";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // listCategories
            // 
            listCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listCategories.FormattingEnabled = true;
            listCategories.Location = new Point(6, 22);
            listCategories.Name = "listCategories";
            listCategories.Size = new Size(152, 139);
            listCategories.TabIndex = 5;
            listCategories.SelectedIndexChanged += listCategories_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 25);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // btnAddOrUpdateCategory
            // 
            btnAddOrUpdateCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAddOrUpdateCategory.Location = new Point(194, 80);
            btnAddOrUpdateCategory.Name = "btnAddOrUpdateCategory";
            btnAddOrUpdateCategory.Size = new Size(227, 23);
            btnAddOrUpdateCategory.TabIndex = 3;
            btnAddOrUpdateCategory.Text = "Add/Update Category";
            btnAddOrUpdateCategory.UseVisualStyleBackColor = true;
            btnAddOrUpdateCategory.Click += btnAddCategoryToLeague_Click;
            // 
            // tbNewCategory
            // 
            tbNewCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbNewCategory.Location = new Point(239, 22);
            tbNewCategory.Name = "tbNewCategory";
            tbNewCategory.Size = new Size(182, 23);
            tbNewCategory.TabIndex = 0;
            // 
            // grpItems
            // 
            grpItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpItems.Controls.Add(btnDeleteItem);
            grpItems.Controls.Add(chkListCategories);
            grpItems.Controls.Add(lblCategories);
            grpItems.Controls.Add(lblName);
            grpItems.Controls.Add(btnAddOrUpdateItem);
            grpItems.Controls.Add(tbNewItem);
            grpItems.Controls.Add(listItems);
            grpItems.Location = new Point(8, 273);
            grpItems.Name = "grpItems";
            grpItems.Size = new Size(427, 367);
            grpItems.TabIndex = 8;
            grpItems.TabStop = false;
            grpItems.Tag = "";
            grpItems.Text = "Items";
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleteItem.Location = new Point(6, 338);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(152, 23);
            btnDeleteItem.TabIndex = 8;
            btnDeleteItem.Text = "Delete Selected";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // chkListCategories
            // 
            chkListCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chkListCategories.CheckOnClick = true;
            chkListCategories.FormattingEnabled = true;
            chkListCategories.Location = new Point(263, 57);
            chkListCategories.Name = "chkListCategories";
            chkListCategories.Size = new Size(157, 274);
            chkListCategories.TabIndex = 7;
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Location = new Point(194, 61);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(63, 15);
            lblCategories.TabIndex = 6;
            lblCategories.Text = "Categories";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(194, 31);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // btnAddOrUpdateItem
            // 
            btnAddOrUpdateItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddOrUpdateItem.Location = new Point(194, 338);
            btnAddOrUpdateItem.Name = "btnAddOrUpdateItem";
            btnAddOrUpdateItem.Size = new Size(227, 23);
            btnAddOrUpdateItem.TabIndex = 3;
            btnAddOrUpdateItem.Text = "Add/Update Item";
            btnAddOrUpdateItem.UseVisualStyleBackColor = true;
            btnAddOrUpdateItem.Click += btnAddItemToLeague_Click;
            // 
            // tbNewItem
            // 
            tbNewItem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbNewItem.Location = new Point(263, 28);
            tbNewItem.Name = "tbNewItem";
            tbNewItem.Size = new Size(158, 23);
            tbNewItem.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tbMessages);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(nudNumWeeks);
            tabPage2.Controls.Add(btnGenerateSchedule);
            tabPage2.Controls.Add(leagueSummary2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1348, 648);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Schedule";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbMessages
            // 
            tbMessages.Location = new Point(584, 6);
            tbMessages.Multiline = true;
            tbMessages.Name = "tbMessages";
            tbMessages.ScrollBars = ScrollBars.Vertical;
            tbMessages.Size = new Size(358, 425);
            tbMessages.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 39);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 3;
            label6.Text = "# Weeks";
            // 
            // nudNumWeeks
            // 
            nudNumWeeks.Location = new Point(101, 37);
            nudNumWeeks.Name = "nudNumWeeks";
            nudNumWeeks.Size = new Size(120, 23);
            nudNumWeeks.TabIndex = 2;
            nudNumWeeks.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // btnGenerateSchedule
            // 
            btnGenerateSchedule.Location = new Point(17, 66);
            btnGenerateSchedule.Name = "btnGenerateSchedule";
            btnGenerateSchedule.Size = new Size(138, 23);
            btnGenerateSchedule.TabIndex = 1;
            btnGenerateSchedule.Text = "Generate Schedule";
            btnGenerateSchedule.UseVisualStyleBackColor = true;
            btnGenerateSchedule.Click += btnGenerateSchedule_Click;
            // 
            // leagueSummary2
            // 
            leagueSummary2.Location = new Point(948, 6);
            leagueSummary2.Name = "leagueSummary2";
            leagueSummary2.Size = new Size(394, 425);
            leagueSummary2.TabIndex = 0;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1356, 676);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            Text = "Fantasty League Organizer";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            grpTeams.ResumeLayout(false);
            grpTeams.PerformLayout();
            grpCategories.ResumeLayout(false);
            grpCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudRequiredCount).EndInit();
            grpItems.ResumeLayout(false);
            grpItems.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumWeeks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRecreateLeague;
		private ListBox listItems;
		private Button btnLoadLeague;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private GroupBox grpCategories;
		private ListBox listCategories;
		private Label label1;
		private Button btnAddOrUpdateCategory;
		private TextBox tbNewCategory;
		private GroupBox grpItems;
		private Label lblCategories;
		private Label lblName;
		private TextBox tbNewItem;
		private CheckedListBox chkListCategories;
		private Button btnRefreshInterface;
		private GroupBox grpTeams;
		private Button btnAddOrUpdateTeam;
		private TextBox tbTeamNameNew;
		private ListBox listTeams;
		private Button btnSelectTeamColor;
		private Label label3;
		private TextBox tbNewTeamColor;
		private ColorDialog colorDialog1;
		private Button btnSaveLeague;
		private TextBox tbTeamNameCurrent;
		private Label label4;
		private Label label2;
		private Button btnDeleteCategory;
		private Button btnDeleteItem;
		private Button btnAddOrUpdateItem;
		private ListBox listRoster;
		private Label label5;
        private NumericUpDown nudRequiredCount;
        private Button btnSetLineup;
        private controls.LeagueSummary leagueSummary1;
        private Button btnGenerateSchedule;
        private controls.LeagueSummary leagueSummary2;
        private Label label6;
        private NumericUpDown nudNumWeeks;
        private TextBox tbMessages;
        private Button btnFreeAgents;
    }
}
