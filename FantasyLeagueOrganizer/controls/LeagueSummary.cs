using FantasyLeagueOrganizer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FantasyLeagueOrganizer.Controls
{
    public partial class LeagueSummary : ctrlFantasyLeagueBase
    {
        League League;
        public LeagueDbContext Context;
        public LeagueSummary()
        {
            InitializeComponent();
        }

        public void Setup(LeagueDbContext context)
        {
            Context = context;
            League = DatabaseHelpers.LoadLeague(context);

            flowLayoutPanel1.Controls.Clear();

			foreach (var team in League.Teams.OrderBy(t => t.Name))
            {
                if (team.Name == "bye") continue; // skip bye teams

				var newTeamDisplaySmall = new TeamDisplaySmall(Context, team);
                newTeamDisplaySmall.Width = Width - Padding.Horizontal - newTeamDisplaySmall.Margin.Horizontal - Margin.Horizontal;
                newTeamDisplaySmall.DatabaseDataChanged = ExternalDataChanged;
                flowLayoutPanel1.Controls.Add(newTeamDisplaySmall);
			}

            RefreshUI();
        }

        protected override void LoadDataFromDatabase()
        {
            Context.Entry(League).Reload();
        }

        public override void RefreshUI()
        {
			//get list of teams from the controls currently in the flow layout panel
            var teamsWithExistingControls = flowLayoutPanel1.Controls.OfType<TeamDisplaySmall>().Select(t => t.Team).ToList();

            //Remove any controls which should no longer be there
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                if (flowLayoutPanel1.Controls[i] is TeamDisplaySmall teamDisplay)
                {
                    if (!League.Teams.Contains(teamDisplay.Team))
                    {
                        flowLayoutPanel1.Controls.RemoveAt(i);
                        i--; // adjust index after removal
                    }
                }
            }


            //add a conrol to the flow layout panel for any teams in the league that don't have a control yet
            foreach (var team in League.Teams)
            {
				if (team.Name == "bye") continue; // skip bye teams

				if (!teamsWithExistingControls.Contains(team))
                {
                    var newTeamDisplaySmall = new TeamDisplaySmall(Context, team);

                    newTeamDisplaySmall.DatabaseDataChanged = ExternalDataChanged;

                    //Find the index at which it should go
                    var currentTeamsInPanel = flowLayoutPanel1.Controls.OfType<TeamDisplaySmall>().Select(t => t.Team.Name).ToList();
                    currentTeamsInPanel.Add(team.Name);
                    currentTeamsInPanel.Sort();

                    flowLayoutPanel1.Controls.Add(newTeamDisplaySmall);
                    flowLayoutPanel1.Controls.SetChildIndex(newTeamDisplaySmall, currentTeamsInPanel.IndexOf(team.Name));
				}
            }

            //Now update all
			foreach (var teamDisplay in flowLayoutPanel1.Controls.OfType<TeamDisplaySmall>())
            {
                teamDisplay.Update();
            }
        }
    }
}
