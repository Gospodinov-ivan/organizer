using System.Data.OleDb;

namespace Organizer
{
    /// <summary>
    /// Проверка на существование пользвоателя
    /// с парой Логин-Пароль
    /// </summary>
    class ValidateUser:Connection
    {
        public int validate(string login, string password)
        {
            connection.Open();
            var command = new OleDbCommand($"SELECT * FROM Users WHERE [Login] = '{login}' AND [Password] = '{password}'",
                                            connection);
            var reader = command.ExecuteReader();
            var count = reader.HasRows;
            connection.Close();
            if (count)
                return 1;
            else
                return 0;
        }
    }
}
