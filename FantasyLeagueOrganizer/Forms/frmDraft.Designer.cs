namespace FantasyLeagueOrganizer.Forms
{
    partial class frmDraft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDraft));
            freeAgentsLarge1 = new FantasyLeagueOrganizer.Controls.FreeAgentsLarge();
            tbCurrentTeam = new TextBox();
            lblHotSeat = new Label();
            tbOnDeck = new TextBox();
            lblOnDeck = new Label();
            label2 = new Label();
            tbInTheHole = new TextBox();
            listDraftOrder = new ListBox();
            tbSelectedPick = new TextBox();
            lblSelectedPick = new Label();
            btnLockInPick = new Button();
            lineupViewer1 = new FantasyLeagueOrganizer.Controls.LineupViewer();
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            tbLastPick = new TextBox();
            label3 = new Label();
            tbLastTeam = new TextBox();
            label4 = new Label();
            tbPick = new TextBox();
            label5 = new Label();
            tbRound = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // freeAgentsLarge1
            // 
            freeAgentsLarge1.Dock = DockStyle.Fill;
            freeAgentsLarge1.Location = new Point(0, 0);
            freeAgentsLarge1.Name = "freeAgentsLarge1";
            freeAgentsLarge1.Size = new Size(878, 384);
            freeAgentsLarge1.TabIndex = 0;
            freeAgentsLarge1.SelectedItemChanged += freeAgentsLarge1_SelectedItemChanged;
            // 
            // tbCurrentTeam
            // 
            tbCurrentTeam.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbCurrentTeam.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            tbCurrentTeam.Location = new Point(652, 12);
            tbCurrentTeam.Name = "tbCurrentTeam";
            tbCurrentTeam.ReadOnly = true;
            tbCurrentTeam.Size = new Size(456, 57);
            tbCurrentTeam.TabIndex = 1;
            tbCurrentTeam.Text = "Team Name";
            // 
            // lblHotSeat
            // 
            lblHotSeat.AutoSize = true;
            lblHotSeat.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            lblHotSeat.Location = new Point(464, 15);
            lblHotSeat.Name = "lblHotSeat";
            lblHotSeat.Size = new Size(182, 50);
            lblHotSeat.TabIndex = 2;
            lblHotSeat.Text = "Hot Seat:";
            // 
            // tbOnDeck
            // 
            tbOnDeck.Font = new Font("Segoe UI", 15.75F);
            tbOnDeck.Location = new Point(148, 12);
            tbOnDeck.Name = "tbOnDeck";
            tbOnDeck.ReadOnly = true;
            tbOnDeck.Size = new Size(271, 35);
            tbOnDeck.TabIndex = 3;
            tbOnDeck.Text = "Team Name";
            // 
            // lblOnDeck
            // 
            lblOnDeck.AutoSize = true;
            lblOnDeck.Font = new Font("Segoe UI", 15.75F);
            lblOnDeck.Location = new Point(49, 15);
            lblOnDeck.Name = "lblOnDeck";
            lblOnDeck.Size = new Size(93, 30);
            lblOnDeck.TabIndex = 4;
            lblOnDeck.Text = "On Deck";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.Location = new Point(26, 56);
            label2.Name = "label2";
            label2.Size = new Size(116, 30);
            label2.TabIndex = 6;
            label2.Text = "In the Hole";
            // 
            // tbInTheHole
            // 
            tbInTheHole.Font = new Font("Segoe UI", 15.75F);
            tbInTheHole.Location = new Point(148, 53);
            tbInTheHole.Name = "tbInTheHole";
            tbInTheHole.ReadOnly = true;
            tbInTheHole.Size = new Size(271, 35);
            tbInTheHole.TabIndex = 5;
            tbInTheHole.Text = "Team Name";
            // 
            // listDraftOrder
            // 
            listDraftOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listDraftOrder.FormattingEnabled = true;
            listDraftOrder.Location = new Point(12, 94);
            listDraftOrder.Name = "listDraftOrder";
            listDraftOrder.Size = new Size(407, 130);
            listDraftOrder.TabIndex = 8;
            // 
            // tbSelectedPick
            // 
            tbSelectedPick.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbSelectedPick.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSelectedPick.Location = new Point(652, 75);
            tbSelectedPick.Name = "tbSelectedPick";
            tbSelectedPick.ReadOnly = true;
            tbSelectedPick.Size = new Size(456, 57);
            tbSelectedPick.TabIndex = 9;
            // 
            // lblSelectedPick
            // 
            lblSelectedPick.AutoSize = true;
            lblSelectedPick.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectedPick.Location = new Point(464, 78);
            lblSelectedPick.Name = "lblSelectedPick";
            lblSelectedPick.Size = new Size(179, 50);
            lblSelectedPick.TabIndex = 10;
            lblSelectedPick.Text = "Selection:";
            // 
            // btnLockInPick
            // 
            btnLockInPick.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLockInPick.BackColor = Color.FromArgb(128, 255, 128);
            btnLockInPick.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLockInPick.Location = new Point(652, 138);
            btnLockInPick.Name = "btnLockInPick";
            btnLockInPick.Size = new Size(456, 89);
            btnLockInPick.TabIndex = 11;
            btnLockInPick.Text = "LOCK IT IN";
            btnLockInPick.UseVisualStyleBackColor = false;
            btnLockInPick.Click += btnLockInPick_Click;
            // 
            // lineupViewer1
            // 
            lineupViewer1.Dock = DockStyle.Fill;
            lineupViewer1.Location = new Point(0, 0);
            lineupViewer1.Name = "lineupViewer1";
            lineupViewer1.Size = new Size(641, 384);
            lineupViewer1.TabIndex = 12;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(12, 265);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(freeAgentsLarge1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lineupViewer1);
            splitContainer1.Size = new Size(1523, 384);
            splitContainer1.SplitterDistance = 878;
            splitContainer1.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(1160, 56);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 17;
            label1.Text = "Last Pick:";
            // 
            // tbLastPick
            // 
            tbLastPick.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbLastPick.Font = new Font("Segoe UI", 15.75F);
            tbLastPick.Location = new Point(1264, 53);
            tbLastPick.Name = "tbLastPick";
            tbLastPick.ReadOnly = true;
            tbLastPick.Size = new Size(271, 35);
            tbLastPick.TabIndex = 16;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.Location = new Point(1148, 15);
            label3.Name = "label3";
            label3.Size = new Size(110, 30);
            label3.TabIndex = 15;
            label3.Text = "Last Team:";
            // 
            // tbLastTeam
            // 
            tbLastTeam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbLastTeam.Font = new Font("Segoe UI", 15.75F);
            tbLastTeam.Location = new Point(1264, 12);
            tbLastTeam.Name = "tbLastTeam";
            tbLastTeam.ReadOnly = true;
            tbLastTeam.Size = new Size(271, 35);
            tbLastTeam.TabIndex = 14;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F);
            label4.Location = new Point(1203, 195);
            label4.Name = "label4";
            label4.Size = new Size(55, 30);
            label4.TabIndex = 21;
            label4.Text = "Pick:";
            // 
            // tbPick
            // 
            tbPick.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbPick.Font = new Font("Segoe UI", 15.75F);
            tbPick.Location = new Point(1264, 192);
            tbPick.Name = "tbPick";
            tbPick.ReadOnly = true;
            tbPick.Size = new Size(271, 35);
            tbPick.TabIndex = 20;
            tbPick.Text = "1 / 6";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F);
            label5.Location = new Point(1180, 154);
            label5.Name = "label5";
            label5.Size = new Size(78, 30);
            label5.TabIndex = 19;
            label5.Text = "Round:";
            // 
            // tbRound
            // 
            tbRound.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbRound.Font = new Font("Segoe UI", 15.75F);
            tbRound.Location = new Point(1264, 151);
            tbRound.Name = "tbRound";
            tbRound.ReadOnly = true;
            tbRound.Size = new Size(271, 35);
            tbRound.TabIndex = 18;
            tbRound.Text = "1 / 10";
            // 
            // frmDraft
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1547, 661);
            Controls.Add(label4);
            Controls.Add(tbPick);
            Controls.Add(label5);
            Controls.Add(tbRound);
            Controls.Add(label1);
            Controls.Add(tbLastPick);
            Controls.Add(label3);
            Controls.Add(tbLastTeam);
            Controls.Add(splitContainer1);
            Controls.Add(btnLockInPick);
            Controls.Add(lblSelectedPick);
            Controls.Add(tbSelectedPick);
            Controls.Add(listDraftOrder);
            Controls.Add(label2);
            Controls.Add(tbInTheHole);
            Controls.Add(lblOnDeck);
            Controls.Add(tbOnDeck);
            Controls.Add(lblHotSeat);
            Controls.Add(tbCurrentTeam);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDraft";
            Text = "Draft";
            Load += frmDraft_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.FreeAgentsLarge freeAgentsLarge1;
        private TextBox tbCurrentTeam;
        private Label lblHotSeat;
        private TextBox tbOnDeck;
        private Label lblOnDeck;
        private Label label2;
        private TextBox tbInTheHole;
        private ListBox listDraftOrder;
        private TextBox tbSelectedPick;
        private Label lblSelectedPick;
        private Button btnLockInPick;
        private Controls.LineupViewer lineupViewer1;
        private SplitContainer splitContainer1;
        private Label label1;
        private TextBox tbLastPick;
        private Label label3;
        private TextBox tbLastTeam;
        private Label label4;
        private TextBox tbPick;
        private Label label5;
        private TextBox tbRound;
    }
}