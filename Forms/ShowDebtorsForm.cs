using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Organizer.Forms
{
    public partial class ShowDebtorsForm : Form
    {
        public ShowDebtorsForm()=>
            InitializeComponent();

        DabtorTable table = new DabtorTable();
        GetInfo info = new GetInfo();
        Form1 main = (Form1)Application.OpenForms[0];

        private void UpdateViews()
        {
            Students.Items.Clear();
            DabtorsData.Rows.Clear();
            var dabtors = info.GetDebtorsList();
            foreach (StudentInfo student in dabtors)
            {
                DabtorsData.Rows.Add(student.ID,
                                     student.Group,
                                     student.Surname,
                                     student.NoAttistation);
                Students.Items.Add(student.Surname);
            }
            table.Create(info.GetDebtorsList());
        }

        private void SortByGroup_Click(object sender, EventArgs e)
        {
            DabtorsData.Rows.Clear();
             var sorted = table.sortBy("Группа");
                 foreach (StudentInfo student in sorted)
                    DabtorsData.Rows.Add(student.ID,
                                        student.Group,
                                            student.Surname,
                                                student.NoAttistation);
        }

        private void SortBySurname_Click(object sender, EventArgs e)
        {
            DabtorsData.Rows.Clear();
                var sorted = table.sortBy("Фамилия");
                    foreach (StudentInfo student in sorted)
                        DabtorsData.Rows.Add(student.ID,
                                                student.Group,
                                                    student.Surname,
                                                        student.NoAttistation);
        }

        private void SortByDebt_Click(object sender, EventArgs e)
        {
            DabtorsData.Rows.Clear();
                var sorted = table.sortBy("Задолженности");
                    foreach (StudentInfo student in sorted)
                        DabtorsData.Rows.Add(student.ID,
                                                student.Group,
                                                    student.Surname,
                                                        student.NoAttistation);
        }

        private void ShowDebtorsForm_Load(object sender, EventArgs e)=>
                                                                 UpdateViews();
        

        private void ChangeExem_Click(object sender, EventArgs e)
        {
            GetStudents students = new GetStudents();

            if (Students.Text.Length != 0)
            {
                int subject = Subject.SelectedIndex;
                string studentSurname = Students.Text;
                string mark = Mark.Text;
                var student = students.getConcrete(studentSurname)[0];
                string newMark = "";
                for(int markIndex = 0; markIndex<5;markIndex++)
                    if (markIndex == subject)
                        newMark += mark;
                    else
                        newMark += student.Exems[markIndex];
                

                Student updated = new Student(student.ID,
                                                 student.Group,
                                                    student.Surname,
                                                       newMark,
                                                         student.Scores);

                UpdateStudentsTable update = new UpdateStudentsTable();
                List<Student> students1 = new List<Student>{updated};
                update.Update(students1);
                main.UpdateData();
                UpdateViews();
            }

        }

        private void DelStudents_Click(object sender, EventArgs e)
        {
            DelStudent del = new DelStudent();
            foreach (StudentInfo student in info.GetDebtorsList())
                if (student.NoAttistation >= 3) del.Del(student.ID);
            
            main.UpdateData();
                UpdateViews();
        }
    }
}
