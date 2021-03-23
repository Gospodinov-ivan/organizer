using System;
using System.Windows.Forms;

namespace Organizer.Forms
{
    public partial class UsersManagement : Form
    {
        public UsersManagement()=>
            InitializeComponent();
        
        private void UpdateViews()
        {
            UserLoginCh.Items.Clear();
                UserLoginDel.Items.Clear();
                    GetUserNames userNames = new GetUserNames();
                        var loginList = userNames.Get();
                            UserLoginCh.Items.AddRange(loginList.ToArray());
                                 UserLoginDel.Items.AddRange(loginList.ToArray());
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            if (Pass1.Text == Pass2.Text)
            {
                AddUser user = new AddUser();
                user.Add(Login.Text, Pass1.Text);
                UpdateViews();
            }
            else
                MessageBox.Show("Пароли не совпадают", "Ошибка");
        }

        private void ChangePass_Click(object sender, EventArgs e)
        {
            ValidateUser validate = new ValidateUser();
            if (validate.validate(UserLoginCh.Text, OldPass.Text) != 0)
            {
                UpdatePassword updatePassword = new UpdatePassword();
                updatePassword.update(UserLoginCh.Text, NewPass.Text);
                UpdateViews();
            }
            else
                MessageBox.Show("Убедитесь в правильности ввода логина" +
                    " и пароля и повторите попытку", "Ошибка");
        }

        private void DelUser_Click(object sender, EventArgs e)
        {
            if (UserLoginDel.Text != null|| UserLoginDel.Text!="")
            {
                DeleteUser deleteUser = new DeleteUser();
                deleteUser.Del(UserLoginDel.Text);
                UpdateViews();
            }

        }

        private void UsersManagement_Load(object sender, EventArgs e)
        {
            UpdateViews();
        }
    }
}
