using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ConsoleApp2.Main;
using ConvertConsole2.ConsoleMain;

namespace ConsoleApp2.Main.Longueur
{
    public class ConsoleLongueur
    {
        public ConsoleLongueur(Action? afficheResultat, Action? affichePromptInput)
        {
            Record.AfficheResultat = afficheResultat;
            Record.AffichePromptInput = affichePromptInput;
        }

        double ratio;
        double ratioCalc1 = 1;
        double ratioCalc2 = 1;

        public void ListeDeviseLongueur()
        {
            Console.Clear();
            Console.WriteLine("Choisissez votre referentiel entre :");
            Console.WriteLine("Longueur > Les unitées disponible sont : 1 - kilometre");
            Console.WriteLine("                                         2 - eiffel");
            Console.WriteLine("                                         3 - metre");
            Console.WriteLine("                                         4 - banane");
            Console.WriteLine("                                         5 - centimetre");
            Console.WriteLine("                                         6 - millimetre");
            Console.WriteLine("                                         7 - micrometre");
            Console.WriteLine("                                         8 - nanometre");
            Console.WriteLine("                                         9 - mile");
            Console.WriteLine("                                         10 - yard");
            Console.WriteLine("                                         11 - pied");
            Console.WriteLine("                                         12 - pouce");
            Console.WriteLine("Masse    < ");
            Console.WriteLine("Temps    < ");
            Console.WriteLine("Vitesse  < ");
            Console.WriteLine("");
            Console.WriteLine("Appuyer sur [C] pour nettoyer");
            Console.WriteLine("Appuyer sur [X] pour quitter");
        }


        //Longueur/////////////////////////////////////


