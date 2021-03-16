using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseIntro
{
    class Persoana
    {
        public string NumePersoana { get; set; }
        public Guid Guid { get; set; } = new Guid();
        public int VarstaPersoana { get; set; }
        public bool AreFacultate { get; set; }

        public Persoana(string numePersoana, int varstaPersoana, bool areFacultate)
        {
            NumePersoana = numePersoana;
            VarstaPersoana = varstaPersoana;
            AreFacultate = areFacultate;
        }

        public static void DatePersoana(Persoana persoana)
        {
            Console.WriteLine(persoana.NumePersoana);
            Console.WriteLine(persoana.VarstaPersoana);
            if (persoana.AreFacultate)
            {
                Console.WriteLine("Aceasta  are facultate");
            }
            else
            {
                Console.WriteLine("Aceasta nu are facultate");
            }
        }
    }
}
