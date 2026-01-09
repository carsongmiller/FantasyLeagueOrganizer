namespace FantasyLeagueOrganizer.controls
{
    partial class LineupCategorySelector
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
            chkListAllItems = new CheckedListBox();
            listSelected = new ListBox();
            lblCategoryName = new Label();
            tbStatus = new TextBox();
            SuspendLayout();
            // 
            // chkListAllItems
            // 
            chkListAllItems.CheckOnClick = true;
            chkListAllItems.FormattingEnabled = true;
            chkListAllItems.Location = new Point(3, 154);
            chkListAllItems.Name = "chkListAllItems";
            chkListAllItems.Size = new Size(251, 184);
            chkListAllItems.TabIndex = 0;
            chkListAllItems.ItemCheck += chkListAllItems_ItemCheck;
            // 
            // listSelected
            // 
            listSelected.FormattingEnabled = true;
            listSelected.Location = new Point(3, 39);
            listSelected.Name = "listSelected";
            listSelected.Size = new Size(251, 109);
            listSelected.TabIndex = 1;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoryName.Location = new Point(3, 13);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(93, 15);
            lblCategoryName.TabIndex = 2;
            lblCategoryName.Text = "Category Name";
            // 
            // tbStatus
            // 
            tbStatus.Location = new Point(158, 10);
            tbStatus.Name = "tbStatus";
            tbStatus.ReadOnly = true;
            tbStatus.Size = new Size(96, 23);
            tbStatus.TabIndex = 3;
            // 
            // LineupCategorySelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbStatus);
            Controls.Add(lblCategoryName);
            Controls.Add(listSelected);
            Controls.Add(chkListAllItems);
            Name = "LineupCategorySelector";
            Size = new Size(257, 341);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox chkListAllItems;
        private ListBox listSelected;
        private Label lblCategoryName;
        private TextBox tbStatus;
    }
}
