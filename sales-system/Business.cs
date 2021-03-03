using System;
using System.Collections.Generic;
using System.Text;

namespace sales_system
{
    public class Business
    {
        //Se define los arreglos requeridos y creo variable contadora
        Sale[] Sales = new Sale[10];
        int salesCount = 0;

        SalesMan[] SalesMans = new SalesMan[10];
        int salesManCount = 0;

        Product[] Products = new Product[10];
        int productCount = 0;

        //Creamos los metodos se debe llamar como un verbo adicionar si es void no devuelve nada 
        //En el parentesis va lo que necesito un objeto para realizar la operacion 
        // Metodo para agregar vendedores
        public void AddSalesMan(SalesMan newSalesMan)
        {
            SalesMans[salesManCount] = newSalesMan;
            salesManCount++;
        }

        //Metodo para agregar products
        public void AddProduct(Product newProduct)
        {
            Products[productCount] = newProduct;
            productCount++;
        }
        
        //Metodo para agregar ventas
        public void AddSale(Sale newSale)
        {
            Sales[salesCount] = newSale;
            salesCount++;
        }
        //Method that counts the amount of sales of a product
        public int CountAmountsameProduct()
        {
            int count = 0;
            //int count2 = 0;
            //int count3 = 0;


            // creo un for para que me recorra el arreglo Product
            for (int i = 0; i < salesCount; i++)
            {
                if (Sales[i].Product.GetAmountSameProduct() == 1)
                {
                    count++;
                }

              
            }
           
            return count;
        }
        /*public int CountAmountsameProduct()
        {
            int count = 0;
           
            // creo un for para que me recorra el arreglo Product
            for (int i = 0; i < salesCount; i++)
            {
                count++;
            }
           
            return count ;
        }
        */
          /*if (Sales[i].Product.GetAmountSameProduct() == 2)
                {
                    count2++;
                }

                if (Sales[i].Product.GetAmountSameProduct() == 3)
                {
                    count3++;
                }*/

    }
}
