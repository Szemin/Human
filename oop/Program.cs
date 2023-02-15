using oop;

class Program
{
    static void Main()
    {
        Person oliwier = new Person();

        oliwier.FirstName = "Oliwier";
        oliwier.LastName = "Giroud";
        oliwier.SetDateOfBirth(new DateTime(2002,4,4));
        Console.WriteLine($"{oliwier.FirstName} {oliwier.LastName} {oliwier.GetDateOfBirth()}");
    }
}