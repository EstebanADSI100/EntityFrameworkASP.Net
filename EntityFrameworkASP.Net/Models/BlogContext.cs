using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameworkASP.Net.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext()
            : base("Blog2020DBConnection")
        {

        }
        public DbSet<Blog> Blogs { get; set; }
    }
}