using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PWA_Blog_Application.Models;

namespace PWA_Blog_Application.Pages.Admin.Blog
{
    public class CreateBlogModel : PageModel
    {
        [FromForm]
        public PWA_Blog_Application.Models.Author Author { get; set; } = new PWA_Blog_Application.Models.Author();


        [FromForm]
        public PWA_Blog_Application.Models.Blog Blog { get; set; }

        private List<Models.Author> Authers { get; set; } = new List<Models.Author>();
        public IEnumerable<SelectListItem> AutherList { get; private set; }

        //public CreateBlogModel() {

        //    Models.Author a = new Models.Author()
        //    {
        //        Author_FirstName = "maulik",
        //        Author_LastName = "padsala",
        //        Email = "padsalamaulik1@gmail.com"

        //    };

        //    Models.Author b = new Models.Author()
        //    {
        //        Author_FirstName = "maulik",
        //        Author_LastName = "padsala",
        //        Email = "padsalamaulik1@gmail.com"

        //    };

        //    Models.Author c = new Models.Author()
        //    {
        //        Author_FirstName = "maulik",
        //        Author_LastName = "padsala",
        //        Email = "padsalamaulik1@gmail.com"

        //    };

        //    Authers.Add(a);
        //    Authers.Add(b);
        //    Authers.Add(c);

        //}

        public void OnGet()
        {
            AutherList = Authers.Select(cust =>
            {
                return new SelectListItem(String.Format("{0} ({1})", cust.Author_FirstName, cust.Email), cust.Email);
            });

            List<SelectListItem> list = new List<SelectListItem>();

            foreach (var cust in Authers)
            {
                list.Add(new SelectListItem(cust.Author_FirstName, cust.Email));
            }
            AutherList = list;
        }
    }
}
