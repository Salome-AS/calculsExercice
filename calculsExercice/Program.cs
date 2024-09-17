using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculsExercice
{
    /// <summary>
    /// traitement des incidents du jeu calculs
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse; // saisie de la réponse de l'utilisateur
            int choix; // saisie du choix de l'utilsiateur
            bool correct = false;

            // affiche le menu et saisi le choix
            choix = 1;
            while (choix != 0)
            {             
                while (!correct)
                {
                    try
                    {
                        Console.WriteLine("Addition ....................... 1");
                        Console.WriteLine("Multiplication ................. 2");
                        Console.WriteLine("Quitter ........................ 0");
                        Console.Write("Choix :                          ");
                        choix = int.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch
                    {
                        Console.WriteLine("Erreur, veuillez saisir un chiffre");
                    }
                }         
                switch (choix) 
                {
                        case 0:
                            break;

                        case 1:
                        // choix de l'addition
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);
                        // saisie de la réponse
                        Console.Write(val1 + " + " + val2 + " = ");
                        reponse = int.Parse(Console.ReadLine());
                        // comparaison avec la bonne réponse
                        solution = val1 + val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                        }
                        Console.WriteLine("Addition ....................... 1");
                        Console.WriteLine("Multiplication ................. 2");
                        Console.WriteLine("Quitter ........................ 0");
                        Console.Write("Choix :                          ");
                        choix = int.Parse(Console.ReadLine());
                        break;

                case 2:
                    // choix de la multiplication
                    val1 = rand.Next(1, 10);
                    val2 = rand.Next(1, 10);
                    // saisie de la réponse
                    Console.Write(val1 + " x " + val2 + " = ");
                    reponse = int.Parse(Console.ReadLine());
                    // comparaison avec la bonne réponse
                    solution = val1 * val2;
                    if (reponse == solution)
                    {
                        Console.WriteLine("Bravo !");
                    }
                    else
                    {
                        Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                    }
                        Console.WriteLine("Addition ....................... 1");
                        Console.WriteLine("Multiplication ................. 2");
                        Console.WriteLine("Quitter ........................ 0");
                        Console.Write("Choix :                          ");
                        choix = int.Parse(Console.ReadLine());
                        break;               

                default:
                    Console.WriteLine("Erreur. Veuillez choisir parmi les propositions suivantes :");
                    Console.WriteLine("Addition ....................... 1");
                    Console.WriteLine("Multiplication ................. 2");
                    Console.WriteLine("Quitter ........................ 0");
                    Console.Write("Choix :                          ");
                    choix = int.Parse(Console.ReadLine());
                    break;

                }
            }
                Console.WriteLine("A bientôt !");
                Console.ReadLine();          
        }
    }
}
