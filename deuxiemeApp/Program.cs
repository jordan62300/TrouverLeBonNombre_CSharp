using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deuxiemeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = new Random().Next(0, 15);
            int compteur = 0;
            bool trouver = false;

            while (!trouver)
            {
                Console.WriteLine("Devinez le nombre ");
                string saisie = Console.ReadLine();
                int result;
                if (int.TryParse(saisie, out result))
                {
                    if (result == randomNumber)
                    {
                        Console.WriteLine("Vous avez trouvez le bon nombre : " + randomNumber + " en " + compteur + " essai(s)");
                        compteur = 0;
                        trouver = true;
                    }
                    else if (result != randomNumber && result < randomNumber)
                    {
                        Console.WriteLine("Mauvais nombre , mais " + result + " est inférieur au nombre a trouver");
                        compteur++;
                        trouver = false;
                        
                    }
                    else if (result != randomNumber && result > randomNumber)
                    {
                        Console.WriteLine("Mauvais nombre , mais " + result + " est supérieur au nombre a trouver");
                        compteur++;
                        trouver = false;
                    }

                }
                else
                {
                    Console.WriteLine("Nombre non valide");
                }
            }
        }
    }
}
