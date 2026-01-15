namespace FantasyLeagueOrganizer.controls
{
    partial class MatchupSmall
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
            tbTeamA = new TextBox();
            tbTeamB = new TextBox();
            lblVS = new Label();
            lblWeek = new Label();
            lblTeamARecord = new Label();
            lblTeamBRecord = new Label();
            lblTeamAResult = new Label();
            lblTeamBResult = new Label();
            lblScore = new Label();
            btnPlay = new Button();
            SuspendLayout();
            // 
            // tbTeamA
            // 
            tbTeamA.Location = new Point(3, 22);
            tbTeamA.Name = "tbTeamA";
            tbTeamA.Size = new Size(133, 23);
            tbTeamA.TabIndex = 0;
            // 
            // tbTeamB
            // 
            tbTeamB.Location = new Point(244, 23);
            tbTeamB.Name = "tbTeamB";
            tbTeamB.Size = new Size(133, 23);
            tbTeamB.TabIndex = 1;
            // 
            // lblVS
            // 
            lblVS.AutoSize = true;
            lblVS.Location = new Point(161, 26);
            lblVS.Name = "lblVS";
            lblVS.Size = new Size(20, 15);
            lblVS.TabIndex = 2;
            lblVS.Text = "VS";
            // 
            // lblWeek
            // 
            lblWeek.Location = new Point(168, 4);
            lblWeek.Name = "lblWeek";
            lblWeek.Size = new Size(45, 15);
            lblWeek.TabIndex = 3;
            lblWeek.Text = "Week 0";
            lblWeek.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTeamARecord
            // 
            lblTeamARecord.Location = new Point(3, 48);
            lblTeamARecord.Name = "lblTeamARecord";
            lblTeamARecord.Size = new Size(100, 15);
            lblTeamARecord.TabIndex = 4;
            lblTeamARecord.Text = "0 - 0 - 0";
            lblTeamARecord.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTeamBRecord
            // 
            lblTeamBRecord.Location = new Point(277, 49);
            lblTeamBRecord.Name = "lblTeamBRecord";
            lblTeamBRecord.Size = new Size(100, 15);
            lblTeamBRecord.TabIndex = 5;
            lblTeamBRecord.Text = "0 - 0 - 0";
            lblTeamBRecord.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTeamAResult
            // 
            lblTeamAResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeamAResult.Location = new Point(136, 26);
            lblTeamAResult.Name = "lblTeamAResult";
            lblTeamAResult.Size = new Size(20, 15);
            lblTeamAResult.TabIndex = 6;
            lblTeamAResult.Text = "W";
            lblTeamAResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTeamBResult
            // 
            lblTeamBResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeamBResult.Location = new Point(224, 27);
            lblTeamBResult.Name = "lblTeamBResult";
            lblTeamBResult.RightToLeft = RightToLeft.No;
            lblTeamBResult.Size = new Size(20, 15);
            lblTeamBResult.TabIndex = 7;
            lblTeamBResult.Text = "W";
            lblTeamBResult.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblScore
            // 
            lblScore.Location = new Point(140, 48);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(100, 15);
            lblScore.TabIndex = 8;
            lblScore.Text = "(0 - 0)";
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(162, 22);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(56, 23);
            btnPlay.TabIndex = 9;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // MatchupSmall
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnPlay);
            Controls.Add(lblScore);
            Controls.Add(lblTeamBResult);
            Controls.Add(lblTeamAResult);
            Controls.Add(lblTeamBRecord);
            Controls.Add(lblTeamARecord);
            Controls.Add(lblWeek);
            Controls.Add(lblVS);
            Controls.Add(tbTeamB);
            Controls.Add(tbTeamA);
            Name = "MatchupSmall";
            Size = new Size(380, 73);
            Resize += MatchupSmall_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTeamA;
        private TextBox tbTeamB;
        private Label lblVS;
        private Label lblWeek;
        private Label lblTeamARecord;
        private Label lblTeamBRecord;
        private Label lblTeamAResult;
        private Label lblTeamBResult;
        private Label lblScore;
        private Button btnPlay;
    }
}
