using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Core_Inventaris
{
    public class Reposition
    {
        MySqlDataReader Reader;
        Connection Connetion = new Connection();

        public List<RepositionData> getData(string BranchOffice)
        {
            // function for get all employee data from database server
            
            List<RepositionData> RepositionDatas = new List<RepositionData>();
            if (BranchOffice.Length != 0)
            {
                Reader = Connetion.selectTable("select * from reposition where branchoffice = '" + BranchOffice + "' order by repositionDate");
            }
            else
            {
                Reader = Connetion.selectTable("select * from reposition order by repositionDate");
            }

            while (Reader.Read())
            {
                RepositionData RepositionData = new RepositionData();
                RepositionData.RepositionDate = int.Parse(Reader.GetString(0));
                RepositionData.EmployeeID = Reader.GetString(1);
                RepositionData.From = Reader.GetString(2);
                RepositionData.To = Reader.GetString(3);
                RepositionDatas.Add(RepositionData);
            }
            Reader.Close();

            return RepositionDatas;
        }

        public bool toServer()
        {
            // function for chekking connection to database server
            List<string> Database = Connetion.readSever();

            try
            {
                if (Connetion.connection(Database[0], Database[1], Database[2]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public string insertData(int RepositionDate, string EmployeeID, string From, string To, string BranchOffice)
        {
            // insert data query
            Reader = Connetion.selectTable("INSERT INTO reposition(RepositionDate, EmployeeID, FromOcc, ToOcc,BranchOffice) " +
                " VALUES (" + RepositionDate + ",'" + EmployeeID + "','" + From + "','" + To + "','" + BranchOffice + "')");
            Reader.Close();

            Reader = Connetion.selectTable("update Employee set Occupation = '"+ To +"' where ID = '"+ EmployeeID +"'");
            Reader.Close();
            return "Data Saved!";
        }

    }
}
