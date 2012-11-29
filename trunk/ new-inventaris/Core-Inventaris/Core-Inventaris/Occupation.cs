using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Core_Inventaris
{
    public class Occupation
    {
        // variable definition
        Connection Connetion = new Connection();
        MySqlDataReader Reader;
        public List<OccupationData> getData()
        {
            // function for get all car type data from database server
            Reader = Connetion.selectTable("select * from Occupation order by id");

            List<OccupationData> InsDatas = new List<OccupationData>();
            while (Reader.Read())
            {
                OccupationData InsData = new OccupationData();
                InsData.Id = Reader.GetString(0);
                InsData.OccupationName = Reader.GetString(1);
                InsData.Explaination = Reader.GetString(2);
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
            Reader = Connetion.selectTable("Delete from Occupation where id='" + ID + "'");
            Reader.Close();
            return "Deleted!";
        }

        public string insertData(string ID,string OccupationName,string Explaination)
        {
            // insert data query
            Reader = Connetion.selectTable("insert into Occupation (id,OccupationName,Explaination) values ('" + ID + "','" +
                OccupationName + "','" + Explaination + "')");
            Reader.Close();
            return "Data Saved!";
        }

        public string updatetData(string ID,string OccupationName,string Explaination)
        {
            // update data query
            Reader = Connetion.selectTable("update Occupation set OccupationName = '" + OccupationName + "', Explaination='" + Explaination + 
                    "' where id = '" + ID + "'");
            Reader.Close();
            return "Data Update!";
        }
    }
    
}
