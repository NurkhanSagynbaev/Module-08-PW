using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_08_PW
{
    using System;

    class ProductSupermarket
    {
        public static void Main()
        {
            
            string[] products = { "Хлеб", "Молоко", "Яйца", "Фрукты" };
            double[] prices = { 2.5, 3.0, 1.5, 5.0 };

            DateTime currentTime = DateTime.Now;
            double discount = (currentTime.Hour >= 8 && currentTime.Hour <= 12) ? 0.05 : 0.0;

            double totalAmount = 0;

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Введите количество продукта '{products[i]}': ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                totalAmount += prices[i] * quantity;
            }

            
            totalAmount -= totalAmount * discount;

            Console.WriteLine($"Итоговая сумма покупки: {totalAmount:C}");
        }
    }

}
