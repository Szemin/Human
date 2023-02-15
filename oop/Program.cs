using oop;

class Program
{
    static void Main()
    {
        Person oliwier = new Person();

        oliwier.FirstName = "Oliwier";
        oliwier.LastName = "Giroud";

        Console.Write($"{oliwier.FirstName} {oliwier.DateOfBirth}");
    }
}