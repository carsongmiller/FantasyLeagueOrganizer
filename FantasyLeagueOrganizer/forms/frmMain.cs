using FantasyLeagueOrganizer.forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics.Internal;
using Microsoft.Extensions.Options;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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

        private void btnRecreateLeague_Click(object sender, EventArgs e)
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

            var categoryMain = new Category("Main", 2, league);
            var categorySide = new Category("Side", 2, league);
            var categoryDessert = new Category("Dessert", 1, league);
            var categoryBreakfast = new Category("Breakfast", 1, league);
            var categoryDrink = new Category("Drink", 1, league);
            var categoryFastFood = new Category("Fast Food", 1, league);
            var categoryFlex = new Category("Flex", 1, league);


            league.AddCategory(categoryFastFood);
            league.AddCategory(categoryDrink);
            league.AddCategory(categoryFlex);


            var Pizza = new Item("Pizza", categoryMain, league);
            var Cheeseburger = new Item("Cheeseburger", categoryMain, league);
            var Fried_Chicken = new Item("Fried Chicken", categoryMain, league);
            var Steak = new Item("Steak", categoryMain, league);
            var Meatloaf = new Item("Meatloaf", categoryMain, league);
            var Lasagna = new Item("Lasagna", categoryMain, league);
            var Mac_and_Cheese = new Item("Mac and Cheese", categoryMain, league);
            var Tacos = new Item("Tacos", categoryMain, league);
            var Burrito = new Item("Burrito", categoryMain, league);
            var Hot_Dog = new Item("Hot Dog", categoryMain, league);
            var BBQ_Ribs = new Item("BBQ Ribs", categoryMain, league);
            var Pulled_Pork = new Item("Pulled_ Pork", categoryMain, league);
            var Chicken_Alfredo = new Item("Chicken Alfredo", categoryMain, league);
            var Stir_Fry = new Item("Stir Fry", categoryMain, league);
            var Curry = new Item("Curry", categoryMain, league);
            var Chili = new Item("Chili", categoryMain, league);
            var Sub_Sandwich = new Item("Sub Sandwich", categoryMain, league);
            var Beef_Brisket = new Item("Beef Brisket", categoryMain, league);
            var Tater_Tot_Hot_Dish = new Item("Tater Tot Hot Dish", categoryMain, league);
            var Chicken_Tenders = new Item("Chicken Tenders", categoryMain, league);

            var Pancakes = new Item("Pancakes", categoryBreakfast, league);
            var Waffles = new Item("Waffles", categoryBreakfast, league);
            var French_Toast = new Item("French Toast", categoryBreakfast, league);
            var Eggs = new Item("Eggs", categoryBreakfast, league);
            var Bacon = new Item("Bacon", categoryBreakfast, league);
            var Hash_Browns = new Item("Hash Browns", categoryBreakfast, league);
            var Biscuits_and_Gravy = new Item("Biscuits and Gravy", categoryBreakfast, league);
            var Bagel_with_Cream_Cheese = new Item("Bagel with Cream Cheese", categoryBreakfast, league);
            var English_Muffin = new Item("English Muffin", categoryBreakfast, league);
            var Milk_and_Cereal = new Item("Milk and Cereal", categoryBreakfast, league);
            var Oatmeal = new Item("Oatmeal", categoryBreakfast, league);
            var Yogurt = new Item("Yogurt", categoryBreakfast, league);
            var Avocado_Toast = new Item("Avocado Toast", categoryBreakfast, league);
            var Muffin = new Item("Muffin", categoryBreakfast, league);
            var Cinnamon_Roll = new Item("Cinnamon Roll", categoryBreakfast, league);
            var Donut = new Item("Donut", categoryBreakfast, league);
            var Breakfast_Pizza = new Item("Breakfast Pizza", categoryBreakfast, league);
            var Croissant = new Item("Croissant", categoryBreakfast, league);
            var Caramel_Roll = new Item("Caramel Roll", categoryBreakfast, league);
            var Crepes = new Item("Crepes", categoryBreakfast, league);

            var Ice_Cream = new Item("Ice Cream", categoryDessert, league);
            var Angel_Food_Cake = new Item("Angel Food Cake", categoryDessert, league);
            var Chocolate_Chip_Cookies = new Item("Chocolate Chip Cookies", categoryDessert, league);
            var Brownies = new Item("Brownies", categoryDessert, league);
            var Apple_Pie = new Item("Apple Pie", categoryDessert, league);
            var Cheesecake = new Item("Cheesecake", categoryDessert, league);
            var Cupcakes = new Item("Cupcakes", categoryDessert, league);
            var Gelato = new Item("Gelato", categoryDessert, league);
            var Frozen_Yogurt = new Item("Frozen Yogurt", categoryDessert, league);
            var Sundae = new Item("Sundae", categoryDessert, league);
            var Milkshake = new Item("Milkshake", categoryDessert, league);
            var Chocolate_Bar = new Item("Chocolate Bar", categoryDessert, league);
            var Rice_Pudding = new Item("Rice Pudding", categoryDessert, league);
            var Tiramisu = new Item("Tiramisu", categoryDessert, league);
            var Chocolate_Lava_Cake = new Item("Chocolate Lava Cake", categoryDessert, league);
            var Popsicle = new Item("Popsicle", categoryDessert, league);
            var Pumpkin_Pie = new Item("Pumpkin Pie", categoryDessert, league);
            var Sorbet = new Item("Sorbet", categoryDessert, league);
            var Flan = new Item("Flan", categoryDessert, league);
            var Churro = new Item("Churro", categoryDessert, league);

            var French_Fries = new Item("French Fries", categorySide, league);
            var Mashed_Potatoes = new Item("Mashed Potatoes", categorySide, league);
            var Baked_Potato = new Item("Baked Potato", categorySide, league);
            var Tater_Tots = new Item("Tater Tots", categorySide, league);
            var Onion_Rings = new Item("Onion Rings", categorySide, league);
            var Coleslaw = new Item("Coleslaw", categorySide, league);
            var Fried_Rice = new Item("Fried Rice", categorySide, league);
            var Roasted_Vegetables = new Item("Roasted Vegetables", categorySide, league);
            var Caesar_Salad = new Item("Caesar Salad", categorySide, league);
            var Corn_on_the_Cob = new Item("Corn on the Cob", categorySide, league);
            var Dinner_Rolls = new Item("Dinner Rolls", categorySide, league);
            var Garlic_Bread = new Item("Garlic Bread", categorySide, league);
            var Breadsticks = new Item("Breadsticks", categorySide, league);
            var Stuffing = new Item("Stuffing", categorySide, league);
            var Baked_Beans = new Item("Baked Beans", categorySide, league);
            var Potato_Salad = new Item("Potato Salad", categorySide, league);
            var Fruit_Salad = new Item("Fruit Salad", categorySide, league);
            var Applesauce = new Item("Applesauce", categorySide, league);
            var Chips = new Item("Chips", categorySide, league);
            var Pretzels = new Item("Pretzels", categorySide, league);

            var Still_Water = new Item("Still Water", categoryDrink, league);
            var Sparkling_Water = new Item("Sparkling Water", categoryDrink, league);
            var Coke = new Item("Coke", categoryDrink, league);
            var Root_Beer = new Item("Root Beer", categoryDrink, league);
            var Sweet_Tea = new Item("Sweet Tea", categoryDrink, league);
            var Black_Tea = new Item("Black Tea", categoryDrink, league);
            var Black_Coffee = new Item("Black Coffee", categoryDrink, league);
            var Hot_Chocolate = new Item("Hot Chocolate", categoryDrink, league);
            var White_Milk = new Item("White Milk", categoryDrink, league);
            var Chocolate_Milk = new Item("Chocolate Milk", categoryDrink, league);
            var Orange_Juice = new Item("Orange Juice", categoryDrink, league);
            var Lemonade = new Item("Lemonade", categoryDrink, league);
            var Smoothie = new Item("Smoothie", categoryDrink, league);
            var Protein_Shake = new Item("Protein Shake", categoryDrink, league);
            var Beer = new Item("Beer", categoryDrink, league);
            var Red_Wine = new Item("Red Wine", categoryDrink, league);
            var Whiskey = new Item("Whiskey", categoryDrink, league);
            var Apple_Cider = new Item("Apple Cider", categoryDrink, league);
            var White_Monster = new Item("White Monster", categoryDrink, league);
            var Celsius = new Item("Celsius", categoryDrink, league);

            var McDonalds = new Item("McDonald's", categoryFastFood, league);
            var Burger_King = new Item("Burger King", categoryFastFood, league);
            var Wendys = new Item("Wendy's", categoryFastFood, league);
            var Taco_Bell = new Item("Taco Bell", categoryFastFood, league);
            var KFC = new Item("KFC", categoryFastFood, league);
            var Popeyes = new Item("Popeyes", categoryFastFood, league);
            var Chick_fil_A = new Item("Chick-fil-A", categoryFastFood, league);
            var Subway = new Item("Subway", categoryFastFood, league);
            var Little_Caesars = new Item("Little Caesar's", categoryFastFood, league);
            var Sonic = new Item("Sonic", categoryFastFood, league);
            var Arbys = new Item("Arby's", categoryFastFood, league);
            var Jack_in_the_Box = new Item("Jack in the Box", categoryFastFood, league);
            var Dairy_Queen = new Item("Dairy Queen", categoryFastFood, league);
            var Jersey_Mikes = new Item("Jersey Mike's", categoryFastFood, league);
            var Chipotle = new Item("Chipotle", categoryFastFood, league);
            var Raising_Canes = new Item("Raising Cane's", categoryFastFood, league);
            var In_N_Out_Burger = new Item("In-N-Out Burger", categoryFastFood, league);
            var Shake_Shack = new Item("Shake Shack", categoryFastFood, league);
            var Culvers = new Item("Culver's", categoryFastFood, league);
            var Five_Guys = new Item("Five Guys", categoryFastFood, league);

            foreach (var item in league.Items)
            {
                item.AddCategory(categoryFlex);
            }

            var teamCarson = new Team("Carson's Confections", league);
            var teamKnute = new Team("Knute's Killers", league);
            var teamAnna = new Team("Anna's Appes", league);
            var teamJosiah = new Team("Josiah's Jellybeans", league);

            teamCarson.ColorCode = ColorTranslator.ToHtml(Color.LawnGreen);
            teamKnute.ColorCode = ColorTranslator.ToHtml(Color.LightGoldenrodYellow);
            teamAnna.ColorCode = ColorTranslator.ToHtml(Color.LightCoral);
            teamJosiah.ColorCode = ColorTranslator.ToHtml(Color.Fuchsia);

            context.Leagues.Add(league);

            context.SaveChanges();
            MessageBox.Show("Changes Saved");
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

            leagueSummary1.Update();
            leagueSummary2.Update();
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
            leagueSummary2.SetLeague(league);
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

        private void btnGenerateSchedule_Click(object sender, EventArgs e)
        {
            var teams = league.Teams.ToList(); //Turn the teams into a list so we can iterate through them by index

            //Randomize the list of teams
            Random rng = new Random();
            for (int i = teams.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                (teams[i], teams[j]) = (teams[j], teams[i]);
            }

            if (teams.Count % 2 == 1)
            {
                teams.Add(new Team("bye", league)); //add a bye team if there is an odd number
            }

            for (int week = 0; week < nudNumWeeks.Value; week++)
            {
                //For each week, we'll matchup the teams in the list as follows (for an 8 team example):
                // 0 - 7
                // 1 - 6
                // 2 - 5
                // 3 - 4
                //Then we'll rotate indices 1-7 by 1, and rerun for the next week

                for (int i = 0; i < teams.Count / 2; i++)
                {
                    //If one of the teams in this matchup is actually a bye, make the other team TeamA in the matchup
                    //Set TeamB to null.  This signifies a bye
                    if (teams[i].Name == "bye")
                    {
                        league.AddMatchup(new Matchup(week, teams[i], null));
                    }
                    if (teams[teams.Count - i - 1].Name == "bye")
                    {
                        league.AddMatchup(new Matchup(week, teams[teams.Count - i - 1], null));
                    }
                    else
                    {
                        league.AddMatchup(new Matchup(week, teams[i], teams[teams.Count - i - 1]));
                    }
                }

                //Rotate the items in the list from index 1 onwards by 1, leaving 0 untouched
                var last = teams[teams.Count - 1];
                for (int i = teams.Count - 2; i >= 1; i--)
                {
                    teams[i + 1] = teams[i];
                }
                teams[1] = last;
            }

            //print
            for (int week = 0; week < nudNumWeeks.Value; week++)
            {
                foreach (var matchup in league.GetMatchups(week))
                {
                    tbMessages.AppendText(matchup.ToString() + "\r\n");
                }
                tbMessages.AppendText("\r\n");
            }

            RefreshInterface();
        }

        private void btnFreeAgents_Click(object sender, EventArgs e)
        {
            var freeAgents = new frmFreeAgents(league);
            freeAgents.ShowDialog();
		}
    }
}
