using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_08_PW
{
    class SalesForecast
    {
        public static void Main()
        {
            
            double[] salesData = { 100, 120, 95, 130, 110 };

            
            double[] forecast = PredictSales(salesData);

            
            Console.WriteLine("Прогноз объемов продаж на следующие три месяца:");
            for (int i = 0; i < forecast.Length; i++)
            {
                Console.WriteLine($"Месяц {i + 6}: {forecast[i]}");
            }
        }

        static double[] PredictSales(double[] data)
        {
            int n = data.Length;
            double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;

            for (int i = 0; i < n; i++)
            {
                sumX += i + 1; 
                sumY += data[i];
                sumXY += (i + 1) * data[i];
                sumX2 += (i + 1) * (i + 1);
            }

            
            double m = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
            double b = (sumY - m * sumX) / n;

            
            double[] forecast = new double[3];
            for (int i = 0; i < 3; i++)
            {
                forecast[i] = m * (n + i + 1) + b;
            }

            return forecast;
        }
    }

}
