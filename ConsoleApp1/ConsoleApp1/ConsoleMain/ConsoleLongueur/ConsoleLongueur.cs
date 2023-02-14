using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Main;

namespace ConsoleApp1.Main.Longueur
{
    public class ConsoleLongueur
    {

        double num1;
        double result = 0;
        string unit1 = "";
        string unit2 = "";
        double ratio;
        string devise;
        double ratioCalc1 = 1;
        double ratioCalc2 = 1;

        public void ListeDeviseLongueur()
        {
            Console.WriteLine("Les unitées disponible sont : 1 - kilometre");
            Console.WriteLine("                              2 - eiffel");
            Console.WriteLine("                              3 - metre");
            Console.WriteLine("                              4 - banane");
            Console.WriteLine("                              5 - centimetre");
            Console.WriteLine("                              6 - millimetre");
            Console.WriteLine("                              7 - micrometre");
            Console.WriteLine("                              8 - nanometre");
            Console.WriteLine("                              9 - mile");
            Console.WriteLine("                              10 - yard");
            Console.WriteLine("                              11 - pied");
            Console.WriteLine("                              12 - pouce");
            Console.WriteLine("                              X - Quitter");
            Console.WriteLine("                              C - Nettoyer");

        }

        public void Formulaire()
        {
            Console.Write("1er - le nombre à convertir : ");
            while (double.TryParse(Console.ReadLine(), out num1) == false)
            {
                Console.Write("1er - le nombre à convertir : ");
            }
            //num1 = Convert.ToInt64(Console.ReadLine());
            Console.Write("2ieme - l'unité de base à convertir : ");
            unit1 = Console.ReadLine();
            Console.Write("3ieme - l'unité de convertion : ");
            unit2 = Console.ReadLine();

        }


        public void CalculLongueur()
        {
            if (unit1 == "x" || unit1 == "X" || unit1 == "quitter" || unit1 == "Quitter")
            {
                Console.WriteLine("Vous allez quitter l'application");
                Environment.Exit(0);
            }
            if (unit2 == "x" || unit2 == "X" || unit2 == "quitter" || unit2 == "Quitter")
            {
                Environment.Exit(0);
            }
            if (unit1 == "c" || unit1 == "C" || unit1 == "clear" || unit1 == "Clear")
            {
                Console.Clear();
            }
            if (unit2 == "c" || unit2 == "C" || unit2 == "clear" || unit2 == "Clear")
            {
                Console.Clear();
            }
            if (((unit1 == "1" || unit1 == "2" || unit1 == "3" || unit1 == "4" || unit1 == "5" || unit1 == "6" || unit1 == "7" || unit1 == "8" || unit1 == "9" || unit1 == "10" || unit1 == "11" || unit1 == "12") && (unit2 == "1" || unit2 == "2" || unit2 == "3" || unit2 == "4" || unit2 == "5" || unit2 == "6" || unit2 == "7" || unit2 == "8" || unit2 == "9" || unit2 == "10" || unit2 == "11" || unit2 == "12")) || ((unit1 == "kilometre" || unit1 == "eiffel" || unit1 == "metre" || unit1 == "centimetre" || unit1 == "banane" || unit1 == "millimetre" || unit1 == "micrometre" || unit1 == "mile" || unit1 == "yard" || unit1 == "pied" || unit1 == "pouce" || unit1 == "x" || unit1 == "X") && (unit2 == "kilometre" || unit2 == "eiffel" || unit2 == "metre" || unit2 == "centimetre" || unit2 == "banane" || unit2 == "millimetre" || unit2 == "micrometre" || unit2 == "mile" || unit2 == "yard" || unit2 == "pied" || unit2 == "pouce" || unit2 == "x" || unit2 == "X")))
            {

                    if (unit1 == "1" || unit1 == "kilometre")
                    {
                        ratioCalc1 = 1000;
                    }
                    if (unit1 == "2" || unit1 == "eiffel")
                    {
                        ratioCalc1 = 324;
                    }
                    if (unit1 == "3" || unit1 == "metre")
                    {
                        ratioCalc1 = 1;
                    }
                    if (unit1 == "5" || unit1 == "centimetre")
                    {
                        ratioCalc1 = 0.01;
                    }
                    if (unit1 == "4" || unit1 == "banane")
                    {
                        ratioCalc1 = 0.12;
                    }
                    if (unit1 == "6" || unit1 == "millimetre")
                    {
                        ratioCalc1 = 0.001;
                    }
                    if (unit1 == "7" || unit1 == "micrometre")
                    {
                        ratioCalc1 = 0.000001;
                    }
                    if (unit1 == "8" || unit1 == "nanometre")
                    {
                        ratioCalc1 = 0.000000001;
                    }
                    if (unit1 == "9" || unit1 == "mile")
                    {
                        ratioCalc1 = 1609.34;
                    }
                    if (unit1 == "10" || unit1 == "yard")
                    {
                        ratioCalc1 = 0.9144;
                    }
                    if (unit1 == "11" || unit1 == "pied")
                    {
                        ratioCalc1 = 0.3048;
                    }
                    if (unit1 == "12" || unit1 == "pouce")
                    {
                        ratioCalc1 = 0.0254;
                    }

                    //unité de convertion 
                    if (unit2 == "1" || unit2 == "kilometre")
                    {
                        ratioCalc2 = 1000;
                    }
                    if (unit2 == "2" || unit2 == "eiffel")
                    {
                        ratioCalc2 = 324;
                    }
                    if (unit2 == "3" || unit2 == "metre")
                    {
                        ratioCalc2 = 1;
                    }
                    if (unit2 == "4" || unit2 == "banane")
                    {
                        ratioCalc2 = 0.12;
                    }
                    if (unit2 == "5" || unit2 == "centimetre")
                    {
                        ratioCalc2 = 0.01;
                    }
                    if (unit2 == "6" || unit2 == "millimetre")
                    {
                        ratioCalc2 = 0.001;
                    }
                    if (unit2 == "7" || unit2 == "micrometre")
                    {
                        ratioCalc2 = 0.000001;
                    }
                    if (unit2 == "8" || unit2 == "nanometre")
                    {
                        ratioCalc2 = 0.000000001;
                    }
                    if (unit2 == "9" || unit2 == "mile")
                    {
                        ratioCalc2 = 1609.34;
                    }
                    if (unit2 == "10" || unit2 == "yard")
                    {
                        ratioCalc2 = 0.9144;
                    }
                    if (unit2 == "11" || unit2 == "pied")
                    {
                        ratioCalc2 = 0.3048;
                    }
                    if (unit2 == "12" || unit2 == "pouce")
                    {
                        ratioCalc2 = 0.0254;
                    }
                    ratio = ratioCalc1 / ratioCalc2;

                    result = num1 * ratio;


                    Console.WriteLine("Le résultat est : " + result + " .");
                }
            }
        }
    }
