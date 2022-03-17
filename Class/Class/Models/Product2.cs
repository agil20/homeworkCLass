using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Models
{
    internal class Product2
    { public int No;// .Product class :
        public string Name;             //- No
        public int Price;            // - Name
        public int Count;            //- Price
                                     //- Count
        public Product2(int no, string name,int price)
        {
            no = No;
            Name = name; Price = price;

        }                             //            No, Name ve Price dəyərləri təyin olunmadan Product obyekti yaradıla bilməz

    }
}