        public void CalculLongueur()
        {

            if (Record.unit1 == "x" || Record.unit1 == "X" || Record.unit1 == "quitter" || Record.unit1 == "Quitter")
            {
                Console.WriteLine("Vous allez quitter l'application");
                Environment.Exit(0);
            }
            if (Record.unit2 == "c" || Record.unit2 == "C" || Record.unit2 == "clear" || Record.unit2 == "Clear")
            {
                Console.Clear();
                Record.unit1 = "0";
                Record.unit2 = "0";
            }
            if (((Record.unit1 == "1" || Record.unit1 == "2" || Record.unit1 == "3" || Record.unit1 == "4" || Record.unit1 == "5" || Record.unit1 == "6" || Record.unit1 == "7" || Record.unit1 == "8" || Record.unit1 == "9" || Record.unit1 == "10" || Record.unit1 == "11" || Record.unit1 == "12") && (Record.unit2 == "1" || Record.unit2 == "2" || Record.unit2 == "3" || Record.unit2 == "4" || Record.unit2 == "5" || Record.unit2 == "6" || Record.unit2 == "7" || Record.unit2 == "8" || Record.unit2 == "9" || Record.unit2 == "10" || Record.unit2 == "11" || Record.unit2 == "12")) || ((Record.unit1 == "kilometre" || Record.unit1 == "eiffel" || Record.unit1 == "metre" || Record.unit1 == "centimetre" || Record.unit1 == "banane" || Record.unit1 == "millimetre" || Record.unit1 == "micrometre" || Record.unit1 == "mile" || Record.unit1 == "yard" || Record.unit1 == "pied" || Record.unit1 == "pouce" || Record.unit1 == "x" || Record.unit1 == "X") && (Record.unit2 == "kilometre" || Record.unit2 == "eiffel" || Record.unit2 == "metre" || Record.unit2 == "centimetre" || Record.unit2 == "banane" || Record.unit2 == "millimetre" || Record.unit2 == "micrometre" || Record.unit2 == "mile" || Record.unit2 == "yard" || Record.unit2 == "pied" || Record.unit2 == "pouce" || Record.unit2 == "x" || Record.unit2 == "X")))
            {

                if (Record.unit1 == "1" || Record.unit1 == "kilometre")
                {
                    ratioCalc1 = 0;
                    ratioCalc1 = 1000;
                }
                if (Record.unit1 == "2" || Record.unit1 == "eiffel")
                {
                    ratioCalc1 = 0;
                    ratioCalc1 = 324;
                }
                if (Record.unit1 == "3" || Record.unit1 == "metre")
                {
                    ratioCalc1 = 0;
                    ratioCalc1 = 1;
                }
                if (Record.unit1 == "5" || Record.unit1 == "centimetre")
                {
                    ratioCalc1 = 0;
                    ratioCalc1 = 0.01;
                }
                if (Record.unit1 == "4" || Record.unit1 == "banane")
                {
                    ratioCalc1 = 0;
                    ratioCalc1 = 0.12;
                }
                if (Record.unit1 == "6" || Record.unit1 == "millimetre")
                {
                    ratioCalc1 = 0;
                    ratioCalc1 = 0.001;
                }
                if (Record.unit1 == "7" || Record.unit1 == "micrometre")
                {
                    ratioCalc1 = 0;
                    ratioCalc1 = 0.000001;
                }
                if (Record.unit1 == "8" || Record.unit1 == "nanometre")
                {
                    ratioCalc1 = 0;
                    ratioCalc1 = 0.000000001;
                }
                if (Record.unit1 == "9" || Record.unit1 == "mile")
                {
                    ratioCalc1 = 0;
                    ratioCalc1 = 1609.34;
                }
                if (Record.unit1 == "10" || Record.unit1 == "yard")
                {
                    ratioCalc1 = 0;
                    ratioCalc1 = 0.9144;
                }
                if (Record.unit1 == "11" || Record.unit1 == "pied")
                {
                    ratioCalc1 = 0;
                    ratioCalc1 = 0.3048;
                }
                if (Record.unit1 == "12" || Record.unit1 == "pouce")
                {
                    ratioCalc1 = 0;
                    ratioCalc1 = 0.0254;
                }

                //unité de convertion 
                if (Record.unit2 == "1" || Record.unit2 == "kilometre")
                {
                    ratioCalc2 = 0;
                    ratioCalc2 = 1000;
                }
                if (Record.unit2 == "2" || Record.unit2 == "eiffel")
                {
                    ratioCalc2 = 0;
                    ratioCalc2 = 324;
                }
                if (Record.unit2 == "3" || Record.unit2 == "metre")
                {
                    ratioCalc2 = 0;
                    ratioCalc2 = 1;
                }
                if (Record.unit2 == "4" || Record.unit2 == "banane")
                {
                    ratioCalc2 = 0;
                    ratioCalc2 = 0.12;
                }
                if (Record.unit2 == "5" || Record.unit2 == "centimetre")
                {
                    ratioCalc2 = 0.01;
                }
                if (Record.unit2 == "6" || Record.unit2 == "millimetre")
                {
                    ratioCalc2 = 0;
                    ratioCalc2 = 0.001;
                }
                if (Record.unit2 == "7" || Record.unit2 == "micrometre")
                {
                    ratioCalc2 = 0;
                    ratioCalc2 = 0.000001;
                }
                if (Record.unit2 == "8" || Record.unit2 == "nanometre")
                {
                    ratioCalc2 = 0;
                    ratioCalc2 = 0.000000001;
                }
                if (Record.unit2 == "9" || Record.unit2 == "mile")
                {
                    ratioCalc2 = 1609.34;
                }
                if (Record.unit2 == "10" || Record.unit2 == "yard")
                {
                    ratioCalc2 = 0;
                    ratioCalc2 = 0.9144;
                }
                if (Record.unit2 == "11" || Record.unit2 == "pied")
                {
                    ratioCalc2 = 0;
                    ratioCalc2 = 0.3048;
                }
                if (Record.unit2 == "12" || Record.unit2 == "pouce")
                {
                    ratioCalc2 = 0;
                    ratioCalc2 = 0.0254;
                }
                ratio = ratioCalc1 / ratioCalc2;
                Record.result = Record.num1 * ratio;
            }
        }
    }
}