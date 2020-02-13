using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityFrameworkASP.Net.Services;
using EntityFrameworkASP.Net.Models;

namespace EntityFrameworkASP.Net.Controllers
{
    public class BlogsController : Controller
    {
        private BlogRepository repo;

        public BlogsController()
        {
            repo = new BlogRepository();
        }
        // GET: Blogs
        public ActionResult Index()
        {
            var model = repo.listarBlogs();
            return View(model);
        }

        // GET: Blogs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Blogs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Blogs/Create
        [HttpPost]
        public ActionResult Create(Blog model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repo.Crear(model);
                    return RedirectToAction("Index");
                }
            }

            catch(Exception Ex)
            {
                //Log Ex
            }
            return View(model);
        }

        // GET: Blogs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Blogs/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Blogs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Blogs/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
