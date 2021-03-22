using System;
using System.Windows.Forms;

namespace Organizer.Forms
{
    public partial class StudentsInfoForm : Form
    {
        public StudentsInfoForm()=>
            InitializeComponent();
        

        private void StudentsInfo_Load(object sender, EventArgs e)
        {
            GetGroupsList groups = new GetGroupsList();
                foreach(string group in groups.Get())
                                Groups.Items.Add(group);
        }

        private void Groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentsData.Rows.Clear();
            var info = new GetInfo();
            foreach (StudentInfo student in info.GetStudentInformationList(Groups.Text))
                StudentsData.Rows.Add(student.Surname, student.RoundedMark, student.NoAttistation);
            var roundedExems = info.GetExemsOnGroup(Groups.Text);
            D1.Text = roundedExems[0].ToString();
            D2.Text = roundedExems[1].ToString();
            D3.Text = roundedExems[2].ToString();
            D4.Text = roundedExems[3].ToString();
            D5.Text = roundedExems[4].ToString();
            debtors.Text = info.GetDebtorsCount(Groups.Text).ToString();
        }
    }
}
