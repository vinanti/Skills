using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Q1029
    {
        static void Main01()
        {
            TwoCitySchedCost(new int[][] { new int[] { 259, 770 }, new int[] { 448, 54 }, new int[] { 926, 667 }, new int[] { 184, 139 }, new int[] { 840, 118 }, new int[] { 577, 469 } });
        }
        public static int TwoCitySchedCost(int[][] costs)
        {
            List<int> cityACost = new List<int>();
            List<int> cityBCost = new List<int>();
            int totalCost = 0;
            foreach (int[] cost in costs)
            {
                cityACost.Add(cost[0]);
                cityBCost.Add(cost[1]);
            }

            int citiesA = costs.Length/2;
            int citiesB = costs.Length/2;
            while (citiesA > 0 || citiesB > 0)
            {
                if (cityACost.Min() < cityBCost.Min() && citiesA>0)
                {
                    int min = cityACost.Min();
                    totalCost += min;
                    int index = cityACost.IndexOf(min);
                    cityACost[index] = int.MaxValue;
                    cityBCost[index] = int.MaxValue;

                    citiesA--;
                }
                else if(cityACost.Min() > cityBCost.Min() && citiesB > 0)
                {
                    int min = cityBCost.Min();
                    totalCost += min;
                    int index = cityBCost.IndexOf(min);
                    cityACost[index] = int.MaxValue;
                    cityBCost[index] = int.MaxValue;

                    citiesB--;
                }
                else
                {
                    if (citiesA > 0)
                    {
                        int min = cityACost.Min();
                        totalCost += min;
                        int index = cityACost.IndexOf(min);
                        cityACost[index] = int.MaxValue;
                        cityBCost[index] = int.MaxValue;

                        citiesA--;
                    }
                    else if (citiesB > 0)
                    {
                        int min = cityBCost.Min();
                        totalCost += min;
                        int index = cityBCost.IndexOf(min);
                        cityACost[index] = int.MaxValue;
                        cityBCost[index] = int.MaxValue;

                        citiesB--;
                    }
                }
            }
            return totalCost;
        }
    }
}
