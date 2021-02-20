using System;

namespace sales_system
{
    class Program
    {
        static void Main(string[] args)
        {

            // Values ​​are assigned to objects
            SalesMan sm1 = new SalesMan();
            sm1.Identification = "75050325";
            sm1.Name = "Carlos Arias";
            sm1.Age = 50;

            SalesMan sm2 = new SalesMan();
            sm2.Identification = "30230324";
            sm2.Name = "Danna Gomez";
            sm2.Age = 35;

            SalesMan sm3 = new SalesMan();
            sm3.Identification = "75089062";
            sm3.Name = "Patrick Orozco";
            sm3.Age = 43;

            Product p1 = new Product();
            p1.Code = "0001";
            p1.Name = "FZ 2.0 150 CC";
            p1.Price = 7000000;

            Product p2 = new Product();
            p2.Code = "0002";
            p2.Name = "FZ 250 CC";
            p2.Price = 11000000;

            Product p3 = new Product();
            p3.Code = "0003";
            p3.Name = "MT 09 847 CC";
            p3.Price = 18000000;

            Sale s1 = new Sale();
            s1.Code_Product = "0002";
            s1.Name_Product = "FZ 250 CC";
            s1.Comments = "120 Km for gallon";
            sm3.Name = "Patrick Orozco";

            Sale s2 = new Sale();
            s2.Code_Product = "0003";
            s2.Name_Product = "MT 09 847 CC";
            s2.Comments = "110 Km for gallon, Inyeccion electronica ";
            sm2.Name = "Danna Gomez";

            Sale s3 = new Sale();
            s3.Code_Product = "0001";
            s3.Name_Product = "FZ 2.0 150 CC";
            s3.Comments = "4 stroke DOHC, Liquid-cooled";
            sm2.Name = "Danna Gomez";

            // A variable is created to sum the sales
            int SaleDay = (p2.Price + p3.Price + p1.Price);

            // Shows the sales result
            Console.WriteLine("Las ventas totales son: " + SaleDay);
            Console.ReadKey();
            
        }
    }
}
