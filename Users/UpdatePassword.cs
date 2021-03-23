using System.Data.OleDb;

namespace Organizer
{
    /// <summary>
    /// Производит обновление поля Password 
    /// Для указанного пользователя
    /// </summary>
    class UpdatePassword:Connection
    {
        public void update(string login, string password)
        {
            connection.Open();
            var command = new OleDbCommand($"UPDATE Users SET " +
                                 $"[Password] = '{password}'" +
                                    $"WHERE [Login] = '{login}'"
                                    ,connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
