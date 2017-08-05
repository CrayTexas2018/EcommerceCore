using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEcommerce.Models
{
    public class Employee
    {
        [Key]
        public int employeeID { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public bool active { get; set; }

        public bool created { get; set; }
    }
}
