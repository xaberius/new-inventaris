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
    public class CoreEngine
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

        public bool readSerialHardware()
        {
            bool SNBoard = false;
            bool ProcessorId = false;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard");
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor");

            ManagementObjectCollection information = searcher.Get();
            foreach (ManagementObject obj in information)
            {
                foreach (PropertyData data in obj.Properties)
                {
                    if (Convert.ToBase64String(Encoding.Unicode.GetBytes(data.Value.ToString())) == ini.IniReadValue("Genuine", "SNBoard"))
                    {
                        SNBoard = true;
                    }
                }
            }

            ManagementObjectCollection information2 = searcher2.Get();
            foreach (ManagementObject obj in information2)
            {
                foreach (PropertyData data in obj.Properties)
                {
                    if (Convert.ToBase64String(Encoding.Unicode.GetBytes(data.Value.ToString())) == ini.IniReadValue("Genuine", "ProcessorId"))
                    {
                        ProcessorId = true;
                    }
                }
            }
            searcher.Dispose();

            if (SNBoard && ProcessorId)
                return true;
            else
                return false;
        }

        public void writeSerialHardware()
        {
            // First we create the ManagementObjectSearcher that
            // will hold the query used.
            // The class Win32_BaseBoard (you can say table)
            // contains the Motherboard information.
            // We are querying about the properties (columns)
            // Product and SerialNumber.
            // You can replace these properties by
            // an asterisk (*) to get all properties (columns).
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard");
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor");

            // Executing the query...
            // Because the machine has a single Motherborad,
            // then a single object (row) returned.
            ManagementObjectCollection information = searcher.Get();
            foreach (ManagementObject obj in information)
            {
                // Retrieving the properties (columns)
                // Writing column name then its value
                foreach (PropertyData data in obj.Properties)
                {
                    //Console.WriteLine("{0} = {1}", data.Name, data.Value);
                    ini.IniWriteValue("Genuine", "SNBoard", Convert.ToBase64String(Encoding.Unicode.GetBytes(data.Value.ToString())));
                }
            }

            ManagementObjectCollection information2 = searcher2.Get();
            foreach (ManagementObject obj in information2)
            {
                // Retrieving the properties (columns)
                // Writing column name then its value
                foreach (PropertyData data in obj.Properties)
                {
                    ini.IniWriteValue("Genuine", "ProcessorId", Convert.ToBase64String(Encoding.Unicode.GetBytes(data.Value.ToString())));
                }
            }

            // For typical use of disposable objects
            // enclose it in a using statement instead.
            searcher.Dispose();
        }
    }
}
