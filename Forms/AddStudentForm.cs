using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer.Forms
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var add = new AddStudent();
            if (ExemsText.Text.Length == 5 &&
                Regex.Matches(ExemsText.Text, "[2-5]").Count==5 &&
                    ScoresText.Text.Length == 5 &&
                        Regex.Matches(ScoresText.Text, "[з,н,З,Н]").Count==5)
            {
                add.Add(new Student(
                            GroupText.Text,
                            SurnameText.Text,
                            ExemsText.Text,
                            ScoresText.Text));
                var form1 = (Form1)Application.OpenForms[0];
                    form1.UpdateData();
            }

            else
                MessageBox.Show("Проверьте правильность ввода" +
                    "в поля Зачеты и Экзамены и повторите попытку", "Ошибка");
        }
    }
}
