using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_113
{
    public class Book
    {
        public string title { get; set; }
        public int pages { get; set; }
        public int year { get; set; }
        public string whatToPrint { get; set; }

        public Book(string title, int pages, int year)
        {
            this.title = title;
            this.pages = pages;
            this.year = year;
        }

        public string Title()
        {
            return this.title;
        }

        public int Year()
        {
            return this.year;
        }

        public int Pages()
        {
            return this.pages;
        }

        public string ToString()
        {
            return title + ", " + pages + " pages, " + year;
        }

    }
}
