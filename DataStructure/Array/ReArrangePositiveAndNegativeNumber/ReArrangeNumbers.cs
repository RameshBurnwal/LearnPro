using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Array.ReArrangePositiveAndNegativeNumber
{
    public class ReArrangeNumbers
    {
        //Input
        //{ -1, 2, -3, 4, 5, 6, -7, 8, 9 }
        //{ -1, 2, -3, 4, 11, 5, 6, -7, 8, 9, 13 }
        //{ -1, 2, -3, 4, 5, 6, -7, 8, 9,-5,-2,-6,-8 }
        int[] items = new int[] { -1, 2, -3, 4, 5, 6, -7, 8, 9 };

        //Output
        //{9, -7, 8, -3, 5, -1, 6, 4, 2}
        //{13, -7, 11, -3, 9, -1, 8, 6, 5, 4, 2 }
        //{9, -8, 8, -7, 5, -6, 6, -5, 4, -3, 2,-2, -1}


        public static int[] Rearrange()
        {
            int[] items = new int[] { -1, 2, -3, 4, 5, 6, -7, 8, 9 };
            for (int i = 1; i <= items.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (items[i - 1] < 0)
                        continue;
                    else
                    {

                        for (int j = items.Length - 1; j >= 0; j--)
                        {
                            if (items[j] < 0)
                            {
                                int temp = items[i - 1];
                                items[i - 1] = items[j];
                                items[j] = temp;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    if (items[i - 1] > 0)
                        continue;
                    else
                    {

                        for (int j = items.Length - 1; j >= 0; j--)
                        {
                            if (items[j] > 0)
                            {
                                int temp = items[i - 1];
                                items[i - 1] = items[j];
                                items[j] = temp;
                                break;
                            }
                        }
                    }

                }

            }
            return items;
        }
    }
}
