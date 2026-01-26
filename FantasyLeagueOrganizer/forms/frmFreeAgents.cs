using Microsoft.EntityFrameworkCore.Internal;
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
    public partial class frmFreeAgents : frmFantasyLeagueBase
    {
        public frmFreeAgents(LeagueDbContext context) : base(context)
        {
            InitializeComponent();

            listTeams.DisplayMember = nameof(Team.Name);

            if (League != null)
            {
                Setup();
            }
        }

        public void Setup()
        {
            freeAgentsLarge1.SetLeague(League);

            foreach (var team in League.Teams)
            {
				if (team.Name == "bye") continue; // skip bye teams
				listTeams.Items.Add(team);
            }
        }

        private void listTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            teamDisplaySmall1.Team = (Team)listTeams.SelectedItem;
            teamDisplaySmall1.Update();
		}
    }
}
