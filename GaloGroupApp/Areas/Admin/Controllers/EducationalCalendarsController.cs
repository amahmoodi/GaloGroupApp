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
    public class EducationalCalendarsController : Controller
    {
        private GaloGroupDB db = new GaloGroupDB();

        // GET: Admin/EducationalCalendars
        public async Task<ActionResult> Index()
        {
            return View(await db.EducationalCalendars.ToListAsync());
        }

        // GET: Admin/EducationalCalendars/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EducationalCalendar educationalCalendar = await db.EducationalCalendars.FindAsync(id);
            if (educationalCalendar == null)
            {
                return HttpNotFound();
            }
            return View(educationalCalendar);
        }

        // GET: Admin/EducationalCalendars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/EducationalCalendars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,TrainingCourseId,CourseTitle,TeacherId,StartDate,StartRegisterDate,EndDate,EndRegisterDate,Capacity,duration,DayOfWeek,StartTime,EndTime")] EducationalCalendar educationalCalendar)
        {
            if (ModelState.IsValid)
            {
                db.EducationalCalendars.Add(educationalCalendar);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(educationalCalendar);
        }

        // GET: Admin/EducationalCalendars/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EducationalCalendar educationalCalendar = await db.EducationalCalendars.FindAsync(id);
            if (educationalCalendar == null)
            {
                return HttpNotFound();
            }
            return View(educationalCalendar);
        }

        // POST: Admin/EducationalCalendars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,TrainingCourseId,CourseTitle,TeacherId,StartDate,StartRegisterDate,EndDate,EndRegisterDate,Capacity,duration,DayOfWeek,StartTime,EndTime")] EducationalCalendar educationalCalendar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(educationalCalendar).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(educationalCalendar);
        }

        // GET: Admin/EducationalCalendars/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EducationalCalendar educationalCalendar = await db.EducationalCalendars.FindAsync(id);
            if (educationalCalendar == null)
            {
                return HttpNotFound();
            }
            return View(educationalCalendar);
        }

        // POST: Admin/EducationalCalendars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            EducationalCalendar educationalCalendar = await db.EducationalCalendars.FindAsync(id);
            db.EducationalCalendars.Remove(educationalCalendar);
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
