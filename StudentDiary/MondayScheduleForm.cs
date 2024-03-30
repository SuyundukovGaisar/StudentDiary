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
    public partial class MondayScheduleForm : Form
    {
        public MondayScheduleForm(string id)
        {
            InitializeComponent();
            DatabaseService dbService = new DatabaseService();
            List<string[]> scheduleList = dbService.GetSchedule();
            List<string[]> groupsList = dbService.GetGroups();
            foreach (var schedule in scheduleList)
            {
                if (schedule[5] == "1")
                {
                    foreach (var group in groupsList)
                    {
                        if (schedule[3] == id)
                        {
                            MondayScheduleGridView.Rows.Add(schedule);
                        }
                    }
                    
                }

            }
        }
    }
}
