using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data
{
    public class RetroContext:DbContext
    {
        public RetroContext() : base("DefaultConnection") { }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}
