// See https://aka.ms/new-console-template for more information
using LibraryA;

Book book = new Book();
book.Title = "To kill a Mocking bird";
book.Author = "Happer lee";
book.Genre  = "Social";
book.BookPrice = 250;
book.DateOfPublish = new DateTime(1995, 06, 01);
book.BookmarkPage(125);
Console.WriteLine(book.GetCurrentPage());
Calculator calculater = new Calculator();
int addResult = calculater.Add(100, 40);
Console.WriteLine(addResult);
int multiplyResult = calculater.Multiply(100, 40);
Console.WriteLine(multiplyResult);
int divideResult = calculater.Divide(100, 40);
Console.WriteLine(divideResult);


