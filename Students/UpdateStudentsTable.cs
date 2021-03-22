using System.Data.OleDb;
using System.Collections.Generic;

namespace Organizer
{
    class UpdateStudentsTable:Connection
    {
        public void Update(List<Student> studentsList)
        {
            foreach (Student student in studentsList)
            {
                connection.Open();
                var command = new OleDbCommand($"UPDATE Students SET " +
                                     $"[Group] = '{student.Group}'," +
                                     $"[Surname] = '{student.Surname}'," +
                                     $"[Exems] = '{student.Exems}'," +
                                     $"[Scores] = '{student.Scores}'" +
                                     $"WHERE ID = {student.ID}",
                                     connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
