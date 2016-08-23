using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ImieApplication.Models;

namespace ImieApplication.Controllers
{
    [Authorize]
    public class OGameCoordinatesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: OGameCoordinates
        public async Task<ActionResult> Index()
        {
            return View(await db.OGameCoordinates.ToListAsync());
        }

        // GET: OGameCoordinates/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OGameCoordinate oGameCoordinate = await db.OGameCoordinates.FindAsync(id);
            if (oGameCoordinate == null)
            {
                return HttpNotFound();
            }
            return View(oGameCoordinate);
        }

        // GET: OGameCoordinates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OGameCoordinates/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,X,Y")] OGameCoordinate oGameCoordinate)
        {
            if (ModelState.IsValid)
            {
                db.OGameCoordinates.Add(oGameCoordinate);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(oGameCoordinate);
        }

        // GET: OGameCoordinates/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OGameCoordinate oGameCoordinate = await db.OGameCoordinates.FindAsync(id);
            if (oGameCoordinate == null)
            {
                return HttpNotFound();
            }
            return View(oGameCoordinate);
        }

        // POST: OGameCoordinates/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,X,Y")] OGameCoordinate oGameCoordinate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oGameCoordinate).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(oGameCoordinate);
        }

        // GET: OGameCoordinates/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OGameCoordinate oGameCoordinate = await db.OGameCoordinates.FindAsync(id);
            if (oGameCoordinate == null)
            {
                return HttpNotFound();
            }
            return View(oGameCoordinate);
        }

        // POST: OGameCoordinates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            OGameCoordinate oGameCoordinate = await db.OGameCoordinates.FindAsync(id);
            db.OGameCoordinates.Remove(oGameCoordinate);
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
