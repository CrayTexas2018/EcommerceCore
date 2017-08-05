using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEcommerce.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<LogRequest> Requests { get; set; }
        public DbSet<LogResponse> Responses { get; set; }
        public DbSet<Company> Companies { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }
    }


}
