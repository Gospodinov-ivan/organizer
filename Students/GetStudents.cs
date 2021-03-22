using System.Data.OleDb;
using System.Collections.Generic;

namespace Organizer
{
    /// <summary>
    /// производит выборки элементов из таблицы Students
    /// </summary>
    class GetStudents:Connection
    {
        /// <summary>
        /// Осуществляет запрос к базе данных 
        /// на выборку всех элементов из таблицы Students
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Осуществляет запрос к базе данных 
        /// на выборку всех студентов заданной группы
        /// из таблицы Students
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
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
