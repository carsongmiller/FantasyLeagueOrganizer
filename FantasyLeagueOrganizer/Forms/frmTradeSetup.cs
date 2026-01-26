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
    public partial class frmTradeSetup : frmFantasyLeagueBase
    {
        public frmTradeSetup(LeagueDbContext context) : base(context)
        {
            InitializeComponent();

            Setup();
            RefreshUI();
        }

        private void Setup()
        {
            listTeamA.Items.AddRange(League.Teams.OrderBy(t => t.Name).ToArray());
            listTeamB.Items.AddRange(League.Teams.OrderBy(t => t.Name).ToArray());

            chkListTeamA.DisplayMember = nameof(Item.Name);
			chkListTeamB.DisplayMember = nameof(Item.Name);
		}

        protected override void RefreshUI()
        {

        }

        private void listTeamA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTeamA.SelectedIndex < 0) return;

            //populate the checked list box with this team's items
            var selectedTeam = (Team)listTeamA.SelectedItem;
            chkListTeamA.Items.Clear();
            chkListTeamA.Items.AddRange(selectedTeam.Roster.ToArray());

            tbPasswordA.Text = "";
        }

        private void listTeamB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTeamB.SelectedIndex < 0) return;

            //populate the checked list box with this team's items
            var selectedTeam = (Team)listTeamB.SelectedItem;
            chkListTeamB.Items.Clear();
            chkListTeamB.Items.AddRange(selectedTeam.Roster.ToArray());

            tbPasswordB.Text = "";
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            var teamA = (Team)listTeamA.SelectedItem;
            var teamB = (Team)listTeamB.SelectedItem;

			if (teamA == null || teamB == null)
			{
				MessageBox.Show($"You must select two {League.DisplayNameTeamPlural}");
				return;
			}

			if (teamA.Id == teamB.Id)
            {
				MessageBox.Show($"A {League.DisplayNameTeamSingular} cannot trade with itself");
                return;
			}

            if (tbPasswordA.Text != teamA.Password)
            {
                MessageBox.Show($"{teamA.Name} password is incorrect");
                return;
            }

            if (tbPasswordB.Text != teamB.Password)
            {
                MessageBox.Show($"{teamB.Name} password is incorrect");
                return;
            }

            var checkedItemsA = new List<Item>();
            foreach (Item checkedItem in chkListTeamA.CheckedItems)
            {
                checkedItemsA.Add(checkedItem);
            }

            var checkedItemsB = new List<Item>();
            foreach (Item checkedItem in chkListTeamB.CheckedItems)
            {
                checkedItemsB.Add(checkedItem);
            }

            if (checkedItemsA.Count == 0 && checkedItemsB.Count == 0)
            {
				MessageBox.Show($"At least one {League.DisplayNameItemSingular} must be selected to trade");
				return;
			}

            var tradeConfirmForm = new frmTradeApproval(Context, teamA, teamB, checkedItemsA, checkedItemsB);
            tradeConfirmForm.DatabaseDataChanged = ExternalDataChanged;
            tradeConfirmForm.ShowDialog();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
