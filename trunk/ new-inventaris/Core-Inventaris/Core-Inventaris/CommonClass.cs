using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core_Inventaris
{
    public class InsuranceData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Contact { get; set; }
    }
    public class InsuranceTypeData
    {
        public string Id { get; set; }
        public string TypeName { get; set; }
        public string Explain { get; set; }
    }
    public class CarTypeData
    {
        public string Id { get; set; }
        public string TypeName { get; set; }
        public string Variant { get; set; }
    }

    public class EmployeeData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int BrithDate { get; set; }
        public string Address { get; set; }
        public int JoinDate { get; set; }
        public string Occupation { get; set; }
        public string BranchOffice { get; set; }
    }

    public class BranchOfficeData
    {
        public string Id { get; set; }
        public string BranchName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }

    public class OccupationData
    {
        public string Id { get; set; }
        public string OccupationName { get; set; }
        public string Explaination { get; set; }
    }

    public class EmployeeComplete
    {
        public List<EmployeeData> ED { get; set; }
        public List<OccupationData> OD { get; set; }
        public List<BranchOfficeData> BOD { get; set; }
    }

    public class RepositionData
    {
        public int RepositionDate { get; set; }
        public string EmployeeID { get; set; }
        public string From { get; set; }
        public string To { get; set; }
    }

    public class ReplacementData
    {
        public int ReplacementDate { get; set; }
        public string EmployeeID { get; set; }
        public string From { get; set; }
        public string To { get; set; }
    }
}
