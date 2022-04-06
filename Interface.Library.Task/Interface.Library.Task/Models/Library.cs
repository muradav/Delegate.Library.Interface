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
        
        public void GetBookById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException("Please enter ID.");
            }
            foreach (Books item in books)
            {
                if (id==item.ID && item.IsDeleted==false)
                {
                    Console.WriteLine(item);
                    return;
                }
            }
                
        }

        public void DeleteBookById(int? id)
        {
            bool check = false;
            if (id==null)
            {
                throw new NullReferenceException("Please enter ID");
            }
            foreach (Books item in books)
            {
                if (id==item.ID && item.IsDeleted==false)
                {
                    item.IsDeleted = true;
                    check = true;
                    return;
                }
            }
            if (check==false)
            {
                Exceptions.NotFoundException(id);
            }
        }

        public void GetAllBooks()
        {
            List<Books> cbooks = new List<Books>();
            foreach (Books item in cbooks)
            {
                Console.WriteLine(item);
            }
        }

        public void EditBookName(int? id)
        {
            bool check = false;
            if (id==null)
            {
                throw new NullReferenceException("Please enter ID");
            }
            foreach (Books item in books)
            {
                if (id==item.ID)
                {
                    Console.WriteLine("Please enter new Book Name: ");
                    item.Name=Console.ReadLine();
                    check=true;
                    return;
                }
            }
            if (check==false)
            {
                Exceptions.NotFoundException(id);
            }
        }
        
    }
}
