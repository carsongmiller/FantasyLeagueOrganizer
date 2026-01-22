using FantasyLeagueOrganizer.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FantasyLeagueOrganizer.controls
{
    public partial class LineupEditor : ctrlFantasyLeagueBase
    {
        private Team Team;
        public LineupEditor()
        {
            InitializeComponent();
        }

        public void Setup(LeagueDbContext context, Guid teamId)
        {
            Context = context;

            Team = context.Teams.Where(t => t.Id == teamId).Single();

            grpLineupEditor.Text = $"Lineup Editor - {Team.Name}";

            foreach (var category in Team.League.Categories)
            {
                var newLineupCategorySelector = new LineupCategoryEdidtor(Team, category);
                flowLayoutPanel1.Controls.Add(newLineupCategorySelector);
			}

            foreach (LineupCategoryEdidtor control in flowLayoutPanel1.Controls)
            {
                control.ItemCheckedChanged += Control_ItemCheckedChanged;
                control.DatabaseDataChanged = ExternalDataChanged;
			}
        }

        public override void RefreshUI()
        {

        }

        private void Control_ItemCheckedChanged(object? sender, LineupCategoryEdidtor.ItemCheckedChangedEventArgs e)
        {
            foreach (LineupCategoryEdidtor control in flowLayoutPanel1.Controls)
            {
                if (e.CategoryOld == control.Category.Id)
                {
                    control.UpdateLists();
                }
				
            }
        }

        public void UpdateAllCategories()
        {
            foreach (LineupCategoryEdidtor control in flowLayoutPanel1.Controls)
            {
                control.Setup();
			}
		}

        protected override void LoadDataFromDatabase()
        {
            Context.Entry(Team).Reload();
        }
    }
}
