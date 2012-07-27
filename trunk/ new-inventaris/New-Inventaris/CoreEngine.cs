using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Management;

namespace New_Inventaris
{
    class CoreEngine
    {
        INIFile ini = new INIFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\new-inventaris.ini");
        private Connect con = new Connect();

        public Connect readSever()
        {
            // read server,username and password database server form file ini.
            string server = ini.IniReadValue("Setting", "Server");
            string user = ini.IniReadValue("Setting", "UserName");
            string pass = ini.IniReadValue("Setting", "Password");

            if (server != "" && user != "" && pass != "")
            {
                con.Server = Encoding.Unicode.GetString(Convert.FromBase64String(server));
                con.UserName = Encoding.Unicode.GetString(Convert.FromBase64String(user));
                con.Password = Encoding.Unicode.GetString(Convert.FromBase64String(pass));
                return con;
            }
            else
            {
                MessageBox.Show("Server not specified.");
                return con;
            }
        }

        public void writeServer(string Server, string UserName, string password)
        {
            // write server,username and password to file ini.
            ini.IniWriteValue("Setting", "Server", Convert.ToBase64String(Encoding.Unicode.GetBytes(Server)).ToString());
            ini.IniWriteValue("Setting", "UserName", Convert.ToBase64String(Encoding.Unicode.GetBytes(UserName)));
            ini.IniWriteValue("Setting", "Password", Convert.ToBase64String(Encoding.Unicode.GetBytes(password)));
            Console.WriteLine("lala lila ; "+ Convert.ToBase64String(Encoding.Unicode.GetBytes(Server)));
        }

        public string konek(string text)
        {
            // test connection to database server
            MySqlConnection db = new MySqlConnection(text);
            try
            {
                db.Open();
                return "a";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public void coba()
        {
            // First we create the ManagementObjectSearcher that
            // will hold the query used.
            // The class Win32_BaseBoard (you can say table)
            // contains the Motherboard information.
            // We are querying about the properties (columns)
            // Product and SerialNumber.
            // You can replace these properties by
            // an asterisk (*) to get all properties (columns).
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Product, SerialNumber FROM Win32_BaseBoard");

            // Executing the query...
            // Because the machine has a single Motherborad,
            // then a single object (row) returned.
            ManagementObjectCollection information = searcher.Get();
            foreach (ManagementObject obj in information)
            {
                // Retrieving the properties (columns)
                // Writing column name then its value
                foreach (PropertyData data in obj.Properties)
                    Console.WriteLine("{0} = {1}", data.Name, data.Value);
                Console.WriteLine();
            }

            // For typical use of disposable objects
            // enclose it in a using statement instead.
            searcher.Dispose();
        }
    }
}
