using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootstrapLab.Models
{
    public class Book
    {
        public int ID { get; set; }
        public int AuthorID { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public string Synopsis { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public virtual Author Author { get; set; }
    }
}