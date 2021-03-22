using System;
using System.Windows.Forms;

namespace Organizer.Forms
{
    public partial class ShowDebtorsForm : Form
    {
        public ShowDebtorsForm()=>
            InitializeComponent();

        DabtorTable table = new DabtorTable();

        private void UpdateViews()
        {
            Students.Items.Clear();
            DabtorsData.Rows.Clear();
            GetInfo info = new GetInfo();
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

        private void ShowDebtorsForm_Load(object sender, EventArgs e)
        {
            UpdateViews();
        }
    }
}
