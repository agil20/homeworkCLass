using System;
using Class.Models;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //Console.WriteLine("Please write how many laptops do you need?");
            //int count = Convert.ToInt32(Console.ReadLine());
            //Nodebook[] notebooks = new Nodebook[count];

            //for (int i = 0; i < count; i++)
            //{
            //    Console.Write("Please enter the Brand Name: ");
            //    string Brandname = Console.ReadLine();

            //    Console.Write("Please enter the Model: ");
            //    string model = Console.ReadLine();

            //    Console.Write("Please enter the Ram: ");
            //    int Ram = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Please enter the Storge:  ");
            //    int Storge = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Please enter the Price: ");
            //    double Price = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Please enter the Count: ");
            //    int Count = Convert.ToInt32(Console.ReadLine());
            //    notebooks[i] = new Nodebook(Brandname, Price, Count)
            //    {
            //        Model = model,
            //        Ram = Ram,
            //        Storge = Storge
            //    };
            //    //notebooks[i].Model = Model;
            //    //notebooks[i].Ram = Ram;
            //    //notebooks[i].Storge = Storge;

            //} Console.Clear();
            //Console.WriteLine("List of Nodebooks");
            //foreach (var item in notebooks)
            //{
            //    item.GetInfo();
            //}
            #endregion
            //  Proqram run olduqda bizden say istemelidi, sayi daxil etdikden sonra hemin uzunluqda bir book arrayi yaradilmalidir
            Console.WriteLine("Please write how many books do you need?");
            int count = Convert.ToInt32(Console.ReadLine());
            Book[] books = new Book[count];
            //daha sonra verdiyimiz say defe bizden book ucun lazim olan butun inputlari daxil etmeyimizi istemelid

            for (int i = 0; i < count; i++)
            {  //string genre, int no, string name, int price
                Console.WriteLine("Please enter the Genre: ");
                string Genre = Console.ReadLine();
                Console.WriteLine("Please enter the No: ");
                int no = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter the Price: ");
                int price = int.Parse(Console.ReadLine());


                books[i] = new Book(Genre, no, name, price);
            }
                Console.WriteLine("1. Filter books according to price \n" +
                                "2.Show all books \n" +
                                " 0.Close the program");
                int a = Convert.ToInt32(Console.ReadLine());
            
                do
                {
                    Console.WriteLine("Re ENter");


                } while (a != 1 || a != 0 || a != 2);
                if (a == 1)
                {
                
                    Console.WriteLine("maxPrice?: ");



                    int max = Convert.ToInt32(Console.ReadLine());// Biz her iki deyeri daxil etdikden sonra proqram yaranmis kitab
                    Console.WriteLine("minPrice?: ");                                           //// arrayindeki kitablari gonderdiyimiz min ve max price deyerlerine gore filter
                    int min = Convert.ToInt32(Console.ReadLine());  // edib bize gostermelidi.
                for (int i = 0; i < count; i++)
                {
                    if (!(max > books[i].Price && min < books[i].Price))
                    {
                        Console.WriteLine("no");
                    }
                    else
                    {
                        foreach (var item in books)
                        {
                            item.Infobook();
                        }
                    }
                }   
               

                }
            }
           

            }
        }
    }}