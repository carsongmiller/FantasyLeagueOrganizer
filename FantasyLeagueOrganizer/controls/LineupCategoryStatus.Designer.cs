namespace FantasyLeagueOrganizer.Controls
{
    partial class LineupCategoryStatus
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
            tbStatus = new TextBox();
            SuspendLayout();
            // 
            // tbStatus
            // 
            tbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbStatus.Location = new Point(3, 3);
            tbStatus.Name = "tbStatus";
            tbStatus.Size = new Size(180, 23);
            tbStatus.TabIndex = 0;
            // 
            // LineupCategoryStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbStatus);
            Name = "LineupCategoryStatus";
            Size = new Size(186, 29);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbStatus;
    }
}
