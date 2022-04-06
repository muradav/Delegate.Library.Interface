using Interface.Library.Task.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using Utils.Exceptions;

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

        public void AddBook(Books book)
        {
            bool check = false;
            foreach (Books item in books)
            {
                if (item.Name==book.Name && item.IsDeleted==true)
                {
                    Exceptions.AlreadyExistsException(item.Name, book.Name);
                    check=true;
                    return;
                }
                if (check == false)
                {
                    Console.WriteLine("The book addedd successfully");
                    books.Add(book);
                    Count++;
                }
                if (Count == BookLimit)        
                {
                    check = true;
                    Exceptions.CapacityLimitException(BookLimit, Count);
                    return;
                }
                
            }
        }
    }
}
