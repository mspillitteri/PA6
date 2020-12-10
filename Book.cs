using System;
using System.Collections.Generic;
using System.Text;

namespace PA6
{
    class Book
    {
        public Book(string cwid, string isbn, string title, string author, string cover, string genre, string id, int length, int copies)
        {
            this.cwid = cwid;
            this.isbn = isbn;
            this.title = title;
            this.author = author;
            this.cover = cover;
            this.genre = genre;
            _id = id;
            this.length = length;
            this.copies = copies;
        }

        public string cwid { get; set; }
        public string isbn { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string cover { get; set; }
        public string genre { get; set; }
        public string _id { get; set; }
        public int length { get; set; }
        public int copies { get; set; }

        public Book()
        {

        }

        public override string ToString()
        {
            return this.title;
        }
    }
}
