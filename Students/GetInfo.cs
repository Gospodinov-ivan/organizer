using System;
using System.Collections.Generic;

namespace Organizer
{
    class GetInfo
    {
        List<Student> studentsOnGroup = new List<Student>();
        
        private void GetStudents(string group)
        {
            var students = new GetStudents();
            studentsOnGroup = students.GetByGroup(group);
        }

        double[] roundedExems = {0.0,0.0,0.0,0.0,0.0};

        public double[] GetExemsOnGroup(string group)
        {
            GetStudents(group);
            foreach (Student student in studentsOnGroup)
                for (int exem = 0; exem < 5; exem++)
                    roundedExems[exem] += int.Parse(student.Exems[exem].ToString());
            
            for (int roundIndex = 0; roundIndex < 5; roundIndex++)
                                            roundedExems[roundIndex] /= studentsOnGroup.Count;
            return roundedExems;
        }

        public List<StudentInfo>GetStudentInformationList(string group)
        {
            GetStudents(group);
            var info = new List<StudentInfo>();
            foreach(Student student in studentsOnGroup)
            {
                double mark = 0;
                int na = 0;
                for (int exem = 0; exem<5;exem++)
                {
                    if (student.Exems[exem].Equals('2'))
                        na++;
                    else
                        mark += int.Parse(student.Exems[exem].ToString());
                }
                mark /= 5.0;

                for (int score = 0; score<5;score++)
                  if (student.Scores[score].Equals('Н') || student.Scores[score].Equals('н'))
                     na++;

                info.Add(new StudentInfo(student.Surname, mark, na));
            }
            return info;
        }

        public int getDebtorsCount(string group)
        {
            var students = GetStudentInformationList(group);
            int count = 0;
            foreach (StudentInfo student in students)
                if (student.noAttistation > 0)
                    count++;
            return count;
        }
    }
}
