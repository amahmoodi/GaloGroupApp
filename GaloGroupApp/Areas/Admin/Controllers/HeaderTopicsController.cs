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
    public class HeaderTopicsController : Controller
    {
        private GaloGroupDB db = new GaloGroupDB();

        // GET: Admin/HeaderTopics
        public async Task<ActionResult> Index()
        {
            return View(await db.HeaderTopics.ToListAsync());
        }

        // GET: Admin/HeaderTopics/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HeaderTopic headerTopic = await db.HeaderTopics.FindAsync(id);
            if (headerTopic == null)
            {
                return HttpNotFound();
            }
            return View(headerTopic);
        }

        // GET: Admin/HeaderTopics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/HeaderTopics/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,TrainingCourseId,HeadingTopic")] HeaderTopic headerTopic)
        {
            if (ModelState.IsValid)
            {
                db.HeaderTopics.Add(headerTopic);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(headerTopic);
        }

        // GET: Admin/HeaderTopics/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HeaderTopic headerTopic = await db.HeaderTopics.FindAsync(id);
            if (headerTopic == null)
            {
                return HttpNotFound();
            }
            return View(headerTopic);
        }

        // POST: Admin/HeaderTopics/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,TrainingCourseId,HeadingTopic")] HeaderTopic headerTopic)
        {
            if (ModelState.IsValid)
            {
                db.Entry(headerTopic).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(headerTopic);
        }

        // GET: Admin/HeaderTopics/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HeaderTopic headerTopic = await db.HeaderTopics.FindAsync(id);
            if (headerTopic == null)
            {
                return HttpNotFound();
            }
            return View(headerTopic);
        }

        // POST: Admin/HeaderTopics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            HeaderTopic headerTopic = await db.HeaderTopics.FindAsync(id);
            db.HeaderTopics.Remove(headerTopic);
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
