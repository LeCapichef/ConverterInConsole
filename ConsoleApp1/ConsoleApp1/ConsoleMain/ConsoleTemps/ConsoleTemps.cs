using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Main;

namespace ConsoleApp1.Main.Temps
{
    public class ConsoleTemps
    {

        double num1 ;
        double result = 0;
        string unit1 = "";
        string unit2 = "";
        double ratio;
        string devise;
        double ratioCalc1 = 1;
        double ratioCalc2 = 1;

        public void ListeDeviseTemps()
        {
            Console.WriteLine("Les unitées disponible sont : 1 - nanoseconde");
            Console.WriteLine("                              2 - microseconde");
            Console.WriteLine("                              3 - milliseconde");
            Console.WriteLine("                              4 - seconde");
            Console.WriteLine("                              5 - minute");
            Console.WriteLine("                              6 - heure");
            Console.WriteLine("                              7 - jour");
            Console.WriteLine("                              8 - semaine");
            Console.WriteLine("                              9 - mois");
            Console.WriteLine("                              10 - annee");
            Console.WriteLine("                              11 - lustre");
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


        //Temps////////////////////////////////////////


        public void CalculTemps()
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
            if (((unit1 == "1" || unit1 == "2" || unit1 == "3" || unit1 == "4" || unit1 == "5" || unit1 == "6" || unit1 == "7" || unit1 == "8" || unit1 == "9" || unit1 == "10" || unit1 == "11") && (unit2 == "1" || unit2 == "2" || unit2 == "3" || unit2 == "4" || unit2 == "5" || unit2 == "3" || unit2 == "7" || unit2 == "8" || unit2 == "9" || unit2 == "10" || unit2 == "11")) || ((unit1 == "nanoseconde" || unit1 == "microseconde" || unit1 == "milliseconde" || unit1 == "seconde" || unit1 == "minute" || unit1 == "heure" || unit1 == "jour" || unit1 == "mois" || unit1 == "annee" || unit1 == "lustre" || unit1 == "semaine" || unit1 == "année" || unit1 == "x" || unit1 == "X") && (unit2 == "nanoseconde" || unit2 == "microseconde" || unit2 == "milliseconde" || unit2 == "seconde" || unit2 == "minute" || unit2 == "heure" || unit2 == "jour" || unit2 == "mois" || unit2 == "annee" || unit2 == "lustre" || unit2 == "semaine" || unit2 == "année" || unit2 == "x" || unit2 == "X")))
            {

                    if (unit1 == "nanoseconde" || unit1 == "1")
                    {
                        ratioCalc1 = 0.000000001;
                    }
                    if (unit1 == "microseconde" || unit1 == "2")
                    {
                        ratioCalc1 = 0.000001;
                    }
                    if (unit1 == "milliseconde" || unit1 == "3")
                    {
                        ratioCalc1 = 0.001;
                    }
                    if (unit1 == "seconde" || unit1 == "4")
                    {
                        ratioCalc1 = 1;
                    }
                    if (unit1 == "minute" || unit1 == "5")
                    {
                        ratioCalc1 = 60;
                    }
                    if (unit1 == "heure" || unit1 == "6")
                    {
                        ratioCalc1 = 3600;
                    }
                    if (unit1 == "jour" || unit1 == "7")
                    {
                        ratioCalc1 = 86400;
                    }
                    if (unit1 == "mois" || unit1 == "9")
                    {
                        ratioCalc1 = 2592000;
                    }
                    if (unit1 == "année" || unit1 == "annee" || unit1 == "10")
                    {
                        ratioCalc1 = 31104000;
                    }
                    if (unit1 == "lustre" || unit1 == "Lustre" || unit1 == "11")
                    {
                        ratioCalc1 = 155520000;
                    }
                    if (unit1 == "semaine" || unit1 == "semaine")
                    {
                        ratioCalc1 = 604800;
                    }

                    //unité de convertion 
                    if (unit2 == "nanoseconde" || unit2 == "1")
                    {
                        ratioCalc2 = 0.000000001;
                    }
                    if (unit2 == "microseconde" || unit2 == "2")
                    {
                        ratioCalc2 = 0.000001;
                    }
                    if (unit2 == "milliseconde" || unit2 == "3")
                    {
                        ratioCalc2 = 0.001;
                    }
                    if (unit2 == "seconde" || unit2 == "4")
                    {
                        ratioCalc2 = 1;
                    }
                    if (unit2 == "minute" || unit2 == "5")
                    {
                        ratioCalc2 = 60;
                    }
                    if (unit2 == "heure" || unit2 == "6")
                    {
                        ratioCalc2 = 3600;
                    }
                    if (unit2 == "jour" || unit2 == "7")
                    {
                        ratioCalc2 = 86400;
                    }
                    if (unit2 == "semaine" || unit2 == "8")
                    {
                        ratioCalc2 = 604800;
                    }
                    if (unit2 == "mois" || unit2 == "9")
                    {
                        ratioCalc2 = 2592000;
                    }
                    if (unit2 == "année" || unit2 == "annee" || unit2 == "10")
                    {
                        ratioCalc2 = 31104000;
                    }
                    if (unit2 == "lustre" || unit2 == "Lustre" || unit2 == "11")
                    {
                        ratioCalc2 = 155520000;
                    }
                    ratio = ratioCalc1 / ratioCalc2;
                    result = num1 * ratio;
                    Console.WriteLine("Le résultat est : " + result + " .");
                    }
                }
            }
        }
    

