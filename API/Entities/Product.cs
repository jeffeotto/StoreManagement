using System;

namespace API.Entities
{
    public class Product 
    {
       
        public double Iva;
        public double iva;
        public int ID { get; set; }
        public double Price { get; set; }
        public double FinalPrice
        {
            set{
              PriceCalc(this.Price, this.Iva, ref this.iva);  
              }
        }

        

        public string ProductName { get; set; }
        public static  string[] Categories {get;set;}

        public static double PriceCalc(double Pbruto, double Tasa, ref double iva){
            { 
                     iva = Pbruto * (Tasa/100);
                      return Pbruto+iva;
                   
                }
        }
    }

    
}