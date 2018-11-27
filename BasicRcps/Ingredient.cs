using System.Data;

namespace BasicRcps
{
    public class Ingredient
    {
        public string IngredientName { get; set; }

        public static DataTable GetSearchResults(string value)
        {
            DBManager db = new DBManager(
                "SELECT Recipe.RecipeID, Recipe.Description, Recipe.RecipeName, " +
                "Ingredient.IngredientName + ', ' + RecipeDetails.Quantity AS Ingredients, " +
                "Category.CategoryName " +
                "FROM Recipe " +
                "INNER JOIN RecipeDetails ON RecipeDetails.RecipeID = Recipe.RecipeID " +
                "INNER JOIN Ingredient ON Ingredient.IngredientID = RecipeDetails.IngredientID " +
                "INNER JOIN Category ON Category.CategoryID = Recipe.CategoryID " +
                "WHERE Recipe.RecipeName = '" + value + "' ");

            return db.ExecuteQuery();
        }

        public static DataTable DisplayIngredients(string recipeName)
        {
            DBManager db = new DBManager(
                "SELECT IngredientName + ',' + Quantity AS Ingredient " +
                "FROM RecipeDetails " +
                "INNER JOIN Ingredient ON Ingredient.IngredientID = RecipeDetails.IngredientID " +
                "INNER JOIN Recipe ON Recipe.RecipeID = RecipeDetails.RecipeID " +
                "WHERE RecipeName = '" + recipeName + "'");

            return db.ExecuteQuery();
        }

        public void AddIngredientToRecipe(string recipeName, string quantity)
        {
            DBManager db = new DBManager(
                "INSERT INTO Ingredient (IngredientName) " +
                "VALUES('" + IngredientName + "') " +
                "INSERT INTO RecipeDetails(RecipeID, IngredientID, Quantity) " +
                "VALUES((SELECT Recipe.RecipeID FROM Recipe WHERE Recipe.RecipeName = '" + recipeName +
                "'), SCOPE_IDENTITY(), '" + quantity + "')");

            db.ExecuteNonQuery();
        }

        public static DataTable UpdateListOfIngredients(string recipeName)
        {
            DBManager db = new DBManager(
                "SELECT IngredientName + ', ' + Quantity AS Ingredient " +
                "FROM RecipeDetails " +
                "INNER JOIN Ingredient ON Ingredient.IngredientID = RecipeDetails.IngredientID " +
                "INNER JOIN Recipe ON Recipe.RecipeID = RecipeDetails.RecipeID " +
                "WHERE Recipe.RecipeName = '" + recipeName + "'");

            return db.ExecuteQuery();
        }
    }
}
