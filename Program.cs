using System;

namespace ClaseIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Persoana popescu = new Persoana("Popescu", 35, true);
            Persoana iopnescu = new Persoana("Ionescu", 53, true);
            DatePersoana(iopnescu);
        }
    }
}
