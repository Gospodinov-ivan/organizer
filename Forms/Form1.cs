using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Organizer.Forms;

namespace Organizer
{
    public partial class Form1 : Form
    {
        public Form1()=>
            InitializeComponent();
        

        private void Form1_Load(object sender, EventArgs e)
        {
            Visible = false;
            LoginForm loginForm = new LoginForm
            {
                TopMost = true
            };

            loginForm.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            UpdateData();
        }
        
        public void UpdateData()
        {
            StudentsDataGrid.Rows.Clear();
                GetStudents students = new GetStudents();
                    foreach (Student student in students.GetAll())
                        StudentsDataGrid.Rows.Add(student.ID,
                                                student.Group,
                                                 student.Surname,
                                                    student.Exems,
                                                     student.Scores);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var studentsTable = new List<Student>();
            
            for(var tableRow = 0; tableRow<StudentsDataGrid.Rows.Count-1; tableRow++)
            {
                var row = StudentsDataGrid.Rows[tableRow];
                studentsTable.Add(new Student(
                                       (int)row.Cells[0].Value,
                                       (string)row.Cells[1].Value,
                                       (string)row.Cells[2].Value,
                                       (string)row.Cells[3].Value,
                                       (string)row.Cells[4].Value));
            }
            UpdateStudentsTable table = new UpdateStudentsTable();
            table.Update(studentsTable);
            UpdateData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (StudentsDataGrid.SelectedRows.Count == 1)
            {
                DelStudent del = new DelStudent();
                del.Del(Convert.ToInt32(StudentsDataGrid.SelectedRows[0].Cells[0].Value));
                UpdateData();
            }
            else
                MessageBox.Show("Выберите конкретного пользователя", "Ошибка удаления"); 
           
        }

        private void StudentsInfo_Click(object sender, EventArgs e)
        {
            StudentsInfoForm studentsInfo = new StudentsInfoForm();
            studentsInfo.Show();
        }
    }
}
