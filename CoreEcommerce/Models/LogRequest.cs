using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEcommerce.Models
{
    public class LogRequest
    {
        //_logger.Log(LogLevel.Information, 1, $"REQUEST METHOD: {context.Request.Method}, REQUEST BODY: {requestBodyText}, REQUEST URL: {url}", null);

        [Key]
        public int id { get; set; }

        public string method { get; set; }

        public string body { get; set; }

        public string url { get; set; }

        public DateTime created { get; set; }
    }
}
