using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentDiary
{
    public partial class MainMenuStudentForm : Form
    {
        public string groupId;
        public string studentId;
        public MainMenuStudentForm(string id)
        {
            InitializeComponent();
            DatabaseService dbService = new DatabaseService();
            List<string[]> studentsList = dbService.GetStudents();
            List<string[]> groupsList = dbService.GetGroups();

            foreach (var student in studentsList)
            {
                if (student[5] == id)
                {
                    studentId = id;
                    NameMenuLabel.Text = student[1] + " " + student[2] + " " + student[3];
                    foreach (var group in groupsList)
                    {
                        if (student[6] == group[0])
                        {
                            groupId = student[6];
                            GroupMainMenuStudentLabel.Text = "Номер группы: " + group[1];
                        }
                    }
                }
            }
        }

        private void Profilebutton_Click(object sender, EventArgs e)
        {
            ProfileStudentForm profileStudentForm = new ProfileStudentForm(studentId);
            profileStudentForm.Show();
        }

        private void Mondaybutton_Click(object sender, EventArgs e)
        {
            ScheduleForm scheduleForm = new ScheduleForm(groupId, "1");
            scheduleForm.Show();
        }
        private void Tuesdaybutton_Click(object sender, EventArgs e)
        {
            ScheduleForm scheduleForm = new ScheduleForm(groupId, "2");
            scheduleForm.Show();
        }
        private void Wednesdaybutton_Click(object sender, EventArgs e)
        {
            ScheduleForm scheduleForm = new ScheduleForm(groupId, "3");
            scheduleForm.Show();
        }
        private void Thursdaybutton_Click(object sender, EventArgs e)
        {
            ScheduleForm scheduleForm = new ScheduleForm(groupId, "4");
            scheduleForm.Show();
        }
        private void Fridaybutton_Click(object sender, EventArgs e)
        {
            ScheduleForm scheduleForm = new ScheduleForm(groupId, "5");
            scheduleForm.Show();
        }

        private void Examsbutton_Click(object sender, EventArgs e)
        {
            ExamStudentForm examStudentForm = new ExamStudentForm(studentId);
            examStudentForm.Show();
        }
    }
}
