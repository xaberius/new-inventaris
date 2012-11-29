using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Core_Inventaris
{
    public class Employee
    {
        // variable definition
        Connection Connetion = new Connection();
        SystemCore SystemCorex = new SystemCore();
        MySqlDataReader Reader;
        public EmployeeComplete getData()
        {
            // function for get all employee data from database server
            EmployeeComplete EmployeeComplete = new EmployeeComplete();
            
            //Employ data
            List<EmployeeData> EmployeeDatas = new List<EmployeeData>();
            Reader = Connetion.selectTable("select * from Employee order by id");
            
            while (Reader.Read())
            {
                EmployeeData EmployeeData = new EmployeeData();
                EmployeeData.Id = Reader.GetString(0);
                EmployeeData.Name = Reader.GetString(1);
                EmployeeData.BrithDate = int.Parse(Reader.GetString(2));
                EmployeeData.Address = Reader.GetString(3);
                EmployeeData.JoinDate = int.Parse(Reader.GetString(4));
                EmployeeData.Occupation = Reader.GetString(5);
                EmployeeData.BranchOffice = Reader.GetString(6);
                EmployeeDatas.Add(EmployeeData);
            }
            Reader.Close();

            //Occupation
            List<OccupationData> OccupationDatas = new List<OccupationData>();
            Reader = Connetion.selectTable("select * from Occupation order by id");
            
            while (Reader.Read())
            {
                OccupationData OccupationData = new OccupationData();
                OccupationData.Id = Reader.GetString(0);
                OccupationData.OccupationName = Reader.GetString(1);
                OccupationData.Explaination = Reader.GetString(2);
                OccupationDatas.Add(OccupationData);
            }
            Reader.Close();

            //Branch office data
            List<BranchOfficeData> BranchOfficeDatas = new List<BranchOfficeData>();
            Reader = Connetion.selectTable("select * from branchoffice order by id");
           
            while (Reader.Read())
            {
                BranchOfficeData BranchOfficeData = new BranchOfficeData();
                BranchOfficeData.Id = Reader.GetString(0);
                BranchOfficeData.BranchName = Reader.GetString(1);
                BranchOfficeData.Address = Reader.GetString(2);
                BranchOfficeData.Phone = Reader.GetString(3);
                BranchOfficeDatas.Add(BranchOfficeData);
            }
            Reader.Close();

            EmployeeComplete.ED = EmployeeDatas;
            EmployeeComplete.OD = OccupationDatas;
            EmployeeComplete.BOD = BranchOfficeDatas;

            return EmployeeComplete;
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
            Reader = Connetion.selectTable("Delete from Employee where id='" + ID + "'");
            Reader.Close();
            return "Deleted!";
        }

        public string insertData(string ID, string Name, int BirthDate, string Address, int JoinDate, string Occupation, string BranchOfiice)
        {
            // insert data query
            Reader = Connetion.selectTable("INSERT INTO employee(ID, Name, BirthDate, Address, JoinDate, Occupation, BranchOffice) VALUES ('" + ID +
                        "','" + Name + "'," + BirthDate + ",'" + Address + "'," + JoinDate + ",'" + Occupation + "','" + BranchOfiice + "')");
            Reader.Close();
            return "Data Saved!";
        }

        public string updatetData(string ID, string Name, int BirthDate, string Address)
        {
            // update data query
            Reader = Connetion.selectTable("update Employee set Name = '" + Name + "', BirthDate='" + BirthDate + 
                    "', address = '" + Address + "' where id = '" + ID + "'");
            Reader.Close();
            return "Data Update!";
        }
    }
    
}
