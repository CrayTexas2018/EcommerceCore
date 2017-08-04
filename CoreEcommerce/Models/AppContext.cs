using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEcommerce.Models
{
    public class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
