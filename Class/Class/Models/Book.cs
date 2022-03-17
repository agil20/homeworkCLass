using System;

namespace Class.Models
{
    internal class Book : Product2
    {////Book class - Productdan miras alır 
     // - Genre
        public string Genre;  //Genre dəyəri təyin olunmadan Book yaradıla bilməz
        public Book(string genre, int no, string name, double price) : base(no, name, price)
        {
            Genre = genre;
        }
        public void Infobook()
        { 
            Console.WriteLine($"Genre:  {Genre}\n" +
                $"No:  {No}\n" +
                $"Name:  {Name}\n" +
                $"Price:  {Price}");
        }
    }
}