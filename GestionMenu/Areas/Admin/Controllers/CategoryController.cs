using System;
using System.Threading.Tasks;
using GestionMenu.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionMenu.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;


        public CategoryController(ApplicationDbContext _db)
        {
            this._db = _db;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _db.categories.ToListAsync());
        }
    }
}
