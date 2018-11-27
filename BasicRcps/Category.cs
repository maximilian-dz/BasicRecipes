using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BasicRcps
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public static DataTable DisplayCategories()
        {
            DBManager db = new DBManager(
                "SELECT DISTINCT CategoryName FROM Category ");

            return db.ExecuteQuery();
        }
    }
}
