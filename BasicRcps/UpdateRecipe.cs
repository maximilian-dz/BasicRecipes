using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicRcps
{
    public partial class UpdateRecipe : Form
    {
        private string connString =
            "Data Source=MAXIMILIANF417\\SQLEXPRESS;Initial Catalog=BASICRCPS;Integrated Security=True";

        public UpdateRecipe()
        {
            InitializeComponent();
            
            listBoxRecipes.DisplayMember = "RecipeName";
            listBoxRecipes.DataSource = Recipe.DisplayRecipes();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DataRowView selectedItem = (DataRowView)listBoxRecipes.SelectedItem;
            var recipeName = selectedItem[0].ToString();

            Recipe recipe = new Recipe
            {
                RecipeName = textBoxName.Text,
                Description = textBoxDescription.Text
                
            };
                
            recipe.UpdateRecipeName(recipeName);
            this.Close();
        }

        private void listBoxIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ShowIngredientAndQuantity();
        }

        


        private void buttonAddIngredient_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = new Ingredient
            {
                IngredientName = textBoxIngredient.Text
            };

            ingredient.AddIngredientToRecipe(textBoxName.Text, textBoxQuantity.Text);

            UpdateListOfIngredients();
        }



        private void buttonEditIngredient_Click(object sender, EventArgs e)
        {
            DataRowView selectedItem = (DataRowView)listBoxIngredients.SelectedItem;
            var ingredientName = selectedItem[0].ToString().Split(',').ElementAt(0);
            
            RecipeDetail rd = new RecipeDetail
            {
                Quantity = textBoxQuantity.Text
            };

            rd.UpdateRecipeIngredient(ingredientName, textBoxName.Text);
            
            UpdateListOfIngredients();
        }


        private void buttonDeleteIngredient_Click(object sender, EventArgs e)
        {
            DataRowView selectedItem = (DataRowView) listBoxIngredients.SelectedItem;
            var ingredientName = selectedItem[0].ToString().Split(',').ElementAt(0);
            
            RecipeDetail rd = new RecipeDetail();
            rd.DeleteIngredientFromRecipe(textBoxName.Text, ingredientName);
            UpdateListOfIngredients();
        }



        //private void ShowIngredientAndQuantity()
        //{
        //    using (SqlConnection conn = new SqlConnection(connString))
        //    {
        //        conn.Open();

        //        DataRowView selectedItem = (DataRowView) listBoxIngredients.SelectedItem;

        //        SqlCommand cmd = new SqlCommand(
        //            "SELECT IngredientName, Quantity " +
        //            "FROM Ingredient " +
        //            "INNER JOIN RecipeDetails ON RecipeDetails.IngredientID = Ingredient.IngredientID " +
        //            "INNER JOIN Recipe ON Recipe.RecipeID = RecipeDetails.RecipeID " +
        //            "WHERE IngredientName = '" + selectedItem[0].ToString().Split(',').ElementAt(0) + "' " +
        //            "AND Quantity = '" + selectedItem[0].ToString().Split(',').ElementAt(1) + "' ", conn);

        //        SqlDataReader rdr = cmd.ExecuteReader();

        //        while (rdr.Read())
        //        {
        //            textBoxIngredient.Text = rdr["IngredientName"].ToString();
        //            textBoxQuantity.Text = rdr["Quantity"].ToString();
        //        }
        //    }
        //}

        private void listBoxRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRecipe = (DataRowView)listBoxRecipes.SelectedItem;
            var recipeName = selectedRecipe[0].ToString();

            listBoxIngredients.DisplayMember = "Ingredient";
            listBoxIngredients.DataSource = Ingredient.DisplayIngredients(recipeName);


            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT CategoryName, RecipeName, Description " +
                    "FROM Category " +
                    "INNER JOIN Recipe ON Recipe.CategoryID = Category.CategoryID " +
                    "WHERE RecipeName = '" + selectedRecipe[0] + "'", conn);

                var rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    textBoxName.Text = rdr["RecipeName"].ToString();
                    textBoxCategory.Text = rdr["CategoryName"].ToString();
                    textBoxDescription.Text = rdr["Description"].ToString();
                }
            }
        }
        private void UpdateListOfIngredients()
        {
            listBoxIngredients.DisplayMember = "Ingredient";
            listBoxIngredients.DataSource = Ingredient.UpdateListOfIngredients(textBoxName.Text);
        }
    }
}  

