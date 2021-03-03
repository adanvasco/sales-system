using System;

namespace sales_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Business business = new Business(); 
            
            // Values ​​are assigned to objects
            SalesMan sm1 = new SalesMan();
            sm1.Identification = "75050325";
            sm1.Name = "Carlos Arias";
            sm1.Age = 50;
            business.AddSalesMan(sm1);
            
            SalesMan sm2 = new SalesMan();
            sm2.Identification = "30230324";
            sm2.Name = "Danna Gomez";
            sm2.Age = 35;
            business.AddSalesMan(sm2);

            SalesMan sm3 = new SalesMan();
            sm3.Identification = "75089062";
            sm3.Name = "Patrick Orozco";
            sm3.Age = 43;
            business.AddSalesMan(sm2);

            Product p1 = new Product();
            p1.SetAmountSameProduct(1); 
            //p1.Code = "0001";
            p1.Name = "FZ 2.0 150 CC";
            p1.Price = 7000000;
            business.AddProduct(p1);

            Product p2 = new Product();
            p2.SetAmountSameProduct(2);
            //p2.Code = "0002";
            p2.Name = "FZ 250 CC";
            p2.Price = 11000000;
            business.AddProduct(p2);

            Product p3 = new Product();
            p1.SetAmountSameProduct(3);
            //p3.Code = "0003";
            p3.Name = "MT 09 847 CC";
            p3.Price = 18000000;
            business.AddProduct(p3);

            Sale s1 = new Sale();
            s1.SalesMan = sm1;
            s1.Product = p3;
            s1.Comments = "90 Km for gallon";
            //sm3.Name = "Patrick Orozco";
            business.AddSale(s1);

            Sale s2 = new Sale();
            s2.SalesMan= sm2;
            s2.Product = p1;
            s2.Comments = "115 Km for gallon, Inyeccion electronica ";
            //sm2.Name = "Danna Gomez";
            business.AddSale(s2);
            
            Sale s3 = new Sale();
            s3.SalesMan = sm3;
            s3.Product = p2;
            s3.Comments = "100 Km for gallon, Inyeccion electronica";
            //sm2.Name = "Danna Gomez";
            business.AddSale(s3);

            Sale s4 = new Sale();
            s4.SalesMan = sm2;
            s3.Product = p3;
            s3.Comments = "90 Km for gallon";
            //sm2.Name = "Danna Gomez";
            business.AddSale(s3);
                       
            // A variable is created to sum the sales
            int SaleDay = (p2.Price + p3.Price + p1.Price + p3.Price);
            int Average = (SaleDay / 4);
           
            int CountNewMethod = business.CountAmountsameProduct();
            System.Console.WriteLine("The amounts of sales: " + CountNewMethod);

            // Shows the sales result
            Console.WriteLine("Total sales are: " + SaleDay);
            Console.WriteLine("What is the average cost of the products: " + Average); 
            Console.ReadKey();
            
        }
    }
}
