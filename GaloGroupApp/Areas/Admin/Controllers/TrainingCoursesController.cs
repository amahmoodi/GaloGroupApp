using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GaloGroup.Domain.DBModel;

namespace GaloGroupApp.Areas.Admin.Controllers
{
    public class TrainingCoursesController : Controller
    {
        private GaloGroupDB db = new GaloGroupDB();

        // GET: Admin/TrainingCourses
        public async Task<ActionResult> Index()
        {
            return View(await db.TrainingCourses.ToListAsync());
        }

        // GET: Admin/TrainingCourses/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrainingCourse trainingCourse = await db.TrainingCourses.FindAsync(id);
            if (trainingCourse == null)
            {
                return HttpNotFound();
            }
            return View(trainingCourse);
        }

        // GET: Admin/TrainingCourses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/TrainingCourses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,TrainingCourseTitle,CategoryId")] TrainingCourse trainingCourse)
        {
            if (ModelState.IsValid)
            {
                db.TrainingCourses.Add(trainingCourse);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(trainingCourse);
        }

        // GET: Admin/TrainingCourses/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrainingCourse trainingCourse = await db.TrainingCourses.FindAsync(id);
            if (trainingCourse == null)
            {
                return HttpNotFound();
            }
            return View(trainingCourse);
        }

        // POST: Admin/TrainingCourses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,TrainingCourseTitle,CategoryId")] TrainingCourse trainingCourse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trainingCourse).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(trainingCourse);
        }

        // GET: Admin/TrainingCourses/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrainingCourse trainingCourse = await db.TrainingCourses.FindAsync(id);
            if (trainingCourse == null)
            {
                return HttpNotFound();
            }
            return View(trainingCourse);
        }

        // POST: Admin/TrainingCourses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            TrainingCourse trainingCourse = await db.TrainingCourses.FindAsync(id);
            db.TrainingCourses.Remove(trainingCourse);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
