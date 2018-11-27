using System;
using System.Data;
using System.Windows.Forms;

namespace BasicRcps
{
    public partial class AddRecipe : Form
    {
        public AddRecipe()
        {
            InitializeComponent();
            
            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.DataSource = Category.DisplayCategories();
        }

        private void buttonSaveValues_Click(object sender, EventArgs e)
        {
            DataRowView selCategory = (DataRowView)comboBoxCategory.SelectedItem;
            var categoryName = selCategory[0].ToString();

            Recipe recipe = new Recipe
            {
                RecipeName = textBoxName.Text,
                Description = textBoxDescription.Text
            };

            recipe.CreateRecipe(categoryName);
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void buttonAddIngredient_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = new Ingredient
            {
                IngredientName = textBoxIngredient.Text
            };

            ingredient.AddIngredientToRecipe(textBoxName.Text, textBoxQuantity.Text);
            UpdateIngredientList();

        }

        private void UpdateIngredientList()
        {
            listBoxIngredients.DisplayMember = "Ingredient";
            listBoxIngredients.DataSource = Ingredient.UpdateListOfIngredients(textBoxName.Text);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
           
           this.Close();
        }
    }
}
