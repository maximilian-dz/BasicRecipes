using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRcps
{
    public class RecipeDetail
    {
        public int RecipeID { get; set; }
        public int IngredientID { get; set; }
        public string Quantity { get; set; }

        public RecipeDetail()
        {
            
        }

        public void DeleteRecipeDetail(string recipeName)
        {
            DBManager db = new DBManager(
                "DELETE RecipeDetails " +
                "FROM RecipeDetails " +
                "INNER JOIN Recipe ON Recipe.RecipeID = RecipeDetails.RecipeID " +
                "WHERE RecipeName = '" + recipeName + "' " );

            db.ExecuteNonQuery();
        }

        public void UpdateRecipeIngredient(string ingredientName, string recipeName)
        {
            DBManager db = new DBManager(
                "UPDATE RecipeDetails " +
                "SET Quantity = '" + Quantity + "' " +
                "FROM RecipeDetails " +
                "INNER JOIN Recipe ON Recipe.RecipeID = RecipeDetails.RecipeID " +
                "INNER JOIN Ingredient ON Ingredient.IngredientID = RecipeDetails.IngredientID " +
                "WHERE RecipeName = '" + recipeName + "' " +
                "AND IngredientName = '" + ingredientName + "' " +
                "UPDATE Ingredient " +
                "SET IngredientName = '" +ingredientName + "' " +
                "FROM Ingredient " +
                "INNER JOIN RecipeDetails ON RecipeDetails.IngredientID = Ingredient.IngredientID " +
                "INNER JOIN Recipe ON Recipe.RecipeID = RecipeDetails.RecipeID " +
                "WHERE RecipeName = '" + recipeName + "' " +
                "AND IngredientName = '" + ingredientName + "'");
            db.ExecuteNonQuery();
        }

        public void DeleteIngredientFromRecipe(string recipeName, string ingredientName)
        {
            DBManager db = new DBManager(
                "DELETE RecipeDetails " +
                "FROM RecipeDetails " +
                "INNER JOIN Ingredient ON Ingredient.IngredientID = RecipeDetails.IngredientID " +
                "INNER JOIN Recipe ON Recipe.RecipeID = RecipeDetails.RecipeID " +
                "WHERE RecipeName = '" + recipeName + "' " +
                "AND Ingredient.IngredientName = '" +
                ingredientName + "'");

            db.ExecuteNonQuery();
        }
    }
}
