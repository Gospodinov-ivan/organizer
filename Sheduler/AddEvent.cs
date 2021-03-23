using System;
using System.Data.OleDb;

namespace Organizer
{
    class AddEvent:Connection
    {
        public void Add(string Event, DateTime date)
        {
            connection.Open();
            var command = new OleDbCommand($"INSERT INTO Sheduler ([Event],[Date])" +
                                            $"VALUES ('{Event}'," +
                                            $"'{date}')",
                                            connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
