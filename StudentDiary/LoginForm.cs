using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDiary
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string enteredLogin = LoginTextBox.Text;
            string enteredPassword = PasswordTextBox.Text;

            DatabaseService dbService = new DatabaseService();
            List<string[]> usersList = dbService.GetUsers();

            foreach (var user in usersList)
            {
                
                if (user[1] == enteredLogin && user[2] == enteredPassword)
                {
                    string id = user[0];
                    if (user[3] == "1")
                    {
                        MainMenuTeacherForm mainMenuTeacherForm = new MainMenuTeacherForm();
                        mainMenuTeacherForm.Show();
                    }
                    else
                    {
                        MainMenuStudentForm mainMenuStudent = new MainMenuStudentForm(id);
                        mainMenuStudent.Show();
                    }
                    return;
                }
            }

            MessageBox.Show("Вы неправильно ввели логин или пароль!", "Ошибка");

        }
    }
}
