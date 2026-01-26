namespace FantasyLeagueOrganizer.Controls
{
	partial class TeamDisplaySmall
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblRecord = new Label();
            tbLineupStatus = new TextBox();
            btnEditLineup = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(3, 7);
            lblName.Name = "lblName";
            lblName.Size = new Size(73, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Team Name";
            // 
            // lblRecord
            // 
            lblRecord.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRecord.AutoSize = true;
            lblRecord.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecord.Location = new Point(219, 7);
            lblRecord.Name = "lblRecord";
            lblRecord.Size = new Size(47, 15);
            lblRecord.TabIndex = 3;
            lblRecord.Text = "6W - 7L";
            // 
            // tbLineupStatus
            // 
            tbLineupStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbLineupStatus.Location = new Point(272, 4);
            tbLineupStatus.Name = "tbLineupStatus";
            tbLineupStatus.ReadOnly = true;
            tbLineupStatus.Size = new Size(116, 23);
            tbLineupStatus.TabIndex = 5;
            // 
            // btnEditLineup
            // 
            btnEditLineup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditLineup.Location = new Point(394, 4);
            btnEditLineup.Name = "btnEditLineup";
            btnEditLineup.Size = new Size(85, 23);
            btnEditLineup.TabIndex = 6;
            btnEditLineup.Text = "Edit Lineup";
            btnEditLineup.UseVisualStyleBackColor = true;
            btnEditLineup.Click += btnEditLineup_Click;
            // 
            // TeamDisplaySmall
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnEditLineup);
            Controls.Add(tbLineupStatus);
            Controls.Add(lblRecord);
            Controls.Add(lblName);
            Name = "TeamDisplaySmall";
            Size = new Size(482, 31);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
		private Label label1;
		private Label label2;
		private Label lblRecord;
        private TextBox tbLineupStatus;
        private TextBox tbRosterSpots;
		private TextBox tbLineupSpots;
		private TextBox tbRecord;
        private Button btnEditLineup;
    }
}
