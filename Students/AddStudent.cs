using System.Data.OleDb;

namespace Organizer
{
    /// <summary>
    /// Производит запрос к базе данных 
    /// на добавление записи в таблицу Student
    /// </summary>
    class AddStudent :Connection
    {
       public void Add(Student student)
        {
            var addCommand = $"INSERT INTO Students ([Group], [Surname], [Exems],[Scores])" +
                $" VALUES ('{student.Group}'," +
                $"'{student.Surname}'," +
                $"'{student.Exems}'," +
                $"'{student.Scores}')";
            connection.Open();
            var command = new OleDbCommand(addCommand, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
