using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics.Internal;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;

namespace FantasyLeagueOrganizer
{
    public partial class frmMain : Form
    {
        League league;
        LeagueDbContext context;

        public frmMain()
        {
            InitializeComponent();

            SetupInterface();
            LoadEntireLeague();
            RefreshInterface();
        }

        private void SaveChanges()
        {
            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                var root = ex.GetBaseException()?.Message ?? ex.Message;
                MessageBox.Show($"Save failed: {root}", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void SetupInterface()
        {
            listCategories.DisplayMember = nameof(Category.Name);
            listItems.DisplayMember = nameof(Item.Name);
            chkListCategories.DisplayMember = nameof(Category.Name);
            listTeams.DisplayMember = nameof(Team.Name);
            listRoster.DisplayMember = nameof(Item.Name);
        }

        private void RefreshInterface()
        {
            RefreshCategoryControls();
            RefreshItemControls();
            RefreshTeamControls();
            leagueSummary1.Update();
        }

        private void RefreshCategoryControls()
        {
            grpCategories.Text = league.DisplayNameCategoryPlural;
            btnAddOrUpdateCategory.Text = $"Add/Update {league.DisplayNameCategorySingular}";

			listCategories.Items.Clear();
            chkListCategories.Items.Clear();

            foreach (var item in league.Categories)
            {
                listCategories.Items.Add(item);
                chkListCategories.Items.Add(item);
            }
        }

        private void RefreshItemControls()
        {
			grpItems.Text = league.DisplayNameItemPlural;
            btnAddOrUpdateItem.Text = $"Add/Update {league.DisplayNameItemSingular}";

			listItems.Items.Clear();
            foreach (var item in league.Items)
            {
                listItems.Items.Add(item);
            }
        }

        private void RefreshTeamControls()
        {
            grpTeams.Text = league.DisplayNameTeamPlural;
            btnAddOrUpdateTeam.Text = $"Add/Update {league.DisplayNameTeamSingular}";

			listTeams.Items.Clear();
            foreach (var team in league.Teams)
            {
                listTeams.Items.Add(team);
            }
        }

        private void LoadEntireLeague()
        {
            context = new LeagueDbContext();

            league = context.Leagues
                .Include(l => l.Teams)
                .Include(l => l.Items)
                .Include(l => l.Categories)
                    .ThenInclude(i => i.Items)
                .Single();

            leagueSummary1.SetLeague(league);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (context == null)
            {
                context = new LeagueDbContext();
            }

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            league = new League("The Iron Skillet");

			league.DisplayNameTeamSingular = "Chef";
			league.DisplayNameTeamPlural = "Chefs";

			league.DisplayNameItemSingular = "Dish";
			league.DisplayNameItemPlural = "Dishes";

			league.DisplayNameCategorySingular = "Cuisine";
			league.DisplayNameCategoryPlural = "Cuisines";

			var categoryFastFood = new Category("Fast Food", 1, league);
            var categoryDrink = new Category("Drink", 1, league);
            var categoryFlex = new Category("Flex", 1, league);

            league.AddCategory(categoryFastFood);
            league.AddCategory(categoryDrink);
            league.AddCategory(categoryFlex);

            var burger = new Item("Burger", categoryFastFood, league);
            burger.AddCategory(categoryFlex);
            var fries = new Item("Fries", categoryFastFood, league);
            fries.AddCategory(categoryFlex);
            var pop = new Item("Pop", categoryDrink, league);
            pop.AddCategory(categoryFlex);

            var teamCarson = new Team("Carson's Confections", league);
            var teamKnute = new Team("Knute's Killers", league);

            burger.AddToTeam(teamCarson);
            fries.AddToTeam(teamCarson);
            pop.AddToTeam(teamKnute);

            burger.AddToLineup(categoryFlex);

            context.Leagues.Add(league);

            context.SaveChanges();
            MessageBox.Show("Changes Saved");
        }

        private void btnLoadLeague_Click(object sender, EventArgs e)
        {
            LoadEntireLeague();
            RefreshInterface();
        }

        private void btnAddCategoryToLeague_Click(object sender, EventArgs e)
        {
            var newCategory = new Category(tbNewCategory.Text, (int)nudRequiredCount.Value, league);

            context.Categories.Add(newCategory);
            SaveChanges();

            RefreshInterface();
        }

        private void btnAddItemToLeague_Click(object sender, EventArgs e)
        {
            var categories = new HashSet<Category>(); //list of categories to which the item belongs
            foreach (Category category in chkListCategories.CheckedItems)
            {
                categories.Add(category);
            }

            if (!league.ContainsItemWithName(tbNewItem.Text))
            {
                //Create new Item
                var newItem = new Item(tbNewItem.Text, categories, league);
                context.Items.Add(newItem);
            }
            else
            {
                //Modify Existing Item
                var item = league.GetItem(tbNewItem.Text);
                item.SetCategories(categories);
            }

            SaveChanges();
            RefreshInterface();
        }

        private void btnRefreshInterface_Click(object sender, EventArgs e)
        {
            RefreshInterface();
        }

        private void btnAddTeamToLeague_Click(object sender, EventArgs e)
        {
            if (!league.ContainsTeam(tbTeamNameCurrent.Text))
            {
                //new team being created
                var newTeam = new Team(tbTeamNameNew.Text, league);
                newTeam.ColorCode = tbNewTeamColor.Text;
                context.Teams.Add(newTeam);
            }
            else
            {
                //existing team being modified
                var team = league.GetTeam(tbTeamNameCurrent.Text);
                team.Name = tbTeamNameNew.Text;
                team.ColorCode = tbNewTeamColor.Text;
            }
            SaveChanges();
            RefreshInterface();
        }

        private void btnSelectTeamColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                tbNewTeamColor.BackColor = colorDialog1.Color;
                tbNewTeamColor.Text = $"#{colorDialog1.Color.R:X2}{colorDialog1.Color.G:X2}{colorDialog1.Color.B:X2}";
            }
        }

