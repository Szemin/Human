using oop;

class Program
{
    static void Main()
    {
        Person oliwier = new Person("Oliwier", "Giroud");

        //oliwier.FirstName = "Oliwier";
        //oliwier.LastName = "Giroud";
        oliwier.SetDateOfBirth(new DateTime(2002,4,4));
        //Console.WriteLine($"{oliwier.FirstName} {oliwier.LastName} {oliwier.GetDateOfBirth()}"); wywołanie bez metody SayHi

        oliwier.SayHi();  //wywołanie powitania z imieniem nazwiskiem i datą urodzenia bez wypisywania tego w głównej metodzie



        oliwier.ContactNumber = "997420997";      // uproszczone pozyskanie danych 

        Console.WriteLine(oliwier.ContactNumber);

        Person pason = new Person(new DateTime(1997,1,2),"Pason","Pount"); //drugi obiekt typu person pason pount utworzony z drugiego konstruktora

        pason.SayHi();



        oliwier.DateOfBirth = new DateTime(2002, 1, 1);
        oliwier.SayHi(); //Console.WriteLine(oliwier.DateOfBirth); 

    }
}