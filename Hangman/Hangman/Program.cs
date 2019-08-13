using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
        Fillimi:
            Random rnd = new Random();
            string[] pergjigjet = {"Australia", "Brazil", "Kili", "Kosova", "Zvicra", "Andorra", "Holanda", "Portugalia",
            "Uruguai", "Bullgaria", "Zimbabve", "Lihtenshtajni", "Gjermania", "Franca", "Meksika", "Egjipti"};

            string y = pergjigjet[rnd.Next(0, 15)];
            // string y = pergjigjet[0];
            y = y.ToLower();
            int tries = 5;
            char[] chA = y.ToCharArray();
            //Console.WriteLine(y);
            for(int i=0; i<y.Length; i++)
            {
                chA[i] = '_';
                Console.Write(chA[i] + " ");
            }
            Console.WriteLine("\nJepeni nje shkronje: ");
        Addres:

            char shkronja = Console.ReadKey().KeyChar;
            
            if (y.Contains(shkronja))
            {
                Console.WriteLine("\nJa ki qellu");
                for (int i = 0; i < y.Length; i++)
                {
                    if (y[i] == shkronja)
                    {
                        chA[i] = shkronja;
                    }
                }
            }
            else
            {
                Console.WriteLine("\nJa ki huq");
                tries--;
            }
            for(int i =0; i<chA.Length; i++)
            {
                Console.Write(chA[i]+" ");
            }
            Console.WriteLine("\nMundesite e mbetura: " + tries + "\n");

            
            if (!(chA.Contains('_')) && tries > 0)
            {
                Console.WriteLine("\nURIME! Keni fituar nje lavatrice!");
                goto Fillimi;
            }
            else if(tries > 0)
            {
                goto Addres;
            }
            else
            {
                Console.WriteLine("Game Over!");
                Console.WriteLine("Shteti qe nuk e qelluat: " + y);
                goto Fillimi; 
            }
            Console.ReadLine();
        }
    }
}
