using System;
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
    public partial class ScheduleForm : Form
    {
        public ScheduleForm(string id, string dayOfWeek)
        {
            InitializeComponent();
            DatabaseService dbService = new DatabaseService();
            List<string[]> scheduleList = dbService.GetSchedule(id, dayOfWeek);
            List<string[]> groupsList = dbService.GetGroups();
            foreach (var schedule in scheduleList)
            {
                ScheduleGridView.Rows.Add(schedule);
            }
        }
    }
}
