using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DataStructure.Array
{
    public static class GetPairOfGivenSum
    {
        public static (int,int) GetPair(int sum, int[] items)
        {
            if (items == null) return (-1, -1);
            for (int i = 0; i < items.Length; i++)
            {
                if (sum > items[i])
                {
                    int secondValue = sum - items[i];

                    for (int j = 0; j < items.Length; j++)
                    {
                        if (i != j)
                        {
                            if (items[j] == secondValue)
                                return (i, j);
                        }
                    }
                }
                else if (sum == items[i])
                    return (i, -1);
            }
            return (-1, -1);
        }
    }
}
