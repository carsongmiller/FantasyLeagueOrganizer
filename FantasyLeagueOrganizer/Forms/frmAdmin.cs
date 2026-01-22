using FantasyLeagueOrganizer.controls;
using FantasyLeagueOrganizer.DatabseClasses;
using FantasyLeagueOrganizer.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics.Internal;
using Microsoft.Extensions.Options;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.ComponentModel;

namespace FantasyLeagueOrganizer.Forms
{
    public partial class frmAdmin : frmFantasyLeagueBase
    {
        public frmAdmin(LeagueDbContext context) : base(context)
        {
            InitializeComponent();

            SetupInterface();

			if (League != null)
			{
				RefreshUI();
			}
		}

        private void btnRecreateLeague_Click(object sender, EventArgs e)
        {
            int numTeams = (int)nudNumTeams.Value;

            using var context = new LeagueDbContext();

            try
            {
                context.Database.EnsureDeleted();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            context.Database.EnsureCreated();

            League = new League("The Iron Skillet");

            League.DisplayNameTeamSingular = "Chef";
            League.DisplayNameTeamPlural = "Chefs";

            League.DisplayNameItemSingular = "Dish";
            League.DisplayNameItemPlural = "Dishes";

            League.DisplayNameCategorySingular = "Cuisine";
            League.DisplayNameCategoryPlural = "Cuisines";

            var categoryMain = new Category("Main", 2, League);
            var categorySide = new Category("Side", 2, League);
            var categoryDessert = new Category("Dessert", 1, League);
            var categoryBreakfast = new Category("Breakfast", 1, League);
            var categoryDrink = new Category("Drink", 1, League);
            var categoryFastFood = new Category("Fast Food", 1, League);
            var categoryFlex = new Category("Flex", 1, League);


            var Pizza = new Item("Pizza", categoryMain, League);
            var Cheeseburger = new Item("Cheeseburger", categoryMain, League);
            var Fried_Chicken = new Item("Fried Chicken", categoryMain, League);
            var Steak = new Item("Steak", categoryMain, League);
            var Meatloaf = new Item("Meatloaf", categoryMain, League);
            var Lasagna = new Item("Lasagna", categoryMain, League);
            var Mac_and_Cheese = new Item("Mac and Cheese", categoryMain, League);
            var Tacos = new Item("Tacos", categoryMain, League);
            var Burrito = new Item("Burrito", categoryMain, League);
            var Hot_Dog = new Item("Hot Dog", categoryMain, League);
            var BBQ_Ribs = new Item("BBQ Ribs", categoryMain, League);
            var Pulled_Pork = new Item("Pulled Pork", categoryMain, League);
            var Chicken_Alfredo = new Item("Chicken Alfredo", categoryMain, League);
            var Stir_Fry = new Item("Stir Fry", categoryMain, League);
            var Curry = new Item("Curry", categoryMain, League);
            var Chili = new Item("Chili", categoryMain, League);
            var Sub_Sandwich = new Item("Sub Sandwich", categoryMain, League);
            var Beef_Brisket = new Item("Beef Brisket", categoryMain, League);
            var Tater_Tot_Hot_Dish = new Item("Tater Tot Hot Dish", categoryMain, League);
            var Chicken_Tenders = new Item("Chicken Tenders", categoryMain, League);

            var Pancakes = new Item("Pancakes", categoryBreakfast, League);
            var Waffles = new Item("Waffles", categoryBreakfast, League);
            var French_Toast = new Item("French Toast", categoryBreakfast, League);
            var Eggs = new Item("Eggs", categoryBreakfast, League);
            var Bacon = new Item("Bacon", categoryBreakfast, League);
            var Hash_Browns = new Item("Hash Browns", categoryBreakfast, League);
            var Biscuits_and_Gravy = new Item("Biscuits and Gravy", categoryBreakfast, League);
            var Bagel_with_Cream_Cheese = new Item("Bagel with Cream Cheese", categoryBreakfast, League);
            var English_Muffin = new Item("English Muffin", categoryBreakfast, League);
            var Milk_and_Cereal = new Item("Milk and Cereal", categoryBreakfast, League);
            var Oatmeal = new Item("Oatmeal", categoryBreakfast, League);
            var Yogurt = new Item("Yogurt", categoryBreakfast, League);
            var Avocado_Toast = new Item("Avocado Toast", categoryBreakfast, League);
            var Muffin = new Item("Muffin", categoryBreakfast, League);
            var Cinnamon_Roll = new Item("Cinnamon Roll", categoryBreakfast, League);
            var Donut = new Item("Donut", categoryBreakfast, League);
            var Breakfast_Pizza = new Item("Breakfast Pizza", categoryBreakfast, League);
            var Croissant = new Item("Croissant", categoryBreakfast, League);
            var Caramel_Roll = new Item("Caramel Roll", categoryBreakfast, League);
            var Crepes = new Item("Crepes", categoryBreakfast, League);

            var Ice_Cream = new Item("Ice Cream", categoryDessert, League);
            var Angel_Food_Cake = new Item("Angel Food Cake", categoryDessert, League);
            var Chocolate_Chip_Cookies = new Item("Chocolate Chip Cookies", categoryDessert, League);
            var Brownies = new Item("Brownies", categoryDessert, League);
            var Apple_Pie = new Item("Apple Pie", categoryDessert, League);
            var Cheesecake = new Item("Cheesecake", categoryDessert, League);
            var Cupcakes = new Item("Cupcakes", categoryDessert, League);
            var Gelato = new Item("Gelato", categoryDessert, League);
            var Frozen_Yogurt = new Item("Frozen Yogurt", categoryDessert, League);
            var Sundae = new Item("Sundae", categoryDessert, League);
            var Milkshake = new Item("Milkshake", categoryDessert, League);
            var Chocolate_Bar = new Item("Chocolate Bar", categoryDessert, League);
            var Rice_Pudding = new Item("Rice Pudding", categoryDessert, League);
            var Tiramisu = new Item("Tiramisu", categoryDessert, League);
            var Chocolate_Lava_Cake = new Item("Chocolate Lava Cake", categoryDessert, League);
            var Popsicle = new Item("Popsicle", categoryDessert, League);
            var Pumpkin_Pie = new Item("Pumpkin Pie", categoryDessert, League);
            var Sorbet = new Item("Sorbet", categoryDessert, League);
            var Flan = new Item("Flan", categoryDessert, League);
            var Churro = new Item("Churro", categoryDessert, League);

            var French_Fries = new Item("French Fries", categorySide, League);
            var Mashed_Potatoes = new Item("Mashed Potatoes", categorySide, League);
            var Baked_Potato = new Item("Baked Potato", categorySide, League);
            var Tater_Tots = new Item("Tater Tots", categorySide, League);
            var Onion_Rings = new Item("Onion Rings", categorySide, League);
            var Coleslaw = new Item("Coleslaw", categorySide, League);
            var Fried_Rice = new Item("Fried Rice", categorySide, League);
            var Roasted_Vegetables = new Item("Roasted Vegetables", categorySide, League);
            var Caesar_Salad = new Item("Caesar Salad", categorySide, League);
            var Corn_on_the_Cob = new Item("Corn on the Cob", categorySide, League);
            var Dinner_Rolls = new Item("Dinner Rolls", categorySide, League);
            var Garlic_Bread = new Item("Garlic Bread", categorySide, League);
            var Breadsticks = new Item("Breadsticks", categorySide, League);
            var Stuffing = new Item("Stuffing", categorySide, League);
            var Baked_Beans = new Item("Baked Beans", categorySide, League);
            var Potato_Salad = new Item("Potato Salad", categorySide, League);
            var Fruit_Salad = new Item("Fruit Salad", categorySide, League);
            var Applesauce = new Item("Applesauce", categorySide, League);
            var Chips = new Item("Chips", categorySide, League);
            var Pretzels = new Item("Pretzels", categorySide, League);

            var Still_Water = new Item("Still Water", categoryDrink, League);
            var Sparkling_Water = new Item("Sparkling Water", categoryDrink, League);
            var Coke = new Item("Coke", categoryDrink, League);
            var Root_Beer = new Item("Root Beer", categoryDrink, League);
            var Sweet_Tea = new Item("Sweet Tea", categoryDrink, League);
            var Black_Tea = new Item("Black Tea", categoryDrink, League);
            var Black_Coffee = new Item("Black Coffee", categoryDrink, League);
            var Hot_Chocolate = new Item("Hot Chocolate", categoryDrink, League);
            var White_Milk = new Item("White Milk", categoryDrink, League);
            var Chocolate_Milk = new Item("Chocolate Milk", categoryDrink, League);
            var Orange_Juice = new Item("Orange Juice", categoryDrink, League);
            var Lemonade = new Item("Lemonade", categoryDrink, League);
            var Smoothie = new Item("Smoothie", categoryDrink, League);
            var Protein_Shake = new Item("Protein Shake", categoryDrink, League);
            var Beer = new Item("Beer", categoryDrink, League);
            var Red_Wine = new Item("Red Wine", categoryDrink, League);
            var Whiskey = new Item("Whiskey", categoryDrink, League);
            var Apple_Cider = new Item("Apple Cider", categoryDrink, League);
            var White_Monster = new Item("White Monster", categoryDrink, League);
            var Celsius = new Item("Celsius", categoryDrink, League);

            var McDonalds = new Item("McDonald's", categoryFastFood, League);
            var Burger_King = new Item("Burger King", categoryFastFood, League);
            var Wendys = new Item("Wendy's", categoryFastFood, League);
            var Taco_Bell = new Item("Taco Bell", categoryFastFood, League);
            var KFC = new Item("KFC", categoryFastFood, League);
            var Popeyes = new Item("Popeyes", categoryFastFood, League);
            var Chick_fil_A = new Item("Chick-fil-A", categoryFastFood, League);
            var Subway = new Item("Subway", categoryFastFood, League);
            var Little_Caesars = new Item("Little Caesar's", categoryFastFood, League);
            var Sonic = new Item("Sonic", categoryFastFood, League);
            var Arbys = new Item("Arby's", categoryFastFood, League);
            var Jack_in_the_Box = new Item("Jack in the Box", categoryFastFood, League);
            var Dairy_Queen = new Item("Dairy Queen", categoryFastFood, League);
            var Jersey_Mikes = new Item("Jersey Mike's", categoryFastFood, League);
            var Chipotle = new Item("Chipotle", categoryFastFood, League);
            var Raising_Canes = new Item("Raising Cane's", categoryFastFood, League);
            var In_N_Out_Burger = new Item("In-N-Out Burger", categoryFastFood, League);
            var Shake_Shack = new Item("Shake Shack", categoryFastFood, League);
            var Culvers = new Item("Culver's", categoryFastFood, League);
            var Five_Guys = new Item("Five Guys", categoryFastFood, League);

            foreach (var item in League.Items)
            {
                item.AddCategory(categoryFlex);
            }

            var rand = new Random();
            //Generate teams
            for (int i = 0; i < numTeams; i++)
            {
                var newTeam = new Team($"Team {i + 1}", League);
                newTeam.Color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            }

            if (cbFillLineups.Checked)
            {
				//randomly assign enough items for a valid lineup to each team
				foreach (var team in League.Teams)
				{
					foreach (var category in League.Categories)
					{
						for (int i = 0; i < category.RequiredCount; i++)
						{
							var nextItem = category.FreeAgents.First();
							nextItem.AddToTeam(team);
							nextItem.AddToLineup(category);
						}
					}
				}
			}
            

            //Generate a random schedule
            League.GenerateRoundRobinSchedule();

            //Generate one ranking provider per week that the league will have, with random rankings for each item
            int numWeeks = League.Teams.Count % 2 == 0 ? League.Teams.Count - 1 : League.Teams.Count; //number of weeks in a round robin schedule
            for (int week = 0; week < numWeeks; week++)
            {
                var rp = GenerateRandomRankingProvider(0, 10);
                League.RankingProviders.Add(rp);

                foreach (var matchup in League.GetMatchups(week))
                {
                    matchup.RankingProvider = rp;
                }
            }

            context.Leagues.Add(League);
            context.SaveChanges();
            DatabaseDataChanged.Invoke();

			RefreshUI();
        }

        private void SetupInterface()
        {
            listCategories.DisplayMember = nameof(Category.Name);
            listItems.DisplayMember = nameof(Item.Name);
            chkListCategories.DisplayMember = nameof(Category.Name);
            listTeams.DisplayMember = nameof(Team.Name);
            listRoster.DisplayMember = nameof(Item.Name);
            listWeeks.DisplayMember = nameof(Matchup.ToString);
            listRankingProviders.DisplayMember = nameof(RankingProvider.Name);

            leagueSummary1.Context = Context;
            leagueSummary2.Context = Context;
        }

        protected override void RefreshUI()
        {
            RefreshCategoryControls();
            RefreshItemControls();
            RefreshTeamControls();
            RefreshMatchupControls();

            leagueSummary1.RefreshUI();
            leagueSummary2.RefreshUI();
        }

        private void RefreshCategoryControls()
        {
            grpCategories.Text = League.DisplayNameCategoryPlural;
            btnAddOrUpdateCategory.Text = $"Add/Update {League.DisplayNameCategorySingular}";

            listCategories.Items.Clear();
            chkListCategories.Items.Clear();

            foreach (var category in League.Categories.OrderBy(c => c.Name))
            {
                listCategories.Items.Add(category);
                chkListCategories.Items.Add(category);
            }
        }

        private void RefreshItemControls()
        {
            grpItems.Text = League.DisplayNameItemPlural;
            btnAddOrUpdateItem.Text = $"Add/Update {League.DisplayNameItemSingular}";

            listItems.Items.Clear();
            foreach (var item in League.Items.OrderBy(i => i.Name))
            {
                listItems.Items.Add(item);
            }
        }

        private void RefreshTeamControls()
        {
            grpTeams.Text = League.DisplayNameTeamPlural;
            btnAddOrUpdateTeam.Text = $"Add/Update {League.DisplayNameTeamSingular}";

            listTeams.Items.Clear();
            foreach (var team in League.Teams.OrderBy(t => t.Name))
            {
                if (team.Name == "bye") continue; // skip bye teams
                listTeams.Items.Add(team);
            }

            leagueSummary1.Setup(Context);
            leagueSummary2.Setup(Context);
		}

        private void RefreshMatchupControls()
        {
            listWeeks.Items.Clear();

            //Find the number of weeks in the league
            var week = 0;
            while (League.GetMatchups(week).Count > 0)
            {
                listWeeks.Items.Add($"Week {week+1}");
                week++;
            }

            listRankingProviders.Items.Clear();
            listRankingProviders.Items.AddRange(League.RankingProviders.OrderBy(rp => rp.Name).ToArray());
        }

        private void btnLoadLeague_Click(object sender, EventArgs e)
        {
            League = DatabaseHelpers.LoadLeague(Context);
            RefreshUI();
        }

		private void LoadLeagueFromDb()
		{
			League = DatabaseHelpers.LoadLeague(Context);
			if (League != null)
			{
				RefreshUI();
			}
		}

		private void btnAddCategoryToLeague_Click(object sender, EventArgs e)
        {
            var newCategory = new Category(tbNewCategory.Text, (int)nudRequiredCount.Value, League);

			Context.Categories.Add(newCategory);
			Context.SaveChanges();
			DatabaseDataChanged.Invoke();

			RefreshUI();
        }

        private void btnAddItemToLeague_Click(object sender, EventArgs e)
        {
            var categories = new HashSet<Category>(); //list of categories to which the item belongs
            foreach (Category category in chkListCategories.CheckedItems)
            {
                categories.Add(category);
            }

            if (!League.ContainsItemWithName(tbNewItem.Text))
            {
                //Create new Item
                var newItem = new Item(tbNewItem.Text, categories, League);
				Context.Items.Add(newItem);
			}
            else
            {
                //Modify Existing Item
                var item = League.GetItem(tbNewItem.Text);
                item.SetCategories(categories);
			}

			Context.SaveChanges();
			DatabaseDataChanged.Invoke();

			RefreshUI();
        }

        private void btnRefreshInterface_Click(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void btnAddTeamToLeague_Click(object sender, EventArgs e)
        {
            if (!League.ContainsTeam(tbTeamNameCurrent.Text))
            {
                //new team being created
                var newTeam = new Team(tbTeamNameNew.Text, League);
                newTeam.Color = colorDialog1.Color;

				Context.Teams.Add(newTeam);
			}
            else
            {
                //existing team being modified
                var team = League.GetTeam(tbTeamNameCurrent.Text);
                team.Name = tbTeamNameNew.Text;
                team.ColorCode = tbNewTeamColor.Text;
			}

            Context.SaveChanges();
			DatabaseDataChanged.Invoke();

			RefreshUI();
        }

        private void btnSelectTeamColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = ColorTranslator.FromHtml(tbNewTeamColor.Text);

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
            Context.SaveChanges();
			DatabaseDataChanged.Invoke();
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

            var message = $"Are you sure you wish to delete the {League.DisplayNameItemSingular} {selectedItem.Name}?  It will be deleted from any {League.DisplayNameTeamSingular} that it belongs to.";
            if (MessageBox.Show(message, "Delete Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            League.RemoveItem(selectedItem);
			using var context = new LeagueDbContext();
			context.Leagues.Attach(League);
			context.Items.Remove(selectedItem);
			context.SaveChanges();
			DatabaseDataChanged.Invoke();

			RefreshUI();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            var selectedCategory = (Category)listCategories.SelectedItem;
            if (selectedCategory == null)
            {
                return;
            }

            var orphanItems = selectedCategory.Items.Where(i => i.Categories.Where(c => c.Name.ToLower() != "flex").Count() == 1).ToList();

            var orphanItemsString = orphanItems.Count > 0
                ? $"The following {League.DisplayNameItemPlural} will belong to zero {League.DisplayNameCategoryPlural} (except potentially flex):\n{string.Join("\n", orphanItems.Select(i => i.Name))}"
                : string.Empty;

            var message = $"Are you sure you wish to delete the {League.DisplayNameCategorySingular} {selectedCategory.Name}?\n\n{orphanItemsString}";
            if (MessageBox.Show(message, "Delete Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            Context.Remove(selectedCategory);
            Context.SaveChanges();
			DatabaseDataChanged.Invoke();

			RefreshUI();
        }

        private void btnModifyLineup_Click(object sender, EventArgs e)
        {
            if (listTeams.SelectedIndex < 0)
            {
                MessageBox.Show($"Please select a {League.DisplayNameTeamSingular} first.");
                return;
            }

            frmModifyLineup setLineupForm = new frmModifyLineup(Context, (Team)listTeams.SelectedItem);
            setLineupForm.DatabaseDataChanged = ExternalDataChanged;
            setLineupForm.ShowDialog();
            ExternalDataChanged();
        }

        private void btnGenerateSchedule_Click(object sender, EventArgs e)
        {
            League.GenerateRoundRobinSchedule();
            Context.SaveChanges();
			DatabaseDataChanged.Invoke();

			RefreshUI();
        }

        private void btnFreeAgents_Click(object sender, EventArgs e)
        {
            var freeAgents = new frmFreeAgents(Context);
            freeAgents.ShowDialog();
        }

        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            if (listTeams.SelectedItem == null)
            {
                return; //No team selected
            }

            var selectedTeam = (Team)listTeams.SelectedItem;

            var message = $"Are you sure you wish to delete the {League.DisplayNameTeamSingular} {selectedTeam.Name}?\r\n\r\n" +
                $"Any {League.DisplayNameItemPlural} that belong to the {League.DisplayNameTeamSingular} will become free agents and its matchups will be removed.";

            if (MessageBox.Show(message, "Delete Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            //League.RemoveTeam(selectedTeam);
            Context.Remove(selectedTeam);
            Context.SaveChanges();
			DatabaseDataChanged.Invoke();

			RefreshUI();
        }

        private void btnGenerateRankingProvider_Click(object sender, EventArgs e)
        {
            var newRP = GenerateRandomRankingProvider(0, 10);

			using var context = new LeagueDbContext();
			context.Leagues.Attach(League);
			context.RankingProviders.Add(newRP);
			context.SaveChanges();
			DatabaseDataChanged.Invoke();
		}

		/// <summary>
		/// Generates a ranking provider and adds it to the league
		/// </summary>
		private RankingProvider GenerateRandomRankingProvider(int scoreMin, int scoreMax)
        {
            //First generate a ranking for each item in the league, with random values
            var rankings = new List<ItemRanking>();
            var random = new Random();
            foreach (var item in League.Items)
            {
                rankings.Add(new ItemRanking(item, random.Next(scoreMin, scoreMax)));
            }

			return new RankingProvider($"New Provider {League.RankingProviders.Count + 1}", rankings);
        }

        private void listWeeks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listWeeks.SelectedIndex < 0)
            {
                return;
            }

            flowMatchups.Controls.Clear();

            //Get the currently selected week in the list
            var week = int.Parse(((string)listWeeks.SelectedItem).Substring(5)) - 1;

            foreach (var matchup in League.GetMatchups(week))
            {
                var newMatchupControl = new MatchupSmall(Context, matchup);
                newMatchupControl.DatabaseDataChanged = ExternalDataChanged;
                newMatchupControl.Width = flowMatchups.Width - newMatchupControl.Margin.Horizontal;
                flowMatchups.Controls.Add(newMatchupControl);
            }
        }

        private void btnAssignRankingProvider_Click(object sender, EventArgs e)
        {
            var selectedRP = (RankingProvider?)listRankingProviders.SelectedItem;
            var selectedWeek = listWeeks.SelectedIndex >= 0 ? int.Parse(((string)listWeeks.SelectedItem).Substring(5)) : (int?)null;

            if (selectedRP == null)
            {
                MessageBox.Show("Please select a ranking provider to assign.");
                return;
            }

            if (selectedWeek == null)
            {
                MessageBox.Show("Please select a week to assign the ranking provider to.");
                return;
            }

            foreach (var matchup in League.GetMatchups(selectedWeek.Value))
            {
                matchup.RankingProvider = selectedRP;
            }
        }

        
    }
}
