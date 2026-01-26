using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FantasyLeagueOrganizer.Controls;
using FantasyLeagueOrganizer.Models;

namespace FantasyLeagueOrganizer.Forms
{
    public partial class frmModifyLineup : frmFantasyLeagueBase
    {
        private Team Team;

		public frmModifyLineup(LeagueDbContext context, Team team)
        {
            InitializeComponent();

            Context = context;

            Team = team;
            tbTeamName.Text = team.Name;
            tbTeamName.BackColor = team.Color;

            lineupEditor1.Setup(Context, Team.Id);
            freeAgentsLarge1.SetLeague(team.League);

            lineupEditor1.DatabaseDataChanged = ExternalDataChanged;
		}

        public void frmSetLineup_Shown(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        protected override void RefreshUI()
        {

        }

		public void btnAddToTeam_Click(object sender, EventArgs e)
        {
            var selectedItem = freeAgentsLarge1.SelectedItem;
            if (selectedItem == null)
            {
                return;
            }

            selectedItem.AddToTeam(Team);

            lineupEditor1.UpdateAllCategories();
            freeAgentsLarge1.Update();

            Context.SaveChanges();
            DatabaseDataChanged.Invoke();
		}
	}
}
