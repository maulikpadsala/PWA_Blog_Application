using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PWA_Blog_Application.Pages.Admin.Blog
{
    public class ViewBlogModel : PageModel
    {
        [FromForm]
        public PWA_Blog_Application.Models.Author Author { get; set; } = new PWA_Blog_Application.Models.Author();


        [FromForm]
        public PWA_Blog_Application.Models.Blog Blog { get; set; }

        private List<Models.Author> Authers { get; set; } = new List<Models.Author>();
        public IEnumerable<SelectListItem> AutherList { get; private set; }
        public void OnGet()
        {
        }
    }
}
