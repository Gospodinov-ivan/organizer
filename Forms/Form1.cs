using System;
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
    }
}
