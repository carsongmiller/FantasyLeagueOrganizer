using FantasyLeagueOrganizer.DatabseClasses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FantasyLeagueOrganizer.Forms
{
    public partial class frmDraftSetup : Form
    {
        private League League;
        public frmDraftSetup(League league)
        {
            InitializeComponent();
            listDraftOrder.DisplayMember = nameof(Team.Name);

            League = league;
            foreach (var team in league.Teams.OrderBy(t => t.DraftPosition))
            {
                listDraftOrder.Items.Add(team);
            }
        }

        private void bnMoveUp_Click(object sender, EventArgs e)
        {
            if (listDraftOrder.SelectedIndex < 1) return;

            var selectedItem = listDraftOrder.SelectedItem;
            var currentIndex = listDraftOrder.SelectedIndex;

            listDraftOrder.Items.Remove(selectedItem);
            listDraftOrder.Items.Insert(currentIndex - 1, selectedItem);
            listDraftOrder.SelectedIndex = currentIndex - 1; //keep the moved item selected
		}

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (listDraftOrder.SelectedIndex < 0 || listDraftOrder.SelectedIndex >= listDraftOrder.Items.Count) return;

            var selectedItem = listDraftOrder.SelectedItem;
            var currentIndex = listDraftOrder.SelectedIndex;

            listDraftOrder.Items.Remove(selectedItem);
            listDraftOrder.Items.Insert(currentIndex + 1, selectedItem);
			listDraftOrder.SelectedIndex = currentIndex + 1; //keep the moved item selected
		}

        private void btnProceed_Click(object sender, EventArgs e)
        {
			//Set each team's draft position based on their index in the listbox
            for (int i = 0; i < listDraftOrder.Items.Count; i++)
            {
                var team = (Team)listDraftOrder.Items[i];
                team.DraftPosition = i;
                DatabaseHelpers.Update(team);
			}

            League.DraftRoundCount = (int)nudNumRounds.Value;
            if (radSnake.Checked)
            {
                League.DraftStyle = League.DraftOrderStyle.Snake;
            }
            else
            {
                League.DraftStyle = League.DraftOrderStyle.Linear;
            }

            DatabaseHelpers.Update(League);

			//Open the draft form
			var draftForm = new frmDraft(League);
            draftForm.ShowDialog();
            Close(); //Close once the draft form is closed
		}

		private void btnCancel_Click(object sender, EventArgs e)
        {
			//Just close, no need to save any changes since we haven't updated the draft positions yet
			Close();
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            listDraftOrder.Items.Clear();
            listDraftOrder.Items.AddRange(League.Teams.OrderBy(t => Guid.NewGuid()).ToArray()); //add the teams back in a random order
        }

        private void btnAlphabetical_Click(object sender, EventArgs e)
        {
			listDraftOrder.Items.Clear();
			listDraftOrder.Items.AddRange(League.Teams.OrderBy(t => t.Name).ToArray());
		}
    }
}
