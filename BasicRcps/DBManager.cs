using System.Data;
using System.Data.SqlClient;

namespace BasicRcps
{
    public class DBManager
    {
        private string ConnectionString { get; }
        private SqlConnection conn;
        private SqlCommand cmd;
        private string query;

        public DBManager(string query)
        {
            ConnectionString = "Data Source=MAXIMILIANF417\\SQLEXPRESS;Initial Catalog=NORTHWIND;Integrated Security=True";
            this.query = query;
        }

        public DataTable ExecuteQuery()
        {
            DataTable table = new DataTable();

            using (conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }


        public DataTable ExecuteQueryTestSP(string searchValue)
        {
            DataTable table = new DataTable();

            using (conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SearchValue", searchValue);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }

        public void ExecuteNonQuery()
        {
            using (conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
