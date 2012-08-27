using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Core_Inventaris;
using System.Windows.Forms;

namespace Core_Inventaris
{
    public class Insurance
    {
        Connection Connetion = new Connection();
        public List<InsuranceData> getData()
        {
            MySqlDataReader Reader;
            Reader = Connetion.selectTable("select * from insurance");
           
            List<InsuranceData> InsDatas = new List<InsuranceData>();
            while (Reader.Read())
            {
                InsuranceData InsData = new InsuranceData();
                InsData.Id = Reader.GetString(0);
                InsData.Name = Reader.GetString(1);
                InsData.Address = Reader.GetString(2);
                InsData.City = Reader.GetString(3);
                InsData.Phone = Reader.GetString(4);
                InsData.Contact = Reader.GetString(5);
                InsDatas.Add(InsData);
            }
            return InsDatas;
        }

        public void toServer()
        {
            List<string> Database = Connetion.readSever();

            if (!Connetion.connection(Database[0], Database[1], Database[2]))
            {
                MessageBox.Show("Database disconnect. Please contact your administrator.", "Database",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
