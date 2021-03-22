using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    /// <summary>
    /// Предоставляет запрос на создание
    /// таблицы Dabtors
    /// </summary>
    class DabtorTable:Connection
    {
        public void Create(List<StudentInfo> students)
        {
            connection.Open();
            var command = new OleDbCommand("DELETE FROM Debtors", connection);
            command.ExecuteNonQuery();
            foreach (StudentInfo dabtor in students)
            {
                command = new OleDbCommand("INSERT INTO Debtors ([Group],[Surname],[DebtCount]) " +
                    $" VALUES ('{dabtor.Group}'," +
                    $"'{dabtor.Surname}'," +
                    $"'{dabtor.NoAttistation}')",
                    connection);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public List<StudentInfo> sortBy(string sortType)
        {
            var sorted = new List<StudentInfo>();
            string req = " ";
            if(sortType.Equals("Фамилия"))
                req = "SELECT * FROM Debtors ORDER BY [Surname]";
            
            else if (sortType.Equals("Группа"))
                req = "SELECT * FROM Debtors ORDER BY [Group]";
            
            else
                req = "SELECT * FROM Debtors ORDER BY [DebtCount]";

            connection.Open();
                var command = new OleDbCommand(req, connection);
                     var reader  = command.ExecuteReader();

            while (reader.Read())
                sorted.Add(new StudentInfo((int)reader[0],
                                            (string)reader[1],
                                             (string)reader[2],
                                              (int)reader[3]));
            connection.Close();
            return sorted;
        }
        
    }
}
