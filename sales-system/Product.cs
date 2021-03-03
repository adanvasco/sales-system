using System;
using System.Collections.Generic;
using System.Text;

// The product class is created with your objects
namespace sales_system
{
    public class Product
    {
        //public string Code;  // Code_Product = 0001, 0002, 0003
        public int Code;  // Code_Product = 0001, 0002, 0003
        public string Name;
        public int Price;

        //public string  Code;  // Code_Product = 0001, 0002, 0003
        
        //Method Get the amount of sales of the same product
        public void SetAmountSameProduct(int newAmountSameProduct)
        {
                //if (newAmountSameProduct == "0001" || newAmountSameProduct == "0002" || newAmountSameProduct == "0003")
                if (newAmountSameProduct == 1 || newAmountSameProduct == 2 || newAmountSameProduct == 3)
            {
                //AmountSameProduct = newAmountSameProduct;
                Code = newAmountSameProduct;
            }
            else
            {
                Console.WriteLine("No products sales");
            }
        }
        //Metodo que retorna AmountSameProduct 
        public int GetAmountSameProduct()
        {
            //return AmountSameProduct;
            return Code;
        }
    }

}
