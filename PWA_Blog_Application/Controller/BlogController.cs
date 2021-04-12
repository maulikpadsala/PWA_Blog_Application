using Microsoft.AspNetCore.Mvc;
using PWA_Blog_Application.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PWA_Blog_Application.Controller
{
    public class BlogController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public BlogController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var displayData = _db.Blog_Table.ToList();

            return View(displayData);
        }


        public IActionResult Create()
        {

            return View();
        }


        public IActionResult Details(int? id)
        {

            Blog bc = _db.Blog_Table.Find(id);
            //Console.WriteLine(bc.auther_name);
            return View(bc);
        }



        [HttpPost]
        public async Task<IActionResult> Create(Blog bc)
        {
            if (ModelState.IsValid)
            {
                _db.Add(bc);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            return View(bc);



        }

        private IActionResult View(Blog bc)
        {
            throw new NotImplementedException();
        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}
