using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Array
{
    public class MaximumProfitInTrading
    {
        public void GetMaximumProfit()
        {
            int[] priceValues = { 10, 22, 5, 85, 2, 80 };
            int n = priceValues.Length;

            int[] profit = new int[n];
            for (int i = 0; i < n; i++)
                profit[i] = 0;


            int max_price = priceValues[n - 1];

            for (int i = n - 2; i >= 0; i--)
            {
                if (priceValues[i] > max_price)
                    max_price = priceValues[i];


                profit[i] = Math.Max(profit[i + 1],
                              max_price - priceValues[i]);
            }


            int min_price = priceValues[0];

            for (int i = 1; i < n; i++)
            {


                if (priceValues[i] < min_price)
                    min_price = priceValues[i];


                profit[i] = Math.Max(profit[i - 1],
                           profit[i] + (priceValues[i]
                                  - min_price));
            }
            Console.WriteLine($"Maximum profit is {profit[n - 1]}");
        }
    }
}
