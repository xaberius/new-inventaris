using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Core_Inventaris;
using System.Windows.Forms;

namespace Core_Inventaris
{
    public class CartType
    {
        // variable definition
        Connection Connetion = new Connection();
        MySqlDataReader Reader;
        public List<CarTypeData> getData()
        {
            // function for get all car type data from database server
            Reader = Connetion.selectTable("select * from carType order by id");

            List<CarTypeData> InsDatas = new List<CarTypeData>();
            while (Reader.Read())
            {
                CarTypeData InsData = new CarTypeData();
                InsData.Id = Reader.GetString(0);
                InsData.TypeName = Reader.GetString(1);
                InsData.Variant = Reader.GetString(2);
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
            Reader = Connetion.selectTable("Delete from carType where id='" + ID + "'");
            Reader.Close();
            return "Deleted!";
        }

        public string insertData(string ID,string TypeName,string Variant)
        {
            // insert data query
            Reader = Connetion.selectTable("insert into carType (id,typename,variant) values ('" + ID + "','" +
                TypeName + "','" + Variant + "')");
            Reader.Close();
            return "Data Saved!";
        }

        public string updatetData(string ID, string TypeName, string Variant)
        {
            // update data query
            Reader = Connetion.selectTable("update carType set typename = '" + TypeName + "', variant='" + Variant + 
                    "' where id = '" + ID + "'");
            Reader.Close();
            return "Data Update!";
        }
    }
}
