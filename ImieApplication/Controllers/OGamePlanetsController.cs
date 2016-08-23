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
    public class OGamePlanetsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: OGamePlanets
        public async Task<ActionResult> Index()
        {
            var oGamePlanets = db.OGamePlanets.Include(o => o.Coordinate).Include(o => o.Fleet);
            return View(await oGamePlanets.ToListAsync());
        }

        // GET: OGamePlanets/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OGamePlanet oGamePlanet = await db.OGamePlanets.FindAsync(id);
            if (oGamePlanet == null)
            {
                return HttpNotFound();
            }
            return View(oGamePlanet);
        }

        // GET: OGamePlanets/Create
        public ActionResult Create()
        {
            ViewBag.CoordinateId = new SelectList(db.OGameCoordinates, "Id", "Id");
            ViewBag.Id = new SelectList(db.OGameFleets, "Id", "Name");
            return View();
        }

        // POST: OGamePlanets/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,Slot,Image,CoordinateId")] OGamePlanet oGamePlanet)
        {
            if (ModelState.IsValid)
            {
                db.OGamePlanets.Add(oGamePlanet);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.CoordinateId = new SelectList(db.OGameCoordinates, "Id", "Id", oGamePlanet.CoordinateId);
            ViewBag.Id = new SelectList(db.OGameFleets, "Id", "Name", oGamePlanet.Id);
            return View(oGamePlanet);
        }

        // GET: OGamePlanets/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OGamePlanet oGamePlanet = await db.OGamePlanets.FindAsync(id);
            if (oGamePlanet == null)
            {
                return HttpNotFound();
            }
            ViewBag.CoordinateId = new SelectList(db.OGameCoordinates, "Id", "Id", oGamePlanet.CoordinateId);
            ViewBag.Id = new SelectList(db.OGameFleets, "Id", "Name", oGamePlanet.Id);
            return View(oGamePlanet);
        }

        // POST: OGamePlanets/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Slot,Image,CoordinateId")] OGamePlanet oGamePlanet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oGamePlanet).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.CoordinateId = new SelectList(db.OGameCoordinates, "Id", "Id", oGamePlanet.CoordinateId);
            ViewBag.Id = new SelectList(db.OGameFleets, "Id", "Name", oGamePlanet.Id);
            return View(oGamePlanet);
        }

        // GET: OGamePlanets/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OGamePlanet oGamePlanet = await db.OGamePlanets.FindAsync(id);
            if (oGamePlanet == null)
            {
                return HttpNotFound();
            }
            return View(oGamePlanet);
        }

        // POST: OGamePlanets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            OGamePlanet oGamePlanet = await db.OGamePlanets.FindAsync(id);
            db.OGamePlanets.Remove(oGamePlanet);
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
