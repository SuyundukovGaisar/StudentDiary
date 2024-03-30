using System.Collections.Generic;
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
            foreach (var schedule in scheduleList)
            {
                ScheduleGridView.Rows.Add(schedule);
            }
        }
    }
}
