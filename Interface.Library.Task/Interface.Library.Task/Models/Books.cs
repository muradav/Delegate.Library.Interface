using Interface.Library.Task.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Library.Task.Models
{
    class Books:IEntity
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public bool IsDeleted { get; set; } = false;

        private static int _id;
        public int ID { get; }

        public Books(string name, string author, int pagecount)
        {
            _id++;
            ID = _id;
            Name = name;
            Author = author;
            PageCount = pagecount;

        }
       
        public string ShowInfo()
        {
            return $"Book ID: {ID}\n" +
                $"Book Name: {Name}\n" +
                $"Author: {Author}\n" +
                $"PageCount: {PageCount}\n" +
                $"IsDeleted: {IsDeleted}";
        }
        public override string ToString()
        {
            return $"Book ID: {ID}\n" +
                $"Book Name: {Name}\n" +
                $"Author: {Author}\n" +
                $"PageCount: {PageCount}\n" +
                $"IsDeleted: {IsDeleted}";
        }
        
    }
}
