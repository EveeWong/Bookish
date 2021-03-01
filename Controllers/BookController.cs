using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookish.Models;

namespace Bookish.Controllers
{
    [Route("book")]
    public class BookController : Controller
    {
        public IActionResult Book()
        {
            var exampleBook = new Book() 
            {
                BookId = 1,
                Title = "Convenience Store Woman",
                Author = "Sayaka Murata",
                Year = 2016
            };

            return View(exampleBook);
        }
    }
}