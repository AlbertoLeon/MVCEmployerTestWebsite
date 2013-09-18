using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployerTest.Models
{
    public class Employer
    {
        public int EmployerID { get; set; }
        public string Name { get; set; }
        public bool Married { get; set; }
        public string Phone { get; set; }
    }
}