using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers
{
    public class BuyersController : Controller
    {
        private readonly BuyerContext _context;

        public BuyersController(BuyerContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Buyer buyer)
        {
            var log = _context.Buyers.Where(e => (e.Name == buyer.Name) && e.Password == e.Password).ToList();
            if (log.Count == 0)
            {
                ViewBag.message = "not valid";
                return View();
            }

            else
            {
                //HttpContext.Session.SetString("uname", buyer.Name);
                //HttpContext.Session.SetString("lastlogin", DateTime.Now.ToString());
                return RedirectToAction("Createdashboard");
            }
        }
        // GET: Buyers
        //public async Task<IActionResult> Login()
        //{
        //    return View(await _context.Buyers.ToListAsync());
        //}

        // GET: Buyers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buyer = await _context.Buyers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (buyer == null)
            {
                return NotFound();
            }

            return View(buyer);
        }
        [HttpGet]
        // GET: Buyers/Create
        public IActionResult RegisterBuyer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterBuyer(Buyer buyer)
        {
            try
            {
                _context.Add(buyer);
                _context.SaveChanges();
                ViewBag.message = buyer.Name + "has got successfull";
                return View("Login");
            }
            catch (Exception e)
            {
                ViewBag.message = buyer.Name + "failed";
            }
            return View();
        }

        // POST: Buyers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Address,Mail,Phoneno,Password,CreatedDate")] Buyer buyer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(buyer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(buyer);
        }

        // GET: Buyers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buyer = await _context.Buyers.FindAsync(id);
            if (buyer == null)
            {
                return NotFound();
            }
            return View(buyer);
        }

        // POST: Buyers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Address,Mail,Phoneno,Password,CreatedDate")] Buyer buyer)
        {
            if (id != buyer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(buyer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BuyerExists(buyer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(buyer);
        }

        // GET: Buyers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buyer = await _context.Buyers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (buyer == null)
            {
                return NotFound();
            }

            return View(buyer);
        }

        // POST: Buyers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var buyer = await _context.Buyers.FindAsync(id);
            _context.Buyers.Remove(buyer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BuyerExists(int id)
        {
            return _context.Buyers.Any(e => e.Id == id);
        }
    }
}
