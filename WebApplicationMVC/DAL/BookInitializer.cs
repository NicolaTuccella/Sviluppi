using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplicationMVC.DAL;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.DAL
{

    // DropCreateDatabaseIfModelChanges: ricrea sempre il DB
    // CreateDatabaseIfNotExists: solo se non esist
    public class BookInitializer : CreateDatabaseIfNotExists<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            var author1 = new Author
            {
                Biography = "...",
                FirstName = "Jamie",
                LastName = "Munro"
            };
            var author2 = new Author
            {
                Biography = "https://it.wikipedia.org/wiki/Ken_Follett",
                FirstName = "Ken",
                LastName = "Follett"
            };
            var books = new List<Book>
   {
    new Book {
     Author = author1,
    Description = "...",
    ImageUrl = "http://ecx.images-amazon.com/images/I/51T%2BWt430bL._AA160_.jpg",
    Isbn = "1491914319",
   Synopsis = "...",
    Title = "Knockout.js: Building Dynamic Client-Side Web Applications"
    },
    new Book {
      Author = author1,
    Description = "...",
   ImageUrl = "http://ecx.images-amazon.com/images/I/51AkFkNeUxL._AA160_.jpg",
    Isbn = "1449319548",
   Synopsis = "...",
   Title = "20 Recipes for Programming PhoneGap: Cross-Platform Mobile Development"
   },
   new Book {
   Author = author1,
   Description = "...",
   ImageUrl = "http://ecx.images-amazon.com/images/I/51LpqnDq8-L._AA160_.jpg",
   Isbn = "1449309860",
   Synopsis = "...",
   Title = "20 Recipes for Programming MVC 3: Faster, Smarter Web Development"
   },
   new Book {
   Author = author1,
   Description = "...",
   ImageUrl = "http://ecx.images-amazon.com/images/I/41JC54HEroL._AA160_.jpg",
   Isbn = "1460954394",
   Synopsis = "...",
   Title = "Rapid Application Development With CakePHP"
    },
   new Book {
   Author = author2,
   Description = "...",
   ImageUrl = "http://recenslibri.altervista.org/blog/wp-content/uploads/2013/05/la-caduta-dei-giganti-194x300.jpg",
   Isbn = "978-8804666912",
   Synopsis = "...",
   Title = "La caduta dei giganti"
    }
  };

          

            books.ForEach(b => context.Books.Add(b));

            context.SaveChanges();
        }
    }
}