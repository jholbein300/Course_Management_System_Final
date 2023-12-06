using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Security.Principal;
using Course_Management_System_Final.Entity;

namespace Course_Management_System_Final.Control
{
    public class DBConnector
    {
        public static void InitializeDB()
        {
            using (SQLiteConnection conn = new SQLiteConnection(@"data source =..\..\Data\cManDb.db;Version=3"))
            {
                using (SQLiteCommand cmnd = new SQLiteCommand(@"data source =..\..\Data\cManDb.db;Version=3"))
                {
                    conn.Open();
                    cmnd.Connection = conn;
                    string strSql = @"BEGIN TRANSACTION; 
                    DROP TABLE IF EXISTS ACCOUNT;
                    DROP TABLE IF EXISTS LOG;
                    DROP TABLE IF EXISTS COURSE;
                    DROP TABLE IF EXISTS ENROLLMENT;
                    COMMIT;";
                    cmnd.CommandText = strSql;
                    cmnd.ExecuteNonQuery();
                    string table = @"CREATE TABLE [ACCOUNT] (
                                  [accountID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
                                , [username] TEXT NOT NULL
                                , [password] TEXT NOT NULL
                                , [role] TEXT NOT NULL
                                , [name] TEXT NOT NULL
                                );";
                    cmnd.CommandText = table;
                    cmnd.ExecuteNonQuery();
                    table = @"CREATE TABLE [LOG] (
                    [logID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
                    , [time] TEXT NOT NULL
                    , [event] TEXT NOT NULL
                    , [date] TEXT NOT NULL
                    , [accountNo] TEXT NOT NULL
                    , FOREIGN KEY([accountNo]) REFERENCES [ACCOUNT]([accountID])
                    );";
                    cmnd.CommandText = table;
                    cmnd.ExecuteNonQuery();
                    table = @"CREATE TABLE [COURSE] (
                    [ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
                    , [name] TEXT NOT NULL
                    , [instructor] INTEGER NOT NULL
                    , FOREIGN KEY([instructor]) REFERENCES [ACCOUNT]([accountID])
                    );";
                    cmnd.CommandText = table;
                    cmnd.ExecuteNonQuery();
                    table = @"CREATE TABLE [ENROLLMENT] (
                    [ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
                    , [courseID] INTEGER NOT NULL
                    , [studentID] INTEGER NOT NULL
                    , FOREIGN KEY([courseID]) REFERENCES [COURSE]([ID])
                    , FOREIGN KEY([studentID]) REFERENCES [ACCOUNT]([accountID])
                    );";
                    cmnd.CommandText = table;
                    cmnd.ExecuteNonQuery();
                    strSql = @"BEGIN TRANSACTION; 
                    INSERT INTO ACCOUNT (username, password, role, name) VALUES ($hashusr1, $hashpwd1, 'student', 'Ben Sheldon');
                    INSERT INTO ACCOUNT (username, password, role, name) VALUES ($hashusr2, $hashpwd2, 'instructor', 'Professor Robert');
                    INSERT INTO COURSE (name, instructor) VALUES ('CSCI 3020', 'Professor Robert');
                    INSERT INTO COURSE (name, instructor) VALUES ('MATH 1300', 'Professor Bob');
                    INSERT INTO ENROLLMENT (courseID, studentID) VALUES (1, 15);
                    INSERT INTO ENROLLMENT (courseID, studentID) VALUES (3, 2);
                    COMMIT;";
                    cmnd.CommandText = strSql;
                    string usrname1 = "student";
                    string pwd1 = "student";
                    string usrname2 = "instructor";
                    string pwd2 = "instructor";
                    int x = usrname1.GetHashCode();
                    int y = pwd1.GetHashCode();
                    int x1 = usrname2.GetHashCode();
                    int y1 = pwd2.GetHashCode();
                    cmnd.Parameters.AddWithValue("$hashusr1", x);
                    cmnd.Parameters.AddWithValue("$hashpwd1", y);
                    cmnd.Parameters.AddWithValue("$hashusr2", x1);
                    cmnd.Parameters.AddWithValue("$hashpwd2", y1);
                    cmnd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public Account GetUser(string usn, string pwd)
        {
            using (SQLiteConnection conn = new SQLiteConnection(@"data source =..\..\Data\cManDb.db;Version=3"))
            {
                conn.Open();
                int x = usn.GetHashCode();
                int y = pwd.GetHashCode();
                string stm = @"SELECT[accountID]
                        ,[username]
                        ,[password]
                        ,[role]
                        ,[name]
                        FROM[ACCOUNT]
                        WHERE[username] == ($name)
                        AND[password] == ($pd);";
                using (SQLiteCommand cmnd = new SQLiteCommand(stm, conn))
                {
                    cmnd.Parameters.AddWithValue("$name", x);
                    cmnd.Parameters.AddWithValue("$pd", y);
                    using (SQLiteDataReader rdr = cmnd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            Account acct = new Account(rdr.GetInt32(0), usn, pwd, rdr.GetString(3), rdr.GetString(4));
                            return acct;
                        }
                        Account act = new Account(0, null, null, null, null);
                        return act;
                    }
                }
                
            }
        }

        public List<Account> getList(string usn)
        {
            List<Account> acctList = new List<Account>();
           
            using (SQLiteConnection conn = new SQLiteConnection(@"data source =..\..\Data\cManDb.db;Version=3"))
            {
                conn.Open();

                int hash = usn.GetHashCode();
                string stm = @"SELECT[accountID]
                            ,[username]
                            ,[password]
                            ,[role]
                            ,[name]
                            FROM[ACCOUNT]
                            WHERE[username] == ($name)";
                using (SQLiteCommand com = new SQLiteCommand(stm, conn))
                {
                    com.Parameters.AddWithValue("$name", hash);
                    using (SQLiteDataReader rdr = com.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            Account acct = new Account(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4));
                            acctList.Add(acct);
                        }
                    }
                }
            }
            return acctList;
        }
        public List<Course> getClass(string usn)
        {
            List<Course> courList = new List<Course>();
            using (SQLiteConnection conn = new SQLiteConnection(@"data source =..\..\Data\cManDb.db;Version=3"))
            {
                conn.Open();

                int hash = usn.GetHashCode();
                string stm = @"SELECT[ID]
                            ,[name]
                            ,[instructor]
                            FROM[COURSE]
                            WHERE [ID] IN 
                            (SELECT [accountID] FROM [ACCOUNT] WHERE
                            [COURSE].[ID] == [accountID])";
                using (SQLiteCommand com = new SQLiteCommand(stm, conn))
                {
                    using (SQLiteDataReader rdr = com.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            Course cour = new Course(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2));
                            courList.Add(cour);
                        }
                    }
                }
            }
            return courList;
        }

        public List<Enrollment> getStudent(int courseId)
        {
            List<Enrollment> enList = new List<Enrollment>();

            using (SQLiteConnection conn = new SQLiteConnection(@"data source =..\..\Data\cManDb.db;Version=3"))
            {
                conn.Open();

                string stm = @"SELECT[ID]
                            ,[courseID]
                            ,[studentID]
                            FROM[ENROLLMENT]
                            WHERE [ID] IN (SELECT [accountID] FROM [ACCOUNT] WHERE [EROLLMENT].[ID] == [accountID])
                            AND (SELECT ID FROM COURSE where ENROLLMENT.ID == COURSE.ID)";
                using (SQLiteCommand com = new SQLiteCommand(stm, conn))
                {
                    using (SQLiteDataReader rdr = com.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            Enrollment enroll = new Enrollment(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetInt32(2));
                            enList.Add(enroll);
                        }
                    }
                }
            }
            return enList;
        }

        public void Save(Enrollment student)
        {
            List<Enrollment> enList = new List<Enrollment>();

            using (SQLiteConnection conn = new SQLiteConnection(@"data source =..\..\Data\cManDb.db;Version=3"))
            {
                conn.Open();

                string stm = @"SELECT[ID]
                            ,[courseID]
                            ,[studentID]
                            FROM[ENROLLMENT]
                            WHERE [ID] IN (SELECT [accountID] FROM [ACCOUNT] WHERE [ENROLLMENT].[ID] == [accountID])
                            AND (SELECT ID FROM COURSE where ENROLLMENT.ID == COURSE.ID)";
                using (SQLiteCommand cmnd = new SQLiteCommand(stm, conn))
                {
                    using (SQLiteDataReader rdr = cmnd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            Enrollment enrol = new Enrollment(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetInt32(2));
                            enList.Add(enrol);
                        }
                    }
                }
                stm = @"INSERT INTO LOG VALUES(0, 0, 0);";
                using (SQLiteCommand cmnd = new SQLiteCommand())
                {
                    cmnd.Connection = conn;
                    cmnd.CommandText = stm;
                    cmnd.ExecuteNonQuery();
                }
            }
        }

        public void SaveLogOut(string username)
        {
            using (SQLiteConnection conn = new SQLiteConnection(@"data source =..\..\Data\cManDb.db;Version=3"))
            {
                conn.Open();
                DateTime current = DateTime.Now;
                TimeSpan time = current.TimeOfDay;
                DateTime date = DateTime.Now.Date;
                string t = time.ToString("s");
                string d = date.ToString("s");
                int id = 0;
                int hash = username.GetHashCode();
                string stm = "SELECT [accountID] FROM ACCOUNT WHERE username = ($name);";
                using (SQLiteCommand cmnd = new SQLiteCommand(stm, conn))
                {
                    cmnd.Parameters.AddWithValue("$name", hash);
                    using (SQLiteDataReader rdr = cmnd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            id = rdr.GetInt32(0);
                        }
                    }
                }
                stm = @"INSERT INTO LOG VALUES(0, $time, 'logout', $date, $id);";
                using (SQLiteCommand cmnd = new SQLiteCommand())
                {
                    cmnd.Connection = conn;
                    cmnd.CommandText = stm;
                    cmnd.Parameters.AddWithValue("$time", t);
                    cmnd.Parameters.AddWithValue("$date", d);
                    cmnd.Parameters.AddWithValue("$id", id);
                    cmnd.ExecuteNonQuery();
                }
            }
        }

        public static void SaveLogin(string usn)
        
        {
            using (SQLiteConnection conn = new SQLiteConnection(@"data source =..\..\Data\cManDb.db;Version=3"))
            {
                conn.Open();
                DateTime current = DateTime.Now;
                TimeSpan time = current.TimeOfDay;
                DateTime date = DateTime.Now.Date;
                string t = time.ToString("s");
                string d = date.ToString("s");
                int id = 0;
                int hash = usn.GetHashCode();
                string stm = "SELECT [accountID] FROM ACCOUNT WHERE username = ($name);";
                using (SQLiteCommand cmnd = new SQLiteCommand(stm, conn))
                {
                    cmnd.Parameters.AddWithValue("$name", hash);
                    using (SQLiteDataReader rdr = cmnd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            id = rdr.GetInt32(0);
                        }
                    }
                }
                stm = @"INSERT INTO LOG VALUES(0, $time, 'login', $date, $id);";
                using (SQLiteCommand cmnd = new SQLiteCommand())
                {
                    cmnd.Connection = conn;
                    cmnd.CommandText = stm;
                    cmnd.Parameters.AddWithValue("$time", t);
                    cmnd.Parameters.AddWithValue("$date", d);
                    cmnd.Parameters.AddWithValue("$id", id);
                    cmnd.ExecuteNonQuery();
                }
            }
        }
        
        public string GetName(string usn, string pwd)
        {
            using (SQLiteConnection conn = new SQLiteConnection(@"data source =..\..\Data\cManDb.db;Version=3"))
            {
                conn.Open();
                int x = usn.GetHashCode();
                int y = pwd.GetHashCode();
                string stm = @"SELECT [name] FROM [ACCOUNT] WHERE [username] == ($name) AND [password] == ($pd);";
                using (SQLiteCommand cmnd = new SQLiteCommand(stm, conn))
                {
                    cmnd.Parameters.AddWithValue("$name", x);
                    cmnd.Parameters.AddWithValue("$pd", y);
                    using (SQLiteDataReader rdr = cmnd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            return rdr.GetString(0);
                        }
                    }
                    return null; // Return null if no matching user is found
                }
            }
        }
        
        public class SessionManager
        {
            private static SessionManager _instance;
            public static SessionManager Instance
            {
                get
                {
                    if (_instance == null)
                    {
                        _instance = new SessionManager();
                    }
                    return _instance;
                }
            }

            private string _loggedInUsername;

            public string LoggedInUsername
            {
                get { return _loggedInUsername; }
            }

            public void SetLoggedInUser(string username)
            {
                _loggedInUsername = username;
            }

            // Add other session-related properties or methods as needed
        }
    }
}
