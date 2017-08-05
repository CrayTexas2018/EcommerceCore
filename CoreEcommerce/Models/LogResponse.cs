using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEcommerce.Models
{
    public class LogResponse
    {
        public int id { get; set; }

        public string body { get; set; }

        public DateTime created { get; set; }
    }
}
