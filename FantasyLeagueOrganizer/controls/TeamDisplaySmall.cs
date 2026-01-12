using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FantasyLeagueOrganizer
{
	public partial class TeamDisplaySmall : UserControl
	{
		public Team Team;

		public TeamDisplaySmall()
		{
			InitializeComponent();
		}

		public TeamDisplaySmall(Team team) : this()
		{
			Team = team;
		}

		public void Update()
		{
			BackColor = Team.Color;

			lblName.Text = Team.Name;
			lblRecord.Text = Team.RecordString;

			if (Team.ValidateLineup())
			{
				tbLineupStatus.Text = " Lineup OK";
				tbLineupStatus.BackColor = Color.LightGreen;
			}
			else
			{
				tbLineupStatus.Text = " Lineup Not OK";
				tbLineupStatus.BackColor = Color.IndianRed;
			}
		}
	}
}
