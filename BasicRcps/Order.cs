using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRcps
{
    public class Order
    {
        public static DataTable GetOrders()
        {
            DBManager db = new DBManager(
                "SELECT o.OrderID " +
                "FROM Customers c " +
                "INNER JOIN Orders o ON c.CustomerID = o.CustomerID " +
                "WHERE c.CustomerID = 'ALFKI'");

            return db.ExecuteQuery();
        }
    }
}
