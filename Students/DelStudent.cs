using System.Data.OleDb;

namespace Organizer
{
    class DelStudent:Connection
    {
        public void Del(int ID)
        {
            connection.Open();
            var command = new OleDbCommand($"DELETE FROM Students " +
                                            $"WHERE ID = {ID}",
                                            connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
