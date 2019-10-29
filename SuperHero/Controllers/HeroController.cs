using SuperHero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHero.Controllers
{
    public class HeroController : Controller
    {
        ApplicationDbContext db;
            public HeroController()
        {
            db = new ApplicationDbContext(); 
        }
        // GET: Hero
        public ActionResult HeroIndex()
        {
            var heroes = db.Heros.ToList();
            return View(heroes);
        }

        // GET: Hero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Hero/Create
        public ActionResult Create()
        {
            Hero hero = new Hero(); 
            return View(hero);
        }

        // POST: Hero/Create
        [HttpPost]
        public ActionResult Create(Hero hero)
        {
            try
            {
                db.Heros.Add(hero);
                db.SaveChanges();         // TODO: Add insert logic here

               
                return RedirectToAction("HeroIndex");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hero/Edit/5
        public ActionResult Edit(int id)
        {
           
            Hero hero = db.Heros.Where(e => e.Id == id).FirstOrDefault();
            return View(hero);
            
        }

        // POST: Hero/Edit/5
        [HttpPost]
        public ActionResult Edit(Hero hero)
        {
            try
            { 

                return RedirectToAction("HeroIndex");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hero/Delete/5
        public ActionResult Delete(int id)
        {
            Hero hero = db.Heros.Where(e => e.Id == id).FirstOrDefault();
            return View(hero);
        }

        // POST: Hero/Delete/5
        [HttpPost]
        public ActionResult Delete(Hero hero)
        {
            try
            {
               Hero Hero = db.Heros.Where(e => e.Id == hero.Id).FirstOrDefault();
                db.Heros.Remove(Hero);
                db.SaveChanges(); 


                return RedirectToAction("HeroIndex");
            }
            catch
            {
                return View();
            }
        }
    }
}
