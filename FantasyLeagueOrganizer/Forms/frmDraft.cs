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
    public partial class frmDraft : frmFantasyLeagueBase
    {
		/// <summary>
		/// 0 based
		/// </summary>
		private int currentPosition = 0;
        private List<Team> teamsInDraftOrder = new();

        private Team LastDrafter => teamsInDraftOrder[currentPosition - 1];
        private Team CurrentlyDrafting => teamsInDraftOrder[currentPosition];
        private Team? OnDeck
        {
            get
            {
                if (currentPosition + 1 >= teamsInDraftOrder.Count)
                    return null;
                else
                    return teamsInDraftOrder[currentPosition + 1];
            }
        }
        private Team? InTheHole
        {
            get
            {
                if (currentPosition + 2 >= teamsInDraftOrder.Count)
                    return null;
                else
                    return teamsInDraftOrder[currentPosition + 2];
            }
        }

        /// <summary>
        /// 0 based
        /// </summary>
        private int CurrentRound => currentPosition / League.Teams.Count;

        /// <summary>
        /// 0 based
        /// </summary>
        private int CurrentPickInRound => currentPosition % League.Teams.Count;

        private int ConfirmPickClickCount = 0;
        private int ConfirmPickClickRequiredCount = 2;


        public frmDraft(LeagueDbContext context) : base(context)
        {
            InitializeComponent();

            Setup();

			if (League != null)
			{
				RefreshUI();
			}
		}

		private void frmDraft_Load(object sender, EventArgs e)
		{
			ActiveControl = null;
            btnLockInPick.Focus();
		}

		private void Setup()
        {
            freeAgentsLarge1.SetLeague(League);

            for (int round = 0; round < League.DraftRoundCount; round++)
            {
                if (round % 2 == 0)
                {
                    teamsInDraftOrder.AddRange(League.Teams.OrderBy(t => t.DraftPosition).ToArray());
                }
                else
                {
                    teamsInDraftOrder.AddRange(League.Teams.OrderBy(t => t.DraftPosition).Reverse().ToArray());
                }
            }

            for (int i = 0; i < teamsInDraftOrder.Count; i++)
            {
                listDraftOrder.Items.Add($"{i+1} - {teamsInDraftOrder[i].Name}");
			}
            

            RefreshUI();
        }

        protected override void RefreshUI()
        {
            tbCurrentTeam.Text = CurrentlyDrafting.Name;
            tbCurrentTeam.BackColor = CurrentlyDrafting.Color;

            if (OnDeck != null)
            {
                tbOnDeck.Text = OnDeck.Name;
                tbOnDeck.BackColor = OnDeck.Color;
            }
            else
            {
                tbOnDeck.Text = "";
                tbOnDeck.BackColor = Color.LightGray;
            }

            if (InTheHole != null)
            {
                tbInTheHole.Text = InTheHole.Name;
                tbInTheHole.BackColor = InTheHole.Color;
            }
            else
            {
                tbInTheHole.Text = "";
                tbInTheHole.BackColor = Color.LightGray;
            }

            freeAgentsLarge1.Update();
            lineupViewer1.SetTeam(CurrentlyDrafting);

            tbRound.Text = $"{CurrentRound + 1} / {League.DraftRoundCount}";
            tbPick.Text = $"{CurrentPickInRound + 1} / {League.Teams.Count}";
        }

        private void freeAgentsLarge1_SelectedItemChanged(object sender, FantasyLeagueOrganizer.Controls.FreeAgentsLarge.SelectedItemChangedEventArgs e)
        {
            tbSelectedPick.Text = e.Item?.Name ?? "";

            LockInButtonReset();
        }

        private void LockInButtonReset()
        {
            ConfirmPickClickCount = 0;
            btnLockInPick.Text = "LOCK IT IN";
            btnLockInPick.BackColor = Color.FromArgb(128, 255, 128); //light green
        }

        private void LockInButtonConfirm()
        {
            btnLockInPick.Text = "CONFIRM";
            btnLockInPick.BackColor = Color.FromArgb(255, 255, 128); //light yellow
        }

        private void btnLockInPick_Click(object sender, EventArgs e)
        {
            if (freeAgentsLarge1.SelectedItem == null)
            {
                MessageBox.Show("Select a free agent");
                return;
            }

            ConfirmPickClickCount++;

            if (ConfirmPickClickCount < ConfirmPickClickRequiredCount)
            {
                if (ConfirmPickClickCount == 1)
                {
                    LockInButtonConfirm();
                }
                return;
            }

            //It's been confirmed, lock it in
            var team = CurrentlyDrafting;
            var item = freeAgentsLarge1.SelectedItem;

            item.AddToTeam(team);

            Context.SaveChanges();
			DatabaseDataChanged.Invoke();

			tbLastTeam.Text = team.Name;
            tbLastTeam.BackColor = team.Color;
            tbLastPick.Text = item.Name;
            tbLastPick.BackColor = team.Color;

            //Reset UI Elements
            LockInButtonReset();
            tbSelectedPick.Text = "";
            listDraftOrder.Items.RemoveAt(0);

            currentPosition++;


            //Check if the draft is over
            if (currentPosition == teamsInDraftOrder.Count)
            {
                tbCurrentTeam.Text = "Draft Complete!";
                tbCurrentTeam.BackColor = Color.LightGreen;
                tbSelectedPick.Text = "";
                tbSelectedPick.BackColor = Color.LightGray;
                btnLockInPick.Enabled = false;
            }
            else
            {
                RefreshUI();
            }
        }
    }
}
