using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Models
{
    internal class Book:Product2
    {////Book class - Productdan miras alır 
     // - Genre
        public string Genre;  //Genre dəyəri təyin olunmadan Book yaradıla bilməz
        public Book(string genre, int no, string name, int price):base (no, name, price) 
        {
            genre = Genre;
        }
        public void Infobook()
        {
            Console.WriteLine($"Genre{Genre}\n" +
                $"No{No}\n" +
                $"Name{Name}\n" +
                $"Price{Price}");
        }
    }
}
