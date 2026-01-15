namespace FantasyLeagueOrganizer.Forms
{
    partial class frmPlayMatchup
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnRevealNext = new Button();
            tbTeamA = new TextBox();
            tbTeamB = new TextBox();
            lblScoreA = new Label();
            lblScoreB = new Label();
            lblVS = new Label();
            panel1 = new Panel();
            btnPlay = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Location = new Point(3, 66);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1319, 514);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Resize += flowLayoutPanel1_Resize;
            // 
            // btnRevealNext
            // 
            btnRevealNext.Location = new Point(15, 12);
            btnRevealNext.Name = "btnRevealNext";
            btnRevealNext.Size = new Size(186, 43);
            btnRevealNext.TabIndex = 1;
            btnRevealNext.Text = "Reveal Next";
            btnRevealNext.UseVisualStyleBackColor = true;
            btnRevealNext.Click += btnRevealNext_Click;
            // 
            // tbTeamA
            // 
            tbTeamA.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTeamA.Location = new Point(3, 3);
            tbTeamA.Name = "tbTeamA";
            tbTeamA.ReadOnly = true;
            tbTeamA.Size = new Size(522, 57);
            tbTeamA.TabIndex = 2;
            tbTeamA.Text = "Team A";
            // 
            // tbTeamB
            // 
            tbTeamB.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTeamB.Location = new Point(800, 3);
            tbTeamB.Name = "tbTeamB";
            tbTeamB.ReadOnly = true;
            tbTeamB.Size = new Size(522, 57);
            tbTeamB.TabIndex = 3;
            tbTeamB.Text = "Team B";
            tbTeamB.TextAlign = HorizontalAlignment.Right;
            // 
            // lblScoreA
            // 
            lblScoreA.Font = new Font("Segoe UI", 27.75F);
            lblScoreA.Location = new Point(531, 3);
            lblScoreA.Name = "lblScoreA";
            lblScoreA.Size = new Size(93, 57);
            lblScoreA.TabIndex = 4;
            lblScoreA.Text = "0";
            lblScoreA.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblScoreB
            // 
            lblScoreB.Font = new Font("Segoe UI", 27.75F);
            lblScoreB.Location = new Point(701, 3);
            lblScoreB.Name = "lblScoreB";
            lblScoreB.Size = new Size(93, 57);
            lblScoreB.TabIndex = 5;
            lblScoreB.Text = "0";
            lblScoreB.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVS
            // 
            lblVS.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVS.Location = new Point(630, 3);
            lblVS.MinimumSize = new Size(65, 57);
            lblVS.Name = "lblVS";
            lblVS.Size = new Size(65, 57);
            lblVS.TabIndex = 6;
            lblVS.Text = "VS";
            lblVS.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblScoreA);
            panel1.Controls.Add(tbTeamA);
            panel1.Controls.Add(lblVS);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(lblScoreB);
            panel1.Controls.Add(tbTeamB);
            panel1.Location = new Point(12, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(1325, 583);
            panel1.TabIndex = 7;
            panel1.Resize += panel1_Resize;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(207, 12);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(186, 43);
            btnPlay.TabIndex = 8;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // frmPlayMatchup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 656);
            Controls.Add(btnPlay);
            Controls.Add(panel1);
            Controls.Add(btnRevealNext);
            Name = "frmPlayMatchup";
            Text = "frmPlayMatchup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnRevealNext;
        private TextBox tbTeamA;
        private TextBox tbTeamB;
        private Label lblScoreA;
        private Label lblScoreB;
        private Label lblVS;
        private Panel panel1;
        private Button btnPlay;
    }
}