using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Organizer
{
    public partial class LoginForm : Form
    {
        public LoginForm()=>
            InitializeComponent();
        
        private void LogInButton_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            var cmdText = $"SELECT * FROM Users WHERE " +
                                      $"Login = '{LoginText.Text}' and " +
                                      $"Password = '{PasswordText.Text}'";
            var command = new OleDbCommand(cmdText, connection.GetConnection());
            var finded = command.ExecuteReader().HasRows;
            if (finded)
            {
                Form1 mainForm = (Form1)Application.OpenForms[0];
                mainForm.Visible = true;
                Close();
            }
            else MessageBox.Show("Не верный логин или пароль", "Ошибка ввода");
           
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
