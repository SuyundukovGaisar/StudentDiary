using System.Collections.Generic;
using System.Data.SQLite;

namespace StudentDiary
{
    internal class DatabaseService
    {
        private string connectionString = "Data Source=StudentDiaryDB.db";

        public List<string[]> GetUsers()
        {
            List<string[]> usersList = new List<string[]>();

            using (SQLiteConnection sqliteCon = new SQLiteConnection(connectionString))
            {
                sqliteCon.Open();
                string query = "SELECT * FROM users";
                using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteCon))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usersList.Add(new string[] { reader["id"].ToString(), reader["login"].ToString(), reader["password"].ToString(), reader["role_id"].ToString() });
                        }
                    }
                }
            }

            return usersList;
        }
        public List<string[]> GetStudents()
        {
            List<string[]> studentsList = new List<string[]>();

            using (SQLiteConnection sqliteCon = new SQLiteConnection(connectionString))
            {
                sqliteCon.Open();
                string query = "SELECT * FROM students";
                using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteCon))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            studentsList.Add(new string[] { reader["id"].ToString(), reader["last_name"].ToString(), reader["first_name"].ToString(), reader["otchestvo"].ToString(), reader["email"].ToString(), reader["user_id"].ToString(), reader["group_id"].ToString() });
                        }
                    }
                }
            }

            return studentsList;
        }
        public List<string[]> GetExams()
        {
            List<string[]> examsList = new List<string[]>();

            using (SQLiteConnection sqliteCon = new SQLiteConnection(connectionString))
            {
                sqliteCon.Open();
                string query = "SELECT name_exam, date, time FROM exams";
                using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteCon))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            examsList.Add(new string[] { reader["name_exam"].ToString(), reader["date"].ToString(), reader["time"].ToString() });
                        }
                    }
                }
            }

            return examsList;
        }
        public List<string[]> GetGroups()
        {
            List<string[]> groupsList = new List<string[]>();

            using (SQLiteConnection sqliteCon = new SQLiteConnection(connectionString))
            {
                sqliteCon.Open();
                string query = "SELECT * FROM groups";
                using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteCon))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            groupsList.Add(new string[] { reader["id"].ToString(), reader["name"].ToString() });
                        }
                    }
                }
            }

            return groupsList;
        }
        public List<string[]> GetMarks()
        {
            List<string[]> marksList = new List<string[]>();

            using (SQLiteConnection sqliteCon = new SQLiteConnection(connectionString))
            {
                sqliteCon.Open();
                string query = "SELECT id, student_id, teacher_id, date, name_exam, mark_exam FROM marks";
                using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteCon))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            marksList.Add(new string[] { reader["id"].ToString(), reader["student_id"].ToString(), reader["teacher_id"].ToString(), reader["date"].ToString(), reader["name_exam"].ToString(), reader["mark_exam"].ToString() });
                        }
                    }
                }
            }

            return marksList;
        }
        public List<string[]> GetSchedule(string groupId = "0", string dayOfWeek = "0")
        {
            List<string[]> schedulesList = new List<string[]>();

            using (SQLiteConnection sqliteCon = new SQLiteConnection(connectionString))
            {
                sqliteCon.Open();
                string query = "SELECT * FROM schedule";
                switch (dayOfWeek)
                {
                    case "1":
                        query = $"SELECT * FROM schedule WHERE dayofweek = 1 AND group_id = '{int.Parse(groupId)}'";
                        break;
                    case "2":
                        query = $"SELECT * FROM schedule WHERE dayofweek = 2 AND group_id = '{int.Parse(groupId)}'";
                        break;
                    case "3":
                        query = $"SELECT * FROM schedule WHERE dayofweek = 3 AND group_id = '{int.Parse(groupId)}'";
                        break;
                    case "4":
                        query = $"SELECT * FROM schedule WHERE dayofweek = 4 AND group_id = '{int.Parse(groupId)}'";
                        break;
                    case "5":
                        query = $"SELECT * FROM schedule WHERE dayofweek = 5 AND group_id = '{int.Parse(groupId)}'";
                        break;
                }
                using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteCon))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            schedulesList.Add(new string[] { reader["id"].ToString(), reader["subject_id"].ToString(), reader["teacher_id"].ToString(), reader["group_id"].ToString(), reader["typeof_lesson"].ToString(), reader["start_time"].ToString(), reader["end_time"].ToString() });
                        }
                    }
                }
            }

            return schedulesList;
        }
        public List<string[]> GetMondaySchedule()
        {
            List<string[]> schedulesList = new List<string[]>();

            using (SQLiteConnection sqliteCon = new SQLiteConnection(connectionString))
            {
                sqliteCon.Open();
                string query = "SELECT * FROM schedule WHERE dayofweek = 1";
                using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteCon))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            schedulesList.Add(new string[] { reader["id"].ToString(), reader["subject_id"].ToString(), reader["teacher_id"].ToString(), reader["group_id"].ToString(), reader["typeof_lesson"].ToString(), reader["start_time"].ToString(), reader["end_time"].ToString() });
                        }
                    }
                }
            }

            return schedulesList;
        }
        public List<string[]> GetSubjects()
        {
            List<string[]> subjectsList = new List<string[]>();

            using (SQLiteConnection sqliteCon = new SQLiteConnection(connectionString))
            {
                sqliteCon.Open();
                string query = "SELECT name FROM subjects";
                using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteCon))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            subjectsList.Add(new string[] { reader["name"].ToString() });
                        }
                    }
                }
            }

            return subjectsList;
        }
        public List<string[]> GetTeachers()
        {
            List<string[]> teachersList = new List<string[]>();

            using (SQLiteConnection sqliteCon = new SQLiteConnection(connectionString))
            {
                sqliteCon.Open();
                string query = "SELECT * FROM teachers";
                using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteCon))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            teachersList.Add(new string[] { reader["id"].ToString(), reader["last_name"].ToString(), reader["first_name"].ToString(), reader["otchestvo"].ToString(), reader["subject_id"].ToString(), reader["user_id"].ToString() });
                        }
                    }
                }
            }

            return teachersList;
        }

    }
}
