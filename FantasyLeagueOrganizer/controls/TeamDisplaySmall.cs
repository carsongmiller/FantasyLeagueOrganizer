using FantasyLeagueOrganizer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FantasyLeagueOrganizer.Models;

namespace FantasyLeagueOrganizer.Controls
{
    public partial class TeamDisplaySmall : ctrlFantasyLeagueBase
    {
        public Team Team;

        public TeamDisplaySmall()
        {
            InitializeComponent();
        }

        public TeamDisplaySmall(LeagueDbContext context, Team team) : base(context)
        {
            InitializeComponent();

            Context = context;

            Team = team;
            RefreshUI();
        }

        public override void RefreshUI()
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

        protected override void LoadDataFromDatabase()
        {
            Context.Entry(Team).Reload();
        }

        private void btnEditLineup_Click(object sender, EventArgs e)
        {
            var editLineupForm = new frmModifyLineup(Context, Team);
            editLineupForm.DatabaseDataChanged = ExternalDataChanged;
            editLineupForm.ShowDialog();
        }
    }
}