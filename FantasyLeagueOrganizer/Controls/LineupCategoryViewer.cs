using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FantasyLeagueOrganizer.controls
{
    public partial class LineupCategoryViewer : UserControl
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

		public LineupCategoryViewer(Team team, Category category)
        {
            InitializeComponent();

            listAllItems.DisplayMember = nameof(Item.Name);

            Team = team;
            Category = category;
            lblCategoryName.Text = category.Name;

			Update();
        }

        public void Update()
        {
            listAllItems.Items.Clear();
            listAllItems.Items.AddRange(Team.Roster.Where(i => i.Categories.Contains(Category)).OrderBy(i => i.Name).ToArray());
            if (listAllItems.Items.Count >= Category.RequiredCount)
            {
                tbStatus.Text = "Has Enough";
                tbStatus.BackColor = Color.LightGreen;
            }
            else
            {
                tbStatus.Text = "Not Enough";
                tbStatus.BackColor = Color.IndianRed;
            }
		}
    }
}
