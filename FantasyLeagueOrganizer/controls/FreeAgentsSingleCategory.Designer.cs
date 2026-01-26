namespace FantasyLeagueOrganizer.Controls
{
    partial class FreeAgentsSingleCategory
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
            lblCategoryName = new Label();
            listFreeAgents = new ListBox();
            SuspendLayout();
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoryName.Location = new Point(3, 11);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(93, 15);
            lblCategoryName.TabIndex = 3;
            lblCategoryName.Text = "Category Name";
            // 
            // listFreeAgents
            // 
            listFreeAgents.FormattingEnabled = true;
            listFreeAgents.Location = new Point(3, 38);
            listFreeAgents.Name = "listFreeAgents";
            listFreeAgents.Size = new Size(270, 244);
            listFreeAgents.TabIndex = 4;
            listFreeAgents.SelectedIndexChanged += listFreeAgents_SelectedIndexChanged;
            // 
            // FreeAgentsSingleCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listFreeAgents);
            Controls.Add(lblCategoryName);
            Name = "FreeAgentsSingleCategory";
            Size = new Size(276, 291);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoryName;
        private ListBox listFreeAgents;
    }
}
