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
    public class TrainingCategoriesController : Controller
    {
        private GaloGroupDB db = new GaloGroupDB();

        // GET: Admin/TrainingCategories
        public async Task<ActionResult> Index()
        {
            return View(await db.TrainingCategories.ToListAsync());
        }

        // GET: Admin/TrainingCategories/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrainingCategory trainingCategory = await db.TrainingCategories.FindAsync(id);
            if (trainingCategory == null)
            {
                return HttpNotFound();
            }
            return View(trainingCategory);
        }

        // GET: Admin/TrainingCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/TrainingCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,CategoryTitle")] TrainingCategory trainingCategory)
        {
            if (ModelState.IsValid)
            {
                db.TrainingCategories.Add(trainingCategory);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(trainingCategory);
        }

        // GET: Admin/TrainingCategories/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrainingCategory trainingCategory = await db.TrainingCategories.FindAsync(id);
            if (trainingCategory == null)
            {
                return HttpNotFound();
            }
            return View(trainingCategory);
        }

        // POST: Admin/TrainingCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,CategoryTitle")] TrainingCategory trainingCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trainingCategory).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(trainingCategory);
        }

        // GET: Admin/TrainingCategories/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrainingCategory trainingCategory = await db.TrainingCategories.FindAsync(id);
            if (trainingCategory == null)
            {
                return HttpNotFound();
            }
            return View(trainingCategory);
        }

        // POST: Admin/TrainingCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            TrainingCategory trainingCategory = await db.TrainingCategories.FindAsync(id);
            db.TrainingCategories.Remove(trainingCategory);
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
