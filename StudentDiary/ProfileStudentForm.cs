using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentDiary
{
    public partial class ProfileStudentForm : Form
    {
        public ProfileStudentForm(string studentId)
        {
            InitializeComponent();
            DatabaseService dbService = new DatabaseService();
            List<string[]> studentsList = dbService.GetStudents();
            List<string[]> usersList = dbService.GetUsers();
            foreach (var student in studentsList)
            {
                if (student[5] == studentId)
                {
                    NameStudentInfoLabel.Text = student[1] + " " + student[2] + " " + student[3];
                    EmaiStudentInfoLabel.Text = student[4];
                }
            }
            foreach (var user in usersList)
            {
                if (user[0] == studentId)
                {
                    PasswordStudentInfoLabel.Text = user[2];
                }
            }
        }
    }
}
