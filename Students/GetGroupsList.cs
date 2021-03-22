using System.Data.OleDb;
using System.Collections.Generic;

namespace Organizer
{
    class GetGroupsList:Connection
    {
        public List<string> Get()
        {
            var groups = new List<string>();
            connection.Open();
            var command = new OleDbCommand("SELECT Group FROM STUDENTS", connection);
            var reader = command.ExecuteReader();
            while(reader.Read())
            {
                if(!groups.Contains((string)reader[0]))
                              groups.Add((string)reader[0]);
            }
            return groups;
        }
    }
}
