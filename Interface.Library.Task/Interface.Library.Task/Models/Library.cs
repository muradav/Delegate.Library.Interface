using Interface.Library.Task.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Library.Task.Models
{
    class Library:IEntity
    {
        private static int _id;
        public int ID { get; }

        public int BookLimit { get; set; }

       

        private int Count = 0;

        private List<Books> books;

        public Library()
        {
            books = new List<Books>();
            books.Capacity = BookLimit;

        }
    }
}
