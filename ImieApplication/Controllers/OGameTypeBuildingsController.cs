﻿using System;
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
    public class OGameTypeBuildingsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: OGameTypeBuildings
        public async Task<ActionResult> Index()
        {
            var oGameTypeBuildings = db.OGameTypeBuildings.Include(o => o.Planet);
            return View(await oGameTypeBuildings.ToListAsync());
        }

        // GET: OGameTypeBuildings/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OGameTypeBuilding oGameTypeBuilding = await db.OGameTypeBuildings.FindAsync(id);
            if (oGameTypeBuilding == null)
            {
                return HttpNotFound();
            }
            return View(oGameTypeBuilding);
        }

        // GET: OGameTypeBuildings/Create
        public ActionResult Create()
        {
            ViewBag.PlanetId = new SelectList(db.OGamePlanets, "Id", "Name");
            return View();
        }

        // POST: OGameTypeBuildings/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,PlanetId,Name,Level,BuildingType")] OGameTypeBuilding oGameTypeBuilding)
        {
            if (ModelState.IsValid)
            {
                db.OGameTypeBuildings.Add(oGameTypeBuilding);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.PlanetId = new SelectList(db.OGamePlanets, "Id", "Name", oGameTypeBuilding.PlanetId);
            return View(oGameTypeBuilding);
        }

        // GET: OGameTypeBuildings/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OGameTypeBuilding oGameTypeBuilding = await db.OGameTypeBuildings.FindAsync(id);
            if (oGameTypeBuilding == null)
            {
                return HttpNotFound();
            }
            ViewBag.PlanetId = new SelectList(db.OGamePlanets, "Id", "Name", oGameTypeBuilding.PlanetId);
            return View(oGameTypeBuilding);
        }

        // POST: OGameTypeBuildings/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,PlanetId,Name,Level,BuildingType")] OGameTypeBuilding oGameTypeBuilding)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oGameTypeBuilding).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.PlanetId = new SelectList(db.OGamePlanets, "Id", "Name", oGameTypeBuilding.PlanetId);
            return View(oGameTypeBuilding);
        }

        // GET: OGameTypeBuildings/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OGameTypeBuilding oGameTypeBuilding = await db.OGameTypeBuildings.FindAsync(id);
            if (oGameTypeBuilding == null)
            {
                return HttpNotFound();
            }
            return View(oGameTypeBuilding);
        }

        // POST: OGameTypeBuildings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            OGameTypeBuilding oGameTypeBuilding = await db.OGameTypeBuildings.FindAsync(id);
            db.OGameTypeBuildings.Remove(oGameTypeBuilding);
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
