namespace FantasyLeagueOrganizer.Controls
{
    partial class MatchupItemPair
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
            tbItemA = new TextBox();
            tbItemB = new TextBox();
            lblCategory = new Label();
            tbScoreA = new TextBox();
            tbScoreB = new TextBox();
            SuspendLayout();
            // 
            // tbItemA
            // 
            tbItemA.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            tbItemA.Location = new Point(3, 3);
            tbItemA.Name = "tbItemA";
            tbItemA.ReadOnly = true;
            tbItemA.Size = new Size(354, 43);
            tbItemA.TabIndex = 0;
            tbItemA.Text = "Item A";
            // 
            // tbItemB
            // 
            tbItemB.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            tbItemB.Location = new Point(749, 3);
            tbItemB.Name = "tbItemB";
            tbItemB.ReadOnly = true;
            tbItemB.Size = new Size(354, 43);
            tbItemB.TabIndex = 1;
            tbItemB.Text = "Item B";
            tbItemB.TextAlign = HorizontalAlignment.Right;
            // 
            // lblCategory
            // 
            lblCategory.Font = new Font("Segoe UI", 20.25F);
            lblCategory.Location = new Point(403, 3);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(300, 43);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category";
            lblCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbScoreA
            // 
            tbScoreA.Font = new Font("Segoe UI", 20.25F);
            tbScoreA.Location = new Point(363, 3);
            tbScoreA.Name = "tbScoreA";
            tbScoreA.ReadOnly = true;
            tbScoreA.Size = new Size(34, 43);
            tbScoreA.TabIndex = 3;
            // 
            // tbScoreB
            // 
            tbScoreB.Font = new Font("Segoe UI", 20.25F);
            tbScoreB.Location = new Point(709, 3);
            tbScoreB.Name = "tbScoreB";
            tbScoreB.ReadOnly = true;
            tbScoreB.Size = new Size(34, 43);
            tbScoreB.TabIndex = 4;
            tbScoreB.TextAlign = HorizontalAlignment.Right;
            // 
            // MatchupItemPair
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbScoreB);
            Controls.Add(tbScoreA);
            Controls.Add(lblCategory);
            Controls.Add(tbItemB);
            Controls.Add(tbItemA);
            Name = "MatchupItemPair";
            Size = new Size(1106, 49);
            Resize += MatchupItemPair_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbItemA;
        private TextBox tbItemB;
        private Label lblCategory;
        private TextBox tbScoreA;
        private TextBox tbScoreB;
    }
}
