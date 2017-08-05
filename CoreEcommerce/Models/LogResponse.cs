using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEcommerce.Models
{
    public class LogResponse
    {
        [Key]
        public int id { get; set; }

        public string body { get; set; }

        public DateTime created { get; set; }
    }
}
