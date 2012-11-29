using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Core_Inventaris
{
    public class Replacement
    {
        MySqlDataReader Reader;
        Connection Connetion = new Connection();

        public List<ReplacementData> getData(string BranchOffice)
        {
            // function for get all employee data from database server

            List<ReplacementData> ReplacementDatas = new List<ReplacementData>();
            if (BranchOffice.Length != 0)
            {
                Reader = Connetion.selectTable("select * from replacement where ToOffice = '" + BranchOffice + "' order by replacementDate");
            }
            else
            {
                Reader = Connetion.selectTable("select * from replacement order by replacementDate");
            }

            while (Reader.Read())
            {
                ReplacementData ReplacementData = new ReplacementData();
                ReplacementData.ReplacementDate = int.Parse(Reader.GetString(0));
                ReplacementData.EmployeeID = Reader.GetString(1);
                ReplacementData.From = Reader.GetString(2);
                ReplacementData.To = Reader.GetString(3);
                ReplacementDatas.Add(ReplacementData);
            }
            Reader.Close();

            return ReplacementDatas;
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

        public string insertData(int ReplacementDate, string EmployeeID, string From, string To)
        {
            // insert data query
            Reader = Connetion.selectTable("INSERT INTO replacement(ReplacementDate, EmployeeID, FromBO, ToBO,) " +
                " VALUES (" + ReplacementDate + ",'" + EmployeeID + "','" + From + "','" + To + "')");
            Reader.Close();

            Reader = Connetion.selectTable("update Employee set BranchOffice = '"+ To +"' where ID = '"+ EmployeeID +"'");
            Reader.Close();
            return "Data Saved!";
        }

    }
    
}
