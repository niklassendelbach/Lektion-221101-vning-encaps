using System;

namespace Lektion_221101_övning_encaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.Id = 100;
            C1.FirstName = "Niklas";
            C1.LastName = "Sendelbach";
            C1.Email = "niklas@sendelbach.se";
            C1.printInfo();
            Console.WriteLine(new string('~', 30));
            Customer C2 = new Customer();
            C2.Id = 110;
            C2.FirstName = "Belle";
            C2.LastName = "Sendelbach";
            C2.Email = "belle@sendelbach.se";
            C2.printInfo();
            Console.WriteLine(new string('~', 30));
            Customer C3 = new Customer();
            C3.Id = -1;
            C3.FirstName = null;
            C3.LastName = null;
            C3.Email = null;
            C3.printInfo();



        }
    }
}
