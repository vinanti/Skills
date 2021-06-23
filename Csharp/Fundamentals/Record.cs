using System;
namespace Records
{
    class Program
    {
public record Person(string FirstName, string LastName);

public static void Main1()
{
    Person person = new("Nancy", "Davolio");
    Console.WriteLine(person);
    // output: Person { FirstName = Nancy, LastName = Davolio }
}
    }
}
