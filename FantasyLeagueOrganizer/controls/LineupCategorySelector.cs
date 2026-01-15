using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FantasyLeagueOrganizer.controls
{
    public partial class LineupCategorySelector : UserControl
    {
        public Team Team;
        public Category Category;

		public event EventHandler<ItemCheckedChangedEventArgs>? ItemCheckedChanged;


		public sealed class ItemCheckedChangedEventArgs : EventArgs
		{
			public Item Item { get; }
			public bool IsChecked { get; }
			public Guid? CategoryOld { get; }
            public Guid? CategoryNew { get; }

			public ItemCheckedChangedEventArgs(Item item, bool isChecked, Guid? categoryOld, Guid? categoryNew)
			{
				Item = item ?? throw new ArgumentNullException(nameof(item));
				IsChecked = isChecked;
				CategoryOld = categoryOld;
                CategoryNew = categoryNew;
			}
		}

		public LineupCategorySelector(Team team, Category category)
        {
            InitializeComponent();

            listSelected.DisplayMember = nameof(Item.Name);
            chkListAllItems.DisplayMember = nameof(Item.Name);

            Team = team;
            Category = category;
            lblCategoryName.Text = category.Name;

            Setup();
        }

        public void Setup()
        {
            listSelected.Items.Clear();
            chkListAllItems.Items.Clear();

			//Get the items in the team's roster which are valid for the given category, and add them to the checked list box
			foreach (var item in Team.Roster.Where(i => i.Categories.Contains(Category)))
            {
                chkListAllItems.Items.Add(item, item.IsInLineup && item.AssignedCategoryId == Category.Id);
            }

            UpdateStatus();
        }

        public void UpdateStatus()
        {
			tbStatus.Text = $"{Category.NumInLineup(Team)}/{Category.RequiredCount}";

			if (Category.SatisfiedByTeam(Team))
            {
                tbStatus.BackColor = Color.LightGreen;
            }
            else
            {
                tbStatus.BackColor = Color.IndianRed;
            }
        }

        public void UpdateLists()
        {

            for (int i = 0; i < chkListAllItems.Items.Count; i++)
            {
                var item = (Item)chkListAllItems.Items[i];
				if (item.AssignedCategoryId != Category.Id && listSelected.Items.Contains(item))
				{
					//This item is currently in the lineup for a different category, so we need to uncheck it here
					chkListAllItems.SetItemChecked(i, false);
                    listSelected.Items.Remove(item);
				}
			}

            UpdateStatus();
        }

        private void chkListAllItems_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var item = (Item)chkListAllItems.Items[e.Index];
            var oldCategory = item.AssignedCategoryId;
            if (e.NewValue == CheckState.Checked)
            {
                item.AddToLineup(Category.Id);
                listSelected.Items.Add(item);
				ItemCheckedChanged?.Invoke(this, new ItemCheckedChangedEventArgs(item, e.NewValue == CheckState.Checked, oldCategory, item.AssignedCategoryId));
			}
            else if (item.AssignedCategoryId == Category.Id)
            {
                item.RemoveFromLineup();
                listSelected.Items.Remove(item);
            }

            UpdateStatus();
        }
    }
}
