using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Core_Inventaris
{
    public class BranchOffice
    {
        // variable definition
        Connection Connetion = new Connection();
        MySqlDataReader Reader;
        public List<BranchOfficeData> getData()
        {
            // function for get all insurance data from database server
            Reader = Connetion.selectTable("select * from branchoffice order by id");
            
            List<BranchOfficeData> InsDatas = new List<BranchOfficeData>();
            while (Reader.Read())
            {
                BranchOfficeData InsData = new BranchOfficeData();
                InsData.Id = Reader.GetString(0);
                InsData.BranchName = Reader.GetString(1);
                InsData.Address = Reader.GetString(2);
                InsData.Phone = Reader.GetString(3);
                InsDatas.Add(InsData);
            }
            Reader.Close();
            return InsDatas;
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
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public string deleteData(string ID)
        {
            // delete query
            Reader = Connetion.selectTable("Delete from branchoffice where id='" + ID + "'");
            Reader.Close();
            return "Deleted!";
        }

        public string insertData(string ID,string BranchName,string Address, string Phone)
        {
            // insert data query
            Reader = Connetion.selectTable("insert into branchoffice (id,BranchName,address,phone) values ('" + ID + "','" +
                BranchName + "','" + Address + "','" + Phone +"')");
            Reader.Close();
            return "Data Saved!";
        }

        public string updatetData(string ID,string BranchName,string Address, string Phone)
        {
            // update data query
            Reader = Connetion.selectTable("update branchoffice set BranchName = '"+ BranchName +"', address='"+ Address +
                "',phone = '"+ Phone +"' where id = '" + ID + "'");
            Reader.Close();
            return "Data Update!";
        }
    }
   
}
