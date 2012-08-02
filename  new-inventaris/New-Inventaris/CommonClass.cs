using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace New_Inventaris
{
    class CommonClass
    {
        
    }

    public class Connect
    {
        public string Server { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class Insurance
    {
        public string Id{ get; set; }
        public string InsuranceName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Contact { get; set; }
    }


}
