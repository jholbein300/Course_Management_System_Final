using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Management_System_Final.Entity
{
    public class Account
    {
        private int id;
        private string username;
        private string password;
        private string role;
        private string name;

        public Account(int accountID, string username, string password, string role, string name)
        {
            this.id = accountID;
            this.username = username;
            this.password = password;
            this.role = role;
            this.name = name;
        }

        public int getId() { return id; }
        public string getUsername() { return username; }
        public string getPassword() { return password; }
        public string getRole() { return role; }
        public string getName() { return name; }
        public void setId(int accountID) { this.id = accountID; }
        public void setUsername(string username) { this.username = username;}
        public void setPassword(string password) {  this.password = password;}
        public void setRole(string role) {  this.role = role;}
        public void setName(string name) { this.name = name;}
    }
}
