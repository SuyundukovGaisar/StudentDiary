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
        public MainMenuStudentForm()
        {
            InitializeComponent();
            DatabaseService dbService = new DatabaseService();
            List<string[]> studentsList = dbService.GetStudents();
            foreach (var student in studentsList)
            {
                NameMenuLabel.Text = student[0] + " " + student[1] + " " + student[2];
            }
            List<string[]> groupsList = dbService.GetGroups();
            foreach (var group in groupsList)
            {
                GroupMainMenuStudentLabel.Text = group[0];
            }
        }

        private void Profilebutton_Click(object sender, EventArgs e)
        {
            ProfileStudentForm profileStudentForm = new ProfileStudentForm();
            profileStudentForm.Show();
        }


    }
}