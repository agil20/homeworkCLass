using System;

namespace Class.Models
{
    internal class Nodebook : Product
    {
        public string BrandName;
        public string Model;
        public int Storge;
        public int Ram;
        public Nodebook(string brandname, double price, int count) : base(price, count)
        {
            BrandName = brandname;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Brand Name  : {BrandName}\n" +
                $"Model  {Model}\n"+
                $"Storge  {Storge}\n"+
                $"Ram  {Ram}\n"+
                $"Price  {Price}\n"+
                $"Count  {Count}\n");
        }

    }
}
