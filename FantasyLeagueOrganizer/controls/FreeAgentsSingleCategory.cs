using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static FantasyLeagueOrganizer.controls.LineupCategorySelector;

namespace FantasyLeagueOrganizer.controls
{
    public partial class FreeAgentsSingleCategory : UserControl
    {
        public Category Category;
        public event EventHandler<EventArgs>? SelectedIndexChanged;
        public Item? SelectedItem => listFreeAgents.SelectedItem as Item;

		public FreeAgentsSingleCategory(Category category)
        {
            InitializeComponent();
            Category = category;
            lblCategoryName.Text = category.Name;
            listFreeAgents.DisplayMember = nameof(Item.Name);

            Update();
        }

        public void Update()
        {
            listFreeAgents.Items.Clear();

            foreach (var item in Category.Items.Where(i => i.IsFreeAgent))
            {
                listFreeAgents.Items.Add(item);
            }
        }

        public void Deselect()
        {
            listFreeAgents.ClearSelected();
		}

		private void listFreeAgents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listFreeAgents.SelectedIndex >= 0)
            {
                SelectedIndexChanged?.Invoke(this, EventArgs.Empty);
            }
		}
    }
}
