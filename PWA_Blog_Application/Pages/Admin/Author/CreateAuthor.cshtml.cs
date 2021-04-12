using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PWA_Blog_Application.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;

namespace PWA_Blog_Application.Pages.Admin.Author
{
    public class CreateAuthorModel : PageModel
    {
        public void OnGet()
        {
            string connectionstring = configuration.GetConnectionString("DefaultConnectionString");

            SqlConnection connection = new SqlConnection(connectionstring);

            connection.Open();
            SqlCommand com = new SqlCommand();
            connection.Close();
        }

        private readonly IConfiguration configuration;

        public CreateAuthorModel(IConfiguration config)
        {
            this.configuration = config;
        }

        [FromForm]
        public PWA_Blog_Application.Models.Author Auther { get; set; }
    }
}
