using System.Data.OleDb;

namespace Organizer
{
    /// <summary>
    /// Добавляет пользователя в базу данных
    /// </summary>
    class AddUser:Connection
    {
        public void Add(string login, string pass)
        {
            connection.Open();
            var command = new OleDbCommand($"INSERT INTO Users ([Login],[Password])" +
                $"VALUES ('{login}'," +
                $"'{pass}')",
                connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }    
}
