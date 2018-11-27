using System;
using System.Windows.Forms;

namespace BasicRcps
{
    public partial class StartMenu : Form
    {
        private string connString =
            "Data Source=MAXIMILIANF417\\SQLEXPRESS;Initial Catalog=BASICRCPS;Integrated Security=True";
        public StartMenu()
        {
            InitializeComponent();
            dataGridViewSearch.DataSource = Order.GetOrders();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewSearch.DataSource = Recipe.GetSearchResults(textBoxSearch.Text);
        }

        private void dataGridViewSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataGridViewSearch.SelectedCells[0];
            string cellValue = cell.Value.ToString();
            
            dataGridViewInfo.DataSource = Ingredient.GetSearchResults(cellValue);
        }

        
        private void buttonDeleteRecipe_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = dataGridViewSearch.SelectedCells[0];
            string recipeName = cell.Value.ToString();

            RecipeDetail recipeDetail = new RecipeDetail();
            recipeDetail.DeleteRecipeDetail(recipeName);

            Recipe recipe = new Recipe();
            recipe.DeleteRecipe(recipeName);
        }

        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {
            Form add = new AddRecipe();
            add.Show();
        }

        private void buttonUpdateRecipe_Click(object sender, EventArgs e)
        {
            Form add = new UpdateRecipe();
            add.Show();
        }
        
    }
}
