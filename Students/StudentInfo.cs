namespace Organizer
{
    /// <summary>
    /// Предоставляет абстракцию 
    /// над таблицей c задолжниками
    /// </summary>
    class StudentInfo
    {
        public int ID { get; set; }
        public string Surname { get; set; }
        public double RoundedMark { get; set; }
        public int NoAttistation { get; set; }
        public string Group { get; set; }

        public StudentInfo(string surname, double mark, int noAttistation)
        {
            RoundedMark = mark;
            NoAttistation = noAttistation;
            Surname = surname; 
        }

        public StudentInfo(int ID, string group, string surname,int noAttistation)
        {
            this.ID = ID;
            Group = group;
            NoAttistation = noAttistation;
            Surname = surname;
        }
    }
}
