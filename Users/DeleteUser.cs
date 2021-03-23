using System.Data.OleDb;

namespace Organizer
{
    /// <summary>
    /// Удаляет пользователя из БД
    /// </summary>
    class DeleteUser:Connection
    {
        public void Del(string userName)
        {
            connection.Open();
            var del = new OleDbCommand($"DELETE * FROM Users " +
                                    $"WHERE [Login] = '{userName}'"
                                        ,connection);
            del.ExecuteNonQuery();
                connection.Close();
        }
    }
}
