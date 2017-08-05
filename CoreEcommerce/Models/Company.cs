using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CoreEcommerce.Models
{
    public class Company
    {
        [Key]
        public int companyId { get; set; }

        public string name { get; set; }

        public List<Employee> employees { get; set; }

        public DateTime created { get; set; }

        public DateTime updated { get; set; }
    }
}
