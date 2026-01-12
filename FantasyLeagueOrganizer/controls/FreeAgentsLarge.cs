using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FantasyLeagueOrganizer.controls
{
    public partial class FreeAgentsLarge : UserControl
    {
        public League League;
        public FreeAgentsLarge()
        {
            InitializeComponent();
        }

		/// <summary>
		/// Returns the currently selected free agent item, or null if no item is selected. Only one item can be selected at a time across all categories.
		/// </summary>
		public Item? SelectedItem
        {
            get
            {
                foreach (FreeAgentsSingleCategory control  in flowLayoutPanel1.Controls)
                {
                    if (control.SelectedItem != null)
                    {
                        return control.SelectedItem;
					}
                }
                return null;
            }
        }

        public void SetLeague(League league)
        {
            League = league;
            foreach (var category in League.Categories)
            {
                if (category.Name.ToLower() == "flex") continue; // Skip the flex category

				var categoryControl = new FreeAgentsSingleCategory(category);
                flowLayoutPanel1.Controls.Add(categoryControl);
                categoryControl.SelectedIndexChanged += SingleCategoryControl_SelectedIndexChanged;
			}
		}

        private void SingleCategoryControl_SelectedIndexChanged(object? sender, EventArgs e)
        {
			foreach (FreeAgentsSingleCategory control in flowLayoutPanel1.Controls)
			{
				if (control is FreeAgentsSingleCategory categoryControl && control != sender)
				{
                    control.Deselect();
				}
			}
		}

        public void Update()
        {
            foreach (var control in flowLayoutPanel1.Controls)
            {
                if (control is FreeAgentsSingleCategory categoryControl)
                {
                    categoryControl.Update();
                }
            }
        }
    }
}
