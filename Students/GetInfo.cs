using System;
using System.Collections.Generic;

namespace Organizer
{
    /// <summary>
    /// Предоставляет информацию об успеваемости студентов
    /// </summary>
    class GetInfo
    {
        List<Student> studentsOnGroup = new List<Student>();
        double[] roundedExems = { 0.0, 0.0, 0.0, 0.0, 0.0 };

        //поиск студентов по указанной группе
        private void GetStudents(string group)
        {
            var students = new GetStudents();
            studentsOnGroup = students.GetByGroup(group);
        }
        
        /// <summary>
        /// Производит рассчёт средней оценки по результатам атестации группы
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
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
        /// <summary>
        /// производит рассчет количества неаттестаций и средней 
        /// оценки конкретных студентов группы 
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
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
        /// <summary>
        /// производит поиск задолжников
        /// и возвращает их фамилии группы и 
        /// количество задолженностей
        /// </summary>
        /// <returns></returns>
        public List<StudentInfo> GetDebtorsList()
        {
            var allStudents = new GetStudents();
            var studentsList = allStudents.GetAll();
            var dabtors = new List<StudentInfo>();
            foreach (Student student in studentsList)
            {
                int na = 0;
                for (int exem = 0; exem < 5; exem++)
                    if (student.Exems[exem].Equals('2'))
                        na++;
                
                for (int score = 0; score < 5; score++)
                    if (student.Scores[score].Equals('Н') || student.Scores[score].Equals('н'))
                        na++;
                if(na>=1)
                   dabtors.Add(new StudentInfo(student.ID,student.Group,student.Surname,na));
            }
            return dabtors;
        }
        /// <summary>
        /// производит рассчет количества задолженников группы
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public int GetDebtorsCount(string group)
        {
            var students = GetStudentInformationList(group);
            int count = 0;
            foreach (StudentInfo student in students)
                if (student.NoAttistation > 0)
                    count++;
            return count;
        }
    }
}
