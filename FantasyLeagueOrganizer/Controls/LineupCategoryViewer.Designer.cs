namespace FantasyLeagueOrganizer.Controls
{
    partial class LineupCategoryViewer
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
            listAllItems = new ListBox();
            lblCategoryName = new Label();
            tbStatus = new TextBox();
            SuspendLayout();
            // 
            // listAllItems
            // 
            listAllItems.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listAllItems.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listAllItems.FormattingEnabled = true;
            listAllItems.Location = new Point(3, 38);
            listAllItems.Name = "listAllItems";
            listAllItems.Size = new Size(251, 151);
            listAllItems.TabIndex = 1;
            // 
            // lblCategoryName
            // 
            lblCategoryName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoryName.Location = new Point(3, 6);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(145, 26);
            lblCategoryName.TabIndex = 2;
            lblCategoryName.Text = "Category Name";
            // 
            // tbStatus
            // 
            tbStatus.BackColor = Color.IndianRed;
            tbStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbStatus.Location = new Point(154, 3);
            tbStatus.Name = "tbStatus";
            tbStatus.Size = new Size(100, 29);
            tbStatus.TabIndex = 3;
            tbStatus.Text = "0 / 1";
            tbStatus.TextAlign = HorizontalAlignment.Center;
            // 
            // LineupCategoryViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbStatus);
            Controls.Add(lblCategoryName);
            Controls.Add(listAllItems);
            Name = "LineupCategoryViewer";
            Size = new Size(257, 193);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listAllItems;
        private Label lblCategoryName;
        private TextBox tbStatus;
    }
}
