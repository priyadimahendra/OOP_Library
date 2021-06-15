using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Library
{
    class Book
    {
        public string NameBook { get; set; }
        public int QuantityBook { get; set; }

        public Book()
        {

        }

        public Book(string nameBook, int quantityBook)
        {
            NameBook = nameBook;
            QuantityBook = quantityBook;
        }

        public void ShowBook()
        {
            Console.WriteLine(".Nama Buku   = " + NameBook);
            Console.WriteLine("  Jumlah Buku = " + QuantityBook);
        }
    }
}
