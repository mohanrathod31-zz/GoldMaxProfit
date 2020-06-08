// C# implementation of the approach 
using System;
using System.Collections.Generic;

class Solution
{

    static int maxProfit(int[] Goldprice, int n, int investmentAmount)
    {
        // Initialise the profit 
        int profit = 0;

        //initialize local minimum to first element's index
        int j = 0;

        // start from second element
        for (int i = 1; i < n; i++ )
        {
            //Update local minimum if decreasing sequence is found
            if(Goldprice[i - 1] > Goldprice[i]) {
                j = i;
             }

            //sell gold if current element is peak
            if(Goldprice[i - 1] <= Goldprice[i] && (i + 1 == n || Goldprice[i] > Goldprice[i + 1]))
            {
                profit += (Goldprice[i] - Goldprice[j]);
            }
        }
        return profit;
    }

    // Calculate 5% GST
    private static int calculateGst(int investmentAmount)
    {
       int amount = (investmentAmount * 5) / 100;
        return amount;
    }

    // Driver code 
    public static void Main(String[] args)
    {
        //Amount Invested
        int investedAmount = 5000;

        //Calculate 5% GST
        int gstAmount = calculateGst(investedAmount);

        // Reamining amount after GST
        int remainingAmount = investedAmount - gstAmount;

        int[] Goldprice = { 3100, 3500, 3200, 3300, 3700, 3600, 3400, 3500 };

        int n = Goldprice.Length;
           
        Console.WriteLine(maxProfit(Goldprice, n, investedAmount));
    }
}


