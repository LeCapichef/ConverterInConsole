using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Main;
using ConvertConsole2.ConsoleMain;

namespace ConsoleApp2.Main.Vitesse
{
    public class ConsoleVitesse
    {
        public ConsoleVitesse(Action? afficheResultat, Action? affichePromptInput)
        {
            Record.AfficheResultat = afficheResultat;
            Record.AffichePromptInput = affichePromptInput;
        }

        double ratio;
        double ratioCalc1 = 1;
        double ratioCalc2 = 1;

        public void ListeDeviseVitesse()
        {
            Console.Clear();
            Console.WriteLine("Choisissez votre referentiel entre :");
            Console.WriteLine("Longueur <");
            Console.WriteLine("Masse    < ");
            Console.WriteLine("Temps    < ");
            Console.WriteLine("Vitesse  > Les unitées disponible sont : 1 - metre/seconde (3.6 km/h)");
            Console.WriteLine("                                         2 - metre/heure (3 600 km/h)");
            Console.WriteLine("                                         3 - kilometre/heure (1 km/h)");
            Console.WriteLine("                                         4 - kilometre/seconde (3 600 km/h)");
            Console.WriteLine("                                         5 - mile/heure (1.609 km/h)");
            Console.WriteLine("                                         6 - pied/seconde (1.097 km/h)");
            Console.WriteLine("");
            Console.WriteLine("Appuyer sur [C] pour nettoyer");
            Console.WriteLine("Appuyer sur [X] pour quitter");
        }


        //Vitesse//////////////////////////////////////


        public void CalculVitesse()
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
                ratioCalc1 = 0;
                ratioCalc2 = 0;
            }
            if (Record.unit2 == "c" || Record.unit2 == "C" || Record.unit2 == "clear" || Record.unit2 == "Clear")
            {
                Console.Clear();
                ratioCalc1 = 0;
                ratioCalc2 = 0;
            }
            if (((Record.unit1 == "1" || Record.unit1 == "2" || Record.unit1 == "3" || Record.unit1 == "5" || Record.unit1 == "4" || Record.unit1 == "6") && (Record.unit2 == "1" || Record.unit2 == "2" || Record.unit2 == "3" || Record.unit2 == "5" || Record.unit2 == "4" || Record.unit2 == "6")) || ((Record.unit1 == "metre/seconde" || Record.unit1 == "metre/heure" || Record.unit1 == "kilometre/heure" || Record.unit1 == "mile/heure" || Record.unit1 == "kilometre/seconde" || Record.unit1 == "pied/seconde" || Record.unit1 == "x" || Record.unit1 == "X") && (Record.unit2 == "metre/seconde" || Record.unit2 == "metre/heure" || Record.unit2 == "kilometre/heure" || Record.unit2 == "mile/heure" || Record.unit2 == "kilometre/seconde" || Record.unit2 == "pied/seconde" || Record.unit2 == "x" || Record.unit2 == "X")))
            {
                Record.unit_select = false;
                if (Record.unit_select == false)
                {

                    if (Record.unit1 == "metre/seconde" || Record.unit1 == "1")
                    {
                        ratioCalc1 = 0.277778;
                        Record.unit_select = true;
                    }
                    if (Record.unit1 == "metre/heure" || Record.unit1 == "2")
                    {
                        ratioCalc1 = 1000.00008;
                        Record.unit_select = true;
                    }
                    if (Record.unit1 == "kilometre/heure" || Record.unit1 == "3")
                    {
                        ratioCalc1 = 1;
                        Record.unit_select = true;
                    }
                    if (Record.unit1 == "kilometre/seconde" || Record.unit1 == "4")
                    {
                        ratioCalc1 = 0.00028;
                        Record.unit_select = true;
                    }
                    if (Record.unit1 == "mile/heure" || Record.unit1 == "5")
                    {
                        ratioCalc1 = 0.62138;
                        Record.unit_select = true;
                    }
                    if (Record.unit1 == "pied/seconde" || Record.unit1 == "6")
                    {
                        ratioCalc1 = 0.9114;
                        Record.unit_select = true;
                    }
                }
                    //unité de convertion 
                    if (Record.unit_select == true)
                    {
                        if (Record.unit2 == "metre/seconde" || Record.unit2 == "1")
                        {
                            ratioCalc2 = 0.278;
                        }
                        if (Record.unit2 == "metre/heure" || Record.unit2 == "2")
                        {
                            ratioCalc2 = 1000.0000;
                        }
                        if (Record.unit2 == "kilometre/heure" || Record.unit2 == "3")
                        {
                            ratioCalc2 = 1;
                        }
                        if (Record.unit2 == "kilometre/seconde" || Record.unit2 == "4")
                        {
                            ratioCalc2 = 0.000278;
                        }
                        if (Record.unit2 == "mile/heure" || Record.unit2 == "5")
                        {
                            ratioCalc2 = 0.62138;
                        }
                        if (Record.unit2 == "pied/seconde" || Record.unit2 == "6")
                        {
                            ratioCalc2 = 0.9113;
                        }
                        ratio = ratioCalc2 / ratioCalc1;
                        Record.result = Record.num1 * ratio;
                    }
                }
        }
    }
}
