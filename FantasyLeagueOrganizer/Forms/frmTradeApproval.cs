using Microsoft.VisualBasic;
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
    public partial class frmTradeApproval : frmFantasyLeagueBase
    {
        private int confirmClickCount = 0;
        private int confirmClickThreshold = 3;
        private Team TeamA;
        private Team TeamB;

        public frmTradeApproval(LeagueDbContext context, Team teamA, Team teamB, List<Item> itemsA, List<Item> itemsB) : base(context)
        {
            InitializeComponent();

            TeamA = teamA;
            TeamB = teamB;

            tbTeamA.Text = teamA.Name;
            tbTeamA.BackColor = teamA.Color;

            tbTeamB.Text = teamB.Name;
            tbTeamB.BackColor = teamB.Color;

            listTeamAItems.Items.AddRange(itemsA.ToArray());
            listTeamBItems.Items.AddRange(itemsB.ToArray());

            listTeamAItems.DisplayMember = nameof(Team.Name);
            listTeamBItems.DisplayMember = nameof(Team.Name);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            confirmClickCount++;
            if (confirmClickCount < confirmClickThreshold)
            {
                if (confirmClickCount == 1)
                {
					btnConfirm.Text = "Are you sure?";
                    btnConfirm.BackColor = Color.Yellow;
				}
				else if (confirmClickCount == 2)
				{
					btnConfirm.Text = "Are you POSITIVE??";
					btnConfirm.BackColor = Color.Orange;
				}

				return;
            }

            ExecuteTrade();
            MessageBox.Show($"Trade Executed!  The selected {League.DisplayNameItemPlural} have changed teams", "Trade Executed", MessageBoxButtons.OK);
            Close();
        }

        private void ExecuteTrade()
        {
            foreach (Item itemsFromA in listTeamAItems.Items)
            {
                itemsFromA.AddToTeam(TeamB);
            }

            foreach (Item itemsFromB in listTeamBItems.Items)
            {
                itemsFromB.AddToTeam(TeamA);
            }

            Context.SaveChanges();
            DatabaseDataChanged?.Invoke();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
