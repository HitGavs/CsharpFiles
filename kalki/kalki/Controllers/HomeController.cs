using kalki.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace kalki.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SayHello(String name)
        {
            if (String.IsNullOrEmpty(name))
           
                ViewData["v1"] = "Name is empty";
            else
                ViewData["v1"] = name;
            return View();
        }
        public IActionResult Add(int x, int y)
        {
            int result = x+ y;
            ViewData["addResult"] = result;
            return View();
        }
        public IActionResult Multiply(int x, int y)
        {
            int result = x * y;
            ViewData["Result"] = result;
            return View();
        }
        public IActionResult Divide(int x, int y)
        {
            int result = x / y;
            ViewData["Result"] = result;
            return View();
        }

        public IActionResult DoLogin()
        {
            return View();
        }
       
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult AddNewBook(Book pbook)
        {
            Book book = new Book();
            return View(book);
        }
        public IActionResult SaveNewBook(Book pBook)
        {
            String fName = @"c:\temp\book.csv";
            string strBook = $"{pBook.BookID}, {pBook.Title}, {pBook.AuthorName}, {pBook.Cost}";
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine(strBook + Environment.NewLine);
            }

            return View(pBook);
        }
        public IActionResult ListAllBook() 
        {
            String fName = @"c:\temp\book.csv";
            List<Book> list = new List<Book>();
            using (StreamReader sr = new StreamReader(fName))
            {
                string strBook = $"{sr.ReadLine()}";
                String[] data = strBook.Split(',');
                Book book = StringToBook(data, new Book());
                list.Add(book);
                while (!sr.EndOfStream)
                {
                    strBook = $"{sr.ReadLine()}";
                    data = strBook.Split(",");
                    book = StringToBook(data, new Book()) ;
                    list.Add(book);
                }
                return View(list);

            }
        }
        public Book StringToBook(string[] data,Book book)
        {
            book.BookID = int.Parse(data[0]);
            book.Title = data[1];
            book.AuthorName = data[2];
            book.Cost = float.Parse(data[3]);
            return book;
        }

    }
}
//Create Author Model - Author ID,  Author Name, Author Date of Birth, No of Books Published,Royalty company.

//Create Author Controller - CreateAuthor, ListAuthors, ModifyAuthor, FindAuthor, DeleteAuthor

//Create Views w.r.t to the controller