        private void listTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            listRoster.Items.Clear();

            if (listTeams.SelectedIndex < 0)
            {
                return;
            }

            var selectedTeam = (Team)listTeams.SelectedItem;
            tbTeamNameCurrent.Text = selectedTeam.Name;
            tbTeamNameNew.Text = selectedTeam.Name;
            tbNewTeamColor.Text = selectedTeam.ColorCode;
            var color = selectedTeam.Color;
            tbNewTeamColor.BackColor = color;
            colorDialog1.Color = color;

            foreach (Item rosterMember in selectedTeam.Roster)
            {
                listRoster.Items.Add(rosterMember);
            }
        }

        private void btnSaveLeague_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void listItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (Item)listItems.SelectedItem;
            tbNewItem.Text = selectedItem.Name;
            for (int i = 0; i < chkListCategories.Items.Count; i++)
            {
                var category = (Category)chkListCategories.Items[i];
                chkListCategories.SetItemChecked(i, selectedItem.BelongsToCategory(category));
            }
        }

        private void listCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategory = (Category)listCategories.SelectedItem;
            tbNewCategory.Text = selectedCategory.Name;
            nudRequiredCount.Value = selectedCategory.RequiredCount;
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            var selectedItem = (Item)listItems.SelectedItem;
            if (selectedItem == null)
            {
                return;
            }

            var message = $"Are you sure you wish to delete the {league.DisplayNameItemSingular} {selectedItem.Name}?  It will be deleted from any {league.DisplayNameTeamSingular} that it belongs to.";
            if (MessageBox.Show(message, "Delete Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            league.RemoveItem(selectedItem);
            RefreshInterface();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            var selectedCategory = (Category)listCategories.SelectedItem;
            if (selectedCategory == null)
            {
                return;
            }

            var orphanItems = selectedCategory.Items.Where(i => i.ValidCategories.Where(c => c.Name.ToLower() != "flex").Count() == 1).ToList();

            var orphanItemsString = orphanItems.Count > 0
                ? $"The following {league.DisplayNameItemPlural} will belong to zero {league.DisplayNameCategoryPlural} (except potentially flex):\n{string.Join("\n", orphanItems.Select(i => i.Name))}"
                : string.Empty;

            var message = $"Are you sure you wish to delete the {league.DisplayNameCategorySingular} {selectedCategory.Name}?\n\n{orphanItemsString}";
            if (MessageBox.Show(message, "Delete Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            league.RemoveCategory(selectedCategory);
            RefreshInterface();
        }

        private void btnSetLineup_Click(object sender, EventArgs e)
        {
            if (listTeams.SelectedIndex < 0)
            {
                MessageBox.Show($"Please select a {league.DisplayNameTeamSingular} first.");
                return;
            }

            frmSetLineup setLineupForm = new frmSetLineup((Team)listTeams.SelectedItem);
            setLineupForm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
