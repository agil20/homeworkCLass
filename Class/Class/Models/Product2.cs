namespace Class.Models
{
    internal class Product2
    {
        public int No;// .Product class :
        public string Name;             //- No
        public double Price;            // - Name
        public int Count;            //- Price
                                     //- Count
        public Product2(int no, string name, double price)
        {
            No = no;
            Name = name; Price = price;

        }                             //            No, Name ve Price dəyərləri təyin olunmadan Product obyekti yaradıla bilməz

    }
}

