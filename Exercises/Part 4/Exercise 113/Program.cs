namespace exercise_113
{
    using Exercise_113;
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static void Main(string[] args)
        {
            // IMPLEMENT YOUR CODE IN HERE!
            // Remember also to create the file Book.cs and class in it!

            List<Book> books = new List<Book>();

            while (true)
            {
                Console.Write("Name: ");
                string title = Console.ReadLine();
                if (title == "")
                {
                    Console.WriteLine("What information will be printed?");
                    string whatToPrint = Console.ReadLine();
                    if (whatToPrint == "everything")
                    {
                        for (int i = 0; i < books.Count; i++)
                        {
                            Console.WriteLine(books[i].ToString());

                        }
                        break;
                    }
                    if (whatToPrint == "title")
                    {
                        for (int i = 0; i < books.Count; i++)
                        {
                            Console.WriteLine(books[i].Title());
                        }
                        break;
                    }
                    else { break; }

                }

                Console.Write("Pages: ");
                int pages = Convert.ToInt32(Console.ReadLine());

                Console.Write("Publication : ");
                int year = Convert.ToInt32(Console.ReadLine());

                Book book = new Book(title, pages, year);
                books.Add(book);





            }
            Console.ReadKey();
        }
    }
}
