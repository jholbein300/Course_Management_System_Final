using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Security.Principal;

namespace Course_Management_System_Final
{
    public static class DBConnector
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
                    INSERT INTO COURSE (name, instructor) VALUES ('CSCI 3020', 'Robert');
                    INSERT INTO COURSE (name, instructor) VALUES ('MATH 1300', 'Bob');
                    INSERT INTO ENROLLMENT (courseID, studentID) VALUES (1, 15);
                    INSERT INTO ENROLLMENT (courseID, studentID) VALUES (3, 2);
                    COMMIT;";
                    cmnd.CommandText = strSql;
                    string usrname1 = "student@august.edu";
                    string pwd1 = "student123!";
                    string usrname2 = "instructor@augusta.edu";
                    string pwd2 = "instructor123!";
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

        public static Account GetUser(string usr, string pwd)
        {
            using (SQLiteConnection conn = new SQLiteConnection(@"data source =..\..\Data\cManDb.db;Version=3"))
            {
                conn.Open();
                int x = usr.GetHashCode();
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
                            Account acct = new Account(rdr.GetInt32(0), usr, pwd, rdr.GetString(3), rdr.GetString(4));
                            return acct;
                        }
                        Account act = new Account(0, null, null, null, null);
                        return act;
                    }
                }
            }
        }


        public static void SaveLog(string usr)
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
                int hash = usr.GetHashCode();
                string stm = "SELECT [ID] FROM ACCOUNT WHERE username = ($name);";
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
    }
}
