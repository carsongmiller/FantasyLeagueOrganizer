using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FantasyLeagueOrganizer.controls
{
    public partial class FreeAgentList : UserControl
    {
        private League League;
        public FreeAgentList()
        {
            InitializeComponent();

            listFreeAgents.DisplayMember = nameof(Item.Name);
            chkListCategories.DisplayMember = nameof(Category.Name);
        }

        public Item? SelectedItem => (Item?)listFreeAgents.SelectedItem;

		public void SetLeague(League league)
        {
            League = league;
            Refresh();
        }

        public void Refresh()
        {
            foreach (var item in League.Items)
            {
                if (item.TeamId == null)
                {
                    listFreeAgents.Items.Add(item);
                }
            }

            foreach (var category in League.Categories)
            {
                chkListCategories.Items.Add(category);
            }
        }

        private void listFreeAgents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listFreeAgents.SelectedItem == null)
            {
                return;
            }

            var selectedItem = (Item)listFreeAgents.SelectedItem;

            for (int i = 0; i < chkListCategories.Items.Count; i++)
            {
                chkListCategories.SetItemChecked(i, selectedItem.BelongsToCategory((Category)chkListCategories.Items[i]));
            }
        }

        private void listFreeAgents_Resize(object sender, EventArgs e)
        {
            listFreeAgents.Left = 0 + Margin.Left;
            chkListCategories.Left = Width / 2 + Margin.Left / 2;
            var width = Math.Max(0, (Width - Margin.Left - Margin.Right - Margin.Right) / 2);
            listFreeAgents.Width = width;
            chkListCategories.Width = width;
            chkListCategories.Height = listFreeAgents.Height;
            lblCategories.Left = chkListCategories.Left;
		}

        private void chkListCategories_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (chkListCategories.Focused)
            {
                e.NewValue = e.CurrentValue;
                return;
            }
        }
    }
}
