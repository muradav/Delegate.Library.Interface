using System;
using System.Collections.Generic;
using System.Text;

namespace Utils.Exceptions
{
    public class Exceptions
    {
        public static void CapacityLimitException(int count, int capacity)
        {

            if (capacity == count)
                Console.WriteLine("Capacity excess");

        }
        public static void AlreadyExistsException(string bookName1, string bookName2)
        {

            if (bookName1 == bookName2)
                Console.WriteLine("This book is exist ");


        }
        public static void NotFoundException(int? id)
        {

            Console.WriteLine($"The book not found");

        }
    }
}
