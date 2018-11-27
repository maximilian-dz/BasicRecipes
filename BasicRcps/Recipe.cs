using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRcps
{
    public class Recipe
    {
        public int RecipeID { get; set; }   
        public string RecipeName { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }


        public static DataTable GetSearchResults(string value)
        {
            DBManager db = new DBManager(
                "SELECT Recipe.RecipeName, Category.CategoryName " +
                "FROM Recipe " +
                "INNER JOIN Category ON Category.CategoryID = Recipe.CategoryID " +
                "WHERE Category.CategoryName LIKE '%" + value + "%' " +
                "OR Recipe.RecipeName LIKE '%" + value + "%' " +
                "OR Category.CategoryName + ' ' + Recipe.RecipeName LIKE '%" + value + "%' " +
                "OR Recipe.RecipeName + ' ' + Category.CategoryName LIKE '%" + value + "%' ");

            return db.ExecuteQuery();
        }

        public static DataTable GetSearchResultsWithSP(string searchValue)
        {
            DBManager db = new DBManager("FindRecipe");


            return db.ExecuteQueryTestSP(searchValue);
        }

        public void CreateRecipe(string categoryName)
        {
            DBManager db = new DBManager(
                "INSERT INTO Recipe (RecipeName, Description, CategoryID) " +
                "VALUES('" + RecipeName + "', '" + Description + "', " +
                "(SELECT CategoryID FROM Category WHERE CategoryName = '" + categoryName + "'))");

            db.ExecuteNonQuery();
        }

        public void DeleteRecipe(string recipeName)
        {
            DBManager db = new DBManager(

                "DELETE Recipe " +
                "FROM Recipe " +
                "WHERE RecipeName = '" + recipeName + "' ");

            db.ExecuteNonQuery();
        }

        public static DataTable DisplayRecipes()
        {
            DBManager db = new DBManager("SELECT RecipeName FROM Recipe");
            return db.ExecuteQuery();
        }

        public void UpdateRecipeName(string recipeName)
        {
            DBManager db = new DBManager(
                "UPDATE Recipe " +
                "SET RecipeName = '" + RecipeName + "', Description = '" + Description + "' " +
                "WHERE RecipeName = '" + recipeName + "' ");

            db.ExecuteNonQuery();
        }
    }
}
