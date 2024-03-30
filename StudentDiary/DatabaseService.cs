using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                            examsList.Add(new string[] { reader["name_exam"].ToString(), reader["date"].ToString(), reader["time"].ToString()});
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
                string query = "SELECT date, name_exam, mark_exam FROM marks";
                using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteCon))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            marksList.Add(new string[] { reader["date"].ToString(), reader["name_exam"].ToString(), reader["mark_exam"].ToString() });
                        }
                    }
                }
            }

            return marksList;
        }
        public List<string[]> GetSchedule()
        {
            List<string[]> schedulesList = new List<string[]>();

            using (SQLiteConnection sqliteCon = new SQLiteConnection(connectionString))
            {
                sqliteCon.Open();
                string query = "SELECT * FROM schedule";
                using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteCon))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            schedulesList.Add(new string[] { reader["id"].ToString(), reader["subject_id"].ToString(), reader["teacher_id"].ToString(), reader["group_id"].ToString(), reader["typeof_lesson"].ToString(), reader["dayofweek"].ToString(), reader["start_time"].ToString(), reader["end_time"].ToString() });
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

    }
}
