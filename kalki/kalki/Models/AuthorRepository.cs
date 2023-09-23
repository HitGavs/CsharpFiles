using System.Collections.Generic;

namespace kalki.Models
{
    public class AuthorRepository
    {
        public static Dictionary<int, Author> GetAuthorDictionary()
        {
            string fName = @"C:\temp\Author.csv";
            Dictionary<int,Author> list = new Dictionary<int,Author>();
            bool isFileExists = System.IO.File.Exists(fName);   
            if (isFileExists)
            {
                using (StreamReader sr = new StreamReader(fName)) 
                {
                    string strAuthor = $"{sr.ReadLine()}";
                    string[] data = strAuthor.Split(',');
                    Author author = null;
                    if (data.Length == 5)
                    {
                        author = StringToAuthor(data, new Author());
                        list.Add(author.AuthorID, author);
                        while (!sr.EndOfStream)
                        {
                            strAuthor = $"{sr.ReadLine()}";
                            data = strAuthor.Split(",");
                            if (data.Length == 5)
                            {
                                author = StringToAuthor(data, new Author());
                                list.Add(author.AuthorID, author);
                            }

                        }
                    }
                }
            }
            return list;

        }
        public static Author FindAuthor (int id)
        {
            return new Author();
        }

        public static void SaveTofile(Author pAuthor)
        {
            String fName = @"c:\temp\Author.csv";
            string strAuthor = $"{pAuthor.AuthorID}, {pAuthor.AuthorName}, {pAuthor.RoyaltyCompany},{pAuthor.NumberofBooks}";
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine(strAuthor);
            }
        }
        private static Author StringToAuthor(string[] data, Author author)
        {
            author.AuthorID = int.Parse(data[0]);
            author.NumberofBooks = float.Parse(data[1]);
            author.AuthorName = data[2];
            author.RoyaltyCompany = data[3];
            author.AuthorDob = DateOnly.Parse(data[4]);
            return author;

        }
        public static void DeleteAuthor(Author author) { }

        //public static List<Author> GetAuthorslist() { }
        public static Author FindAuthorById(int id) 
        { 
            Dictionary<int,Author> list = AuthorRepository.GetAuthorDictionary();
            Author author = null;
            if(list != null)
            {
                author = list.FirstOrDefault(x => (x.Key == id)).Value;
            }
            return author;
        }
        public static void SaveToFile(Dictionary<int, Author> authorDic) 
        {
            String fname = @"c:\temp\Author.csv";
            string strauthor = $"";
        }

    }
}
