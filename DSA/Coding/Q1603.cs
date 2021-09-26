using System;

namespace Coding_Q1603
{
    class Q1603
    {
        static void Main1603()
        {
            ParkingSystem obj = new ParkingSystem(1, 1, 0);
            Console.WriteLine(obj.AddCar(1));
            Console.WriteLine(obj.AddCar(2));
            Console.WriteLine(obj.AddCar(3));
            Console.WriteLine(obj.AddCar(1));
        }
    }
    public class ParkingSystem
    {
        int Big = 0;
        int Medium = 0;
        int Small = 0;
        public ParkingSystem(int big, int medium, int small)
        {
            Big = big;
            Medium = medium;
            Small = small;
        }

        public bool AddCar(int carType)
        {
            if (carType == 1 && Small > 0)
            {
                Small--;
                return true;
            }
            else if (carType == 2 && Medium > 0)
            {
                Medium--;
                return true;
            }
            else if (carType == 3 && Big > 0)
            {
                Big--;
                return true;
            }
            return false;
        }
    }
}
