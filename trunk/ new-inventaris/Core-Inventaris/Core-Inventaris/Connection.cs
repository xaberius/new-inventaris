using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Management;

namespace Core_Inventaris
{
    public class Connection
    {
        private string Server;
        private string Password;
        private string UserName;

        MySqlConnection DbCon = new MySqlConnection();
        MySqlCommand Cmd = new MySqlCommand();
        MySqlDataReader Reader;

        INIFile ini = new INIFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\new-inventaris.ini");

        public MySqlDataReader selectTable(string SQL)
        {
            // function for execute a sql
            this.Cmd = DbCon.CreateCommand();
            Cmd.CommandText = SQL;
            this.Reader = Cmd.ExecuteReader();            
            return this.Reader;
        }

        public bool connection(string Server, string UserName, string Password)
        {
            // function for connect database server
            this.Server = Server;
            this.UserName = UserName;
            this.Password = Password;
            string Text = "server=" + this.Server + ";database=new-inventaris;  uid=" + this.UserName + ";password=" + this.Password + ";";

            return status(Text);
        }

        public void writeServer(string Server, string UserName, string password)
        {
            // write server,username and password to file ini.
            ini.IniWriteValue("Setting", "Server", Convert.ToBase64String(Encoding.Unicode.GetBytes(Server)).ToString());
            ini.IniWriteValue("Setting", "UserName", Convert.ToBase64String(Encoding.Unicode.GetBytes(UserName)));
            ini.IniWriteValue("Setting", "Password", Convert.ToBase64String(Encoding.Unicode.GetBytes(password)));
        }

        public List<string> readSever()
        {
            // function for reada data of database server
            List<string> Database = new List<string>();
            // read server,username and password database server form file ini.
            string server = ini.IniReadValue("Setting", "Server");
            string user = ini.IniReadValue("Setting", "UserName");
            string pass = ini.IniReadValue("Setting", "Password");

            if (server != "" && user != "" && pass != "")
            {
                Database.Add(Encoding.Unicode.GetString(Convert.FromBase64String(server)));
                Database.Add(Encoding.Unicode.GetString(Convert.FromBase64String(user)));
                Database.Add(Encoding.Unicode.GetString(Convert.FromBase64String(pass)));
                return Database;
            }
            else
            {
                return Database;
            }
        }

        public bool status(string Server)
        {
            // function for check connection to database server
            DbCon.ConnectionString = Server;
            if (DbCon.State == System.Data.ConnectionState.Closed)
            {
                DbCon.Open();
                return true;
            }
            else
            {
                DbCon.Close();
                return false;
            }
        }        
    }
}
