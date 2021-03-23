using System.Data.OleDb;
using System.Collections.Generic;


namespace Organizer
{
    /// <summary>
    /// Производит получение логинов всех 
    /// пользователей из БД
    /// </summary>
    class GetUserNames:Connection
    {
        public List<string> Get()
        {
          connection.Open();
            var logins = new List<string>();
                var command = new OleDbCommand("SELECT [Login] FROM Users",connection);
                   var reader = command.ExecuteReader();
            
            while(reader.Read())
                logins.Add((string)reader[0]);
            
           connection.Close();
                return logins;    
        }
    }
}
