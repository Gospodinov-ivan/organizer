using System.Data.OleDb;

namespace Organizer
{
    class Connection
    {
        private const string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                        "Data Source=Resources/Course.mdb;";
        
        protected OleDbConnection connection = new OleDbConnection(connectionString);
       
        public OleDbConnection GetConnection()
        {
            connection.Open();
            return connection;
        }
        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
