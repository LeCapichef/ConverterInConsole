using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Main;
using ConvertConsole2.ConsoleMain;

namespace ConsoleApp2.Main.Temps
{
    public class ConsoleTemps
    {
        public ConsoleTemps(Action? afficheResultat, Action? affichePromptInput)
        {
            Record.AfficheResultat = afficheResultat;
            Record.AffichePromptInput = affichePromptInput;
        }

        double ratio;
        double ratioCalc1 = 1;
        double ratioCalc2 = 1;

        public void ListeDeviseTemps()
        {
            Console.Clear();
            Console.WriteLine("Choisissez votre referentiel entre :");
            Console.WriteLine("Longueur < ");
            Console.WriteLine("Masse    < ");
            Console.WriteLine("Temps    > Les unitées disponible sont : 1 - nanoseconde");
            Console.WriteLine("                                         2 - microseconde");
            Console.WriteLine("                                         3 - milliseconde");
            Console.WriteLine("                                         4 - seconde");
            Console.WriteLine("                                         5 - minute");
            Console.WriteLine("                                         6 - heure");
            Console.WriteLine("                                         7 - jour");
            Console.WriteLine("                                         8 - semaine");
            Console.WriteLine("                                         9 - mois");
            Console.WriteLine("                                         10 - annee");
            Console.WriteLine("                                         11 - lustre");
            Console.WriteLine("Vitesse  < ");
            Console.WriteLine("");
            Console.WriteLine("Appuyer sur [C] pour nettoyer");
            Console.WriteLine("Appuyer sur [X] pour quitter");
        }


        //Temps////////////////////////////////////////


