using System.Collections.Generic;
using System.Data.Entity.Hierarchy;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System;


namespace StudentDiary
{
    public partial class ExamStudentForm : Form
    {
        public ExamStudentForm(string id)
        {
            InitializeComponent();
            DatabaseService dbService = new DatabaseService();
            List<string[]> marksList = dbService.GetMarks();
            foreach (string[] mark in marksList)
            {
                if (mark[1] == id)
                {
                    ExamStudentGridView.Rows.Add(mark);
                }
            }
        }
    }
}
