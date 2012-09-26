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
}
