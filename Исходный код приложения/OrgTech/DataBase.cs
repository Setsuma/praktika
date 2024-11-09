using System.Data;
using System.Data.SqlClient;

namespace GUI
{
    public class DataBase
    {
        SqlConnection SQLConnection = new SqlConnection(@"Data Source=LAPTOP-OFE4D0PA;Initial Catalog=Pilipas;Integrated Security=True");

        public void openConnection()
        {
            if (SQLConnection.State == System.Data.ConnectionState.Closed)
            {
                SQLConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (SQLConnection.State == System.Data.ConnectionState.Open)
            {
                SQLConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return SQLConnection;
        }
    }
}
