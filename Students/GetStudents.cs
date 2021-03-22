using System.Data.OleDb;
using System.Collections.Generic;

namespace Organizer
{
    class GetStudents:Connection
    {
        public List<Student> GetAll()
        {
            connection.Open();
                var getCommand = $"SELECT * FROM Students";
                    var command = new OleDbCommand(getCommand, connection);
                        var reader = command.ExecuteReader();
            var students = new List<Student>();
            
            while(reader.Read())
                students.Add(new Student((int)reader[0],
                                            (string)reader[1],
                                                 (string)reader[2],
                                                    (string)reader[3],
                                                        (string)reader[4]));
            return students;
        }

        public List<Student> GetByGroup(string group)
        {
            connection.Open();
            var getCommand = $"SELECT * FROM Students WHERE [Group] = '{group}'";
            var command = new OleDbCommand(getCommand, connection);
            var reader = command.ExecuteReader();
            var students = new List<Student>();

            while (reader.Read())
                students.Add(new Student((int)reader[0],
                                            (string)reader[1],
                                                 (string)reader[2],
                                                    (string)reader[3],
                                                        (string)reader[4]));
            return students;
        }
    }
}
