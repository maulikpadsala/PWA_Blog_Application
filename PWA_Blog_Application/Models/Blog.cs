using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PWA_Blog_Application.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }

        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string AuthorName { get; set; }
        public DateTime PublishDate { get; set; }

        public string Comment { get; set; }

    }
}
