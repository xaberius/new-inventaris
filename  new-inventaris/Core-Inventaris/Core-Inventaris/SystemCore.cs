using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace Core_Inventaris
{
    public class SystemCore
    {
        INIFile ini = new INIFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\new-inventaris.ini");

        public DateTime TimestampToLocal(int? timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            if (timestamp.HasValue)
            {
                //Console.WriteLine("before tolocal {0}, after tolocal {1}", origin.AddSeconds((double)timestamp), origin.AddSeconds((double)timestamp).ToLocalTime());
                return origin.AddSeconds((double)timestamp).ToLocalTime();
            }
            else
                return origin;
        }


        public int LocalToTimestamp(DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return (int)Math.Floor(diff.TotalSeconds);
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
