namespace Organizer
{
    class Student
    {
        public int ID { get; set; }
        public string Group { get; set; }
        public string Surname { get; set; }
        public string Exems { get; set; }
        public string Scores { get; set;}
        
        public Student(string Group, 
                        string Surname, 
                            string Exems,
                             string Scores)
        {
            this.Group = Group;
            this.Surname = Surname;
            this.Exems = Exems;
            this.Scores = Scores;
        }

        public Student(int ID,
                        string Group,
                            string Surname,
                                string Exems,
                                    string Scores)
        {
            this.ID = ID;
            this.Group = Group;
            this.Surname = Surname;
            this.Exems = Exems;
            this.Scores = Scores;
        }
    }
}
