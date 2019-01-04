using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplicationMVC.Models
{
    public class Book
    {
        public int Id {get; set;}

        public int AuthorId { get; set;}

        public string Title { get; set;}

        public string TypeMaterial { get; set; }

        public string Isbn { get; set; }

        public string Synopsis { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public virtual Author Author { get; set; }

        public Book()
        {
            this.Title = "*";
            this.TypeMaterial = "M";
        }
    }
}