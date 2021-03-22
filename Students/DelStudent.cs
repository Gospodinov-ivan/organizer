using System.Data.OleDb;

namespace Organizer
{
    /// <summary>
    /// производит запрос к базе данных 
    /// на удаление строки из базы данных Student 
    /// </summary>
    class DelStudent:Connection
    {
        /// <summary>
        /// производит запрос к базе данных 
        /// на удаление строки из базы данных Student 
        /// по полю ID
        /// </summary>
        /// <param name="ID"></param>
        public void Del(int ID)
        {
            connection.Open();
            var command = new OleDbCommand($"DELETE FROM Students " +
                                            $"WHERE ID = {ID}",
                                            connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
