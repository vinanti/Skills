using System;
//#define PI

namespace myConsoleApp
{
    class ObjectInitializer
    {
        int age;
        string name;
        char gender;
        static void Main12(string[] args)
        {
            ObjectInitializer O1 = new ObjectInitializer { name = "Vinanti", gender = 'F', age = 35};
            System.Console.WriteLine(O1.name + O1.age + O1.gender);
        }
    }
}