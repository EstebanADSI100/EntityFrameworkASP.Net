using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntityFrameworkASP.Net.Models;

namespace EntityFrameworkASP.Net.Services
{
    public class BlogRepository
    {
        public List<Blog> listarBlogs()
        {
            using (var db = new BlogContext())
            {
                return db.Blogs.ToList();
            }
        }

        internal void Crear(Blog model)
        {
           using (var db = new BlogContext())
            {
                db.Blogs.Add(model);
                db.SaveChanges();
            }
        }
    }
}