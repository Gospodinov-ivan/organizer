using System.Data.OleDb;

namespace Organizer
{
    class DelEvent:Connection
    {
        public void Del(string EventText)
        {
            connection.Open();
            var command = new OleDbCommand($"DELETE * FROM Sheduler WHERE [Event] = '{EventText}'",
                                            connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