        public void CalculTemps()
        {
            if (Record.unit1 == "x" || Record.unit1 == "X" || Record.unit1 == "quitter" || Record.unit1 == "Quitter")
            {
                Console.WriteLine("Vous allez quitter l'application");
                Environment.Exit(0);
            }
            if (Record.unit2 == "x" || Record.unit2 == "X" || Record.unit2 == "quitter" || Record.unit2 == "Quitter")
            {
                Environment.Exit(0);
            }
            if (Record.unit1 == "c" || Record.unit1 == "C" || Record.unit1 == "clear" || Record.unit1 == "Clear")
            {
                Console.Clear();
            }
            if (Record.unit2 == "c" || Record.unit2 == "C" || Record.unit2 == "clear" || Record.unit2 == "Clear")
            {
                Console.Clear();
                ratioCalc1 = 0;
                ratioCalc2 = 0;
            }
            if (((Record.unit1 == "1" || Record.unit1 == "2" || Record.unit1 == "3" || Record.unit1 == "4" || Record.unit1 == "5" || Record.unit1 == "6" || Record.unit1 == "7" || Record.unit1 == "8" || Record.unit1 == "9" || Record.unit1 == "10" || Record.unit1 == "11") && (Record.unit2 == "1" || Record.unit2 == "2" || Record.unit2 == "3" || Record.unit2 == "4" || Record.unit2 == "5" || Record.unit2 == "3" || Record.unit2 == "7" || Record.unit2 == "8" || Record.unit2 == "9" || Record.unit2 == "10" || Record.unit2 == "11")) || ((Record.unit1 == "nanoseconde" || Record.unit1 == "microseconde" || Record.unit1 == "milliseconde" || Record.unit1 == "seconde" || Record.unit1 == "minute" || Record.unit1 == "heure" || Record.unit1 == "jour" || Record.unit1 == "mois" || Record.unit1 == "annee" || Record.unit1 == "lustre" || Record.unit1 == "semaine" || Record.unit1 == "année" || Record.unit1 == "x" || Record.unit1 == "X") && (Record.unit2 == "nanoseconde" || Record.unit2 == "microseconde" || Record.unit2 == "milliseconde" || Record.unit2 == "seconde" || Record.unit2 == "minute" || Record.unit2 == "heure" || Record.unit2 == "jour" || Record.unit2 == "mois" || Record.unit2 == "annee" || Record.unit2 == "lustre" || Record.unit2 == "semaine" || Record.unit2 == "année" || Record.unit2 == "x" || Record.unit2 == "X")))
            {
                Record.unit_select = false;
                if (Record.unit_select == false)
                {
                    if (Record.unit1 == "nanoseconde" || Record.unit1 == "1")
                    {
                        ratioCalc1 = 0.000000001;
                        Record.unit_select = true;
                    }
                    if (Record.unit1 == "microseconde" || Record.unit1 == "2")
                    {
                        ratioCalc1 = 0.000001;
                        Record.unit_select = true;
                    }
                    if (Record.unit1 == "milliseconde" || Record.unit1 == "3")
                    {
                        ratioCalc1 = 0.001;
                        Record.unit_select = true;
                    }
                    if (Record.unit1 == "seconde" || Record.unit1 == "4")
                    {
                        ratioCalc1 = 1;
                        Record.unit_select = true;
                    }
                    if (Record.unit1 == "minute" || Record.unit1 == "5")
                    {
                        ratioCalc1 = 60;
                        Record.unit_select = true;
                    }
                    if (Record.unit1 == "heure" || Record.unit1 == "6")
                    {
                        ratioCalc1 = 3600;
                        Record.unit_select = true;
                    }
                    if (Record.unit1 == "jour" || Record.unit1 == "7")
                    {
                        ratioCalc1 = 86400;
                        Record.unit_select = true;
                    }
                    if (Record.unit1 == "mois" || Record.unit1 == "9")
                    {
                        ratioCalc1 = 2592000;
                        Record.unit_select = true;
                    }
                    if (Record.unit1 == "année" || Record.unit1 == "annee" || Record.unit1 == "10")
                    {
                        ratioCalc1 = 31104000;
                        Record.unit_select = true;
                    }
                    if (Record.unit1 == "lustre" || Record.unit1 == "Lustre" || Record.unit1 == "11")
                    {
                        ratioCalc1 = 155520000;
                        Record.unit_select = true;
                    }
                    if (Record.unit1 == "semaine" || Record.unit1 == "semaine" || Record.unit1 == "8")
                    {
                        ratioCalc1 = 604800;
                        Record.unit_select = true;
                    }
                }
                if (Record.unit_select == true)
                {
                    //unité de convertion 
                    if (Record.unit2 == "nanoseconde" || Record.unit2 == "1")
                    {
                        ratioCalc2 = 0.000000001;
                    }
                    if (Record.unit2 == "microseconde" || Record.unit2 == "2")
                    {
                        ratioCalc2 = 0.000001;
                    }
                    if (Record.unit2 == "milliseconde" || Record.unit2 == "3")
                    {
                        ratioCalc2 = 0.001;
                    }
                    if (Record.unit2 == "seconde" || Record.unit2 == "4")
                    {
                        ratioCalc2 = 1;
                    }
                    if (Record.unit2 == "minute" || Record.unit2 == "5")
                    {
                        ratioCalc2 = 60;
                    }
                    if (Record.unit2 == "heure" || Record.unit2 == "6")
                    {
                        ratioCalc2 = 3600;
                    }
                    if (Record.unit2 == "jour" || Record.unit2 == "7")
                    {
                        ratioCalc2 = 86400;
                    }
                    if (Record.unit2 == "semaine" || Record.unit2 == "8")
                    {
                        ratioCalc2 = 604800;
                    }
                    if (Record.unit2 == "mois" || Record.unit2 == "9")
                    {
                        ratioCalc2 = 2592000;
                    }
                    if (Record.unit2 == "année" || Record.unit2 == "annee" || Record.unit2 == "10")
                    {
                        ratioCalc2 = 31104000;
                    }
                    if (Record.unit2 == "lustre" || Record.unit2 == "Lustre" || Record.unit2 == "11")
                    {
                        ratioCalc2 = 155520000;
                    }
                    ratio = ratioCalc1 / ratioCalc2;
                    Record.result = Record.num1 * ratio;
                }
            }
        }
    }
}