﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDiary
{
    public partial class MainMenuStudentForm : Form
    {
        public string groupId;
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
                    NameMenuLabel.Text = student[1] + " " + student[2] + " " + student[3];
                    groupId = student[6];
                    GroupMainMenuStudentLabel.Text = student[6];
                }
                
            }
            
            
        }

        private void Profilebutton_Click(object sender, EventArgs e)
        {
            ProfileStudentForm profileStudentForm = new ProfileStudentForm();
            profileStudentForm.Show();
        }

        private void Mondaybutton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
