using InterfaceLibrary.Task.Models;
using System;
using static Utils.Enum.Enum;

namespace InterfaceLibrary.Task
{
    internal class Program
    {
        enum menu { AddBook = 1, GetBookById, GetAllBooks, DeleteBookById, EditBookName, FilterByPageCount, Quit = 0 }
        static void Main(string[] args)
        {
            string role;
            do
            {
                
                Console.WriteLine("Please enter your Position: ");              
                role = Console.ReadLine().ToLower();

            } while (role != Role.admin.ToString() && role != Role.member.ToString());

            Library library = new Library();
            
            Console.Write("Please enter the name of library: ");
            string nameLibrary = Console.ReadLine();
            Console.Write("Please set the capacity of library: ");
            library.BookLimit = int.Parse(Console.ReadLine());
            
            int input;

            do
            {
                Console.WriteLine($"{nameLibrary} is created");
                Console.WriteLine("Menu \n" +
                        "1)Add book\n" +
                        "2)Get book by ID\n" +
                        "3)Get all books\n" +
                        "4)Delete book by ID\n" +
                        "5)Edit book name\n" +
                        "6)Filter by page count\n" +
                        "0)Quit");
                Console.WriteLine("Please input your choice: ");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case (int)menu.AddBook:
                        Console.Clear();
                        Console.Write("Please enter the name of book: ");
                        string bookname = Console.ReadLine();
                        Console.Write($"Please enter the author of {bookname}: ");
                        string author = Console.ReadLine();
                        Console.Write($"Please enter the count of page of {bookname}: ");
                        int pagecount = int.Parse(Console.ReadLine());
                        Books book1 = new Books(bookname, author, pagecount);
                        library.AddBook(book1);
                        break;

                    case (int)menu.GetBookById:
                        Console.Clear();
                        Console.Write("Please enter the ID: ");
                        int id = int.Parse(Console.ReadLine());
                        library.GetBookById(id);
                        break;

                    case (int)menu.GetAllBooks:
                        Console.Clear();
                        library.GetAllBooks();
                        break;

                    case (int)menu.DeleteBookById:
                        Console.Clear();
                        Console.Write("Please enter the ID: ");
                        int delete = int.Parse(Console.ReadLine());
                        library.DeleteBookById(delete);
                        break;

                    case (int)menu.EditBookName:
                        Console.Clear();
                        Console.Write("Please enter the ID: ");
                        int rename = int.Parse(Console.ReadLine());
                        library.EditBookName(rename);
                        break;

                    case (int)menu.FilterByPageCount:
                        Console.Clear();
                        Console.WriteLine("Please enter minimum and maximum range of pagecounts for the filter books");
                        Console.Write("Min: ");
                        int min = int.Parse(Console.ReadLine());
                        Console.Write("Max: ");
                        int max = int.Parse(Console.ReadLine());
                        library.FilterByPageCount(min, max);
                        break;

                    case (int)menu.Quit:
                        break;

                }

            } while (input != 0);

            
        }
    }
}
