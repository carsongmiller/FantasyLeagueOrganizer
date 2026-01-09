namespace FantasyLeagueOrganizer.controls
{
    partial class FreeAgentList
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
            grpFreeAgents = new GroupBox();
            lblCategories = new Label();
            lblItems = new Label();
            chkListCategories = new CheckedListBox();
            listFreeAgents = new ListBox();
            grpFreeAgents.SuspendLayout();
            SuspendLayout();
            // 
            // grpFreeAgents
            // 
            grpFreeAgents.Controls.Add(lblCategories);
            grpFreeAgents.Controls.Add(lblItems);
            grpFreeAgents.Controls.Add(chkListCategories);
            grpFreeAgents.Controls.Add(listFreeAgents);
            grpFreeAgents.Dock = DockStyle.Fill;
            grpFreeAgents.Location = new Point(0, 0);
            grpFreeAgents.Name = "grpFreeAgents";
            grpFreeAgents.Size = new Size(337, 244);
            grpFreeAgents.TabIndex = 0;
            grpFreeAgents.TabStop = false;
            grpFreeAgents.Text = "Free Agents";
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Location = new Point(173, 23);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(63, 15);
            lblCategories.TabIndex = 3;
            lblCategories.Text = "Categories";
            // 
            // lblItems
            // 
            lblItems.AutoSize = true;
            lblItems.Location = new Point(6, 23);
            lblItems.Name = "lblItems";
            lblItems.Size = new Size(36, 15);
            lblItems.TabIndex = 2;
            lblItems.Text = "Items";
            // 
            // chkListCategories
            // 
            chkListCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            chkListCategories.FormattingEnabled = true;
            chkListCategories.Location = new Point(176, 41);
            chkListCategories.Name = "chkListCategories";
            chkListCategories.Size = new Size(158, 184);
            chkListCategories.TabIndex = 1;
            chkListCategories.ItemCheck += chkListCategories_ItemCheck;
            // 
            // listFreeAgents
            // 
            listFreeAgents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listFreeAgents.FormattingEnabled = true;
            listFreeAgents.Location = new Point(6, 41);
            listFreeAgents.Name = "listFreeAgents";
            listFreeAgents.Size = new Size(164, 184);
            listFreeAgents.TabIndex = 0;
            listFreeAgents.SelectedIndexChanged += listFreeAgents_SelectedIndexChanged;
            listFreeAgents.Resize += listFreeAgents_Resize;
            // 
            // FreeAgentList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpFreeAgents);
            Name = "FreeAgentList";
            Size = new Size(337, 244);
            grpFreeAgents.ResumeLayout(false);
            grpFreeAgents.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpFreeAgents;
        private ListBox listFreeAgents;
        private CheckedListBox chkListCategories;
        private Label lblCategories;
        private Label lblItems;
    }
}
