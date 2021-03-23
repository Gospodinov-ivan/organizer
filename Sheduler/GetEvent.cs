using System.Data.OleDb;
using System.Collections.Generic;
using System;

namespace Organizer
{
    class GetEvent:Connection
    {
        public List<Event> Get()
        {
            var shedules = new List<Event>();
            connection.Open();
            var command = new OleDbCommand("SELECT * FROM Sheduler",
                                                 connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
                shedules.Add(new Event(
                                  (int)reader[0],
                                   (string)reader[1],
                                   (DateTime)reader[2]));
            connection.Close();
            return shedules;
        }
    }
}
