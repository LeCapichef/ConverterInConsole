using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Main;
using ConvertConsole2.ConsoleMain;

namespace ConsoleApp2.Main.Masse
{
    public class ConsoleMasse
    {
        public ConsoleMasse(Action? afficheResultat, Action? affichePromptInput)
        {
            Record.AfficheResultat = afficheResultat;
            Record.AffichePromptInput = affichePromptInput;
        }

        double ratio;
        double ratioCalc1 = 1;
        double ratioCalc2 = 1;

        public void ListeDeviseMasse()
        {
            Console.Clear();
            Console.WriteLine("Choisissez votre referentiel entre :");
            Console.WriteLine("Longueur < ");
            Console.WriteLine("Masse    > Les unitées disponible sont : 1 - tonne");
            Console.WriteLine("                                         2 - kilogramme");
            Console.WriteLine("                                         3 - gramme");
            Console.WriteLine("                                         4 - eiffel");
            Console.WriteLine("                                         5 - banane");
            Console.WriteLine("                                         6 - milligramme");
            Console.WriteLine("                                         7 - tonne longue");
            Console.WriteLine("                                         8 - tonne courte");
            Console.WriteLine("                                         9 - livre");
            Console.WriteLine("                                         10 - once");
            Console.WriteLine("                                         11 - stone");
            Console.WriteLine("Temps    < ");
            Console.WriteLine("Vitesse  < ");
            Console.WriteLine("");
            Console.WriteLine("Appuyer sur [C] pour nettoyer");
            Console.WriteLine("Appuyer sur [X] pour quitter");
        }

        //Masse////////////////////////////////////////

        public void CalculMasse()
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
            if (((Record.unit1 == "1" || Record.unit1 == "2" || Record.unit1 == "3" || Record.unit1 == "6" || Record.unit1 == "5" || Record.unit1 == "4" || Record.unit1 == "7" || Record.unit1 == "8" || Record.unit1 == "11" || Record.unit1 == "9" || Record.unit1 == "10") && (Record.unit2 == "1" || Record.unit2 == "2" || Record.unit2 == "3" || Record.unit2 == "4" || Record.unit2 == "5" || Record.unit2 == "6" || Record.unit2 == "7" || Record.unit2 == "8" || Record.unit2 == "9" || Record.unit2 == "10" || Record.unit2 == "11")) || ((Record.unit1 == "tonne" || Record.unit1 == "kilogramme" || Record.unit1 == "gramme" || Record.unit1 == "milligramme" || Record.unit1 == "banane" || Record.unit1 == "eiffel" || Record.unit1 == "tonne longue" || Record.unit1 == "tonne courte" || Record.unit1 == "stone" || Record.unit1 == "livre" || Record.unit1 == "once" || Record.unit1 == "x" || Record.unit1 == "X") && (Record.unit2 == "tonne" || Record.unit2 == "kilogramme" || Record.unit2 == "gramme" || Record.unit2 == "milligramme" || Record.unit2 == "banane" || Record.unit2 == "eiffel" || Record.unit2 == "tonne longue" || Record.unit2 == "tonne courte" || Record.unit2 == "stone" || Record.unit2 == "livre" || Record.unit2 == "once" || Record.unit2 == "x" || Record.unit2 == "X")))
            {

                if (Record.unit1 == "Tonne" || Record.unit1 == "tonne" || Record.unit1 == "1")
                {
                    ratioCalc1 = 1000000;
                }
                if (Record.unit1 == "kilogramme" || Record.unit1 == "kilo" || Record.unit1 == "2")
                {
                    ratioCalc1 = 1000;
                }
                if (Record.unit1 == "gramme" || Record.unit1 == "g" || Record.unit1 == "3")
                {
                    ratioCalc1 = 1;
                }
                if (Record.unit1 == "milligramme" || Record.unit1 == "mg" || Record.unit1 == "6")
                {
                    ratioCalc1 = 0.001;
                }
                if (Record.unit1 == "banane" || Record.unit1 == "Banane" || Record.unit1 == "5")
                {
                    ratioCalc1 = 120;
                }
                if (Record.unit1 == "eiffel" || Record.unit1 == "Eiffel" || Record.unit1 == "4")
                {
                    ratioCalc1 = 10100000000;
                }
                if (Record.unit1 == "tonne longue" || Record.unit1 == "7")
                {
                    ratioCalc1 = 1016000;
                }
                if (Record.unit1 == "tonne courte" || Record.unit1 == "8")
                {
                    ratioCalc1 = 907185;
                }
                if (Record.unit1 == "stone" || Record.unit1 == "Stone" || Record.unit1 == "11")
                {
                    ratioCalc1 = 6350.29;
                }
                if (Record.unit1 == "livre" || Record.unit1 == "Livre" || Record.unit1 == "9")
                {
                    ratioCalc1 = 453.592;
                }
                if (Record.unit1 == "once" || Record.unit1 == "Once" || Record.unit1 == "10")
                {
                    ratioCalc1 = 28.3495;
                }

                //unité de convertion 
                if (Record.unit2 == "Tonne" || Record.unit2 == "tonne" || Record.unit2 == "1")
                {
                    ratioCalc2 = 1000000;
                }
                if (Record.unit2 == "kilogramme" || Record.unit2 == "kilo" || Record.unit2 == "2")
                {
                    ratioCalc2 = 1000;
                }
                if (Record.unit2 == "gramme" || Record.unit2 == "g" || Record.unit2 == "3")
                {
                    ratioCalc2 = 1;
                }
                if (Record.unit2 == "milligramme" || Record.unit2 == "mg" || Record.unit2 == "6")
                {
                    ratioCalc2 = 0.001;
                }
                if (Record.unit2 == "banane" || Record.unit2 == "Banane" || Record.unit2 == "5")
                {
                    ratioCalc2 = 120;
                }
                if (Record.unit2 == "eiffel" || Record.unit2 == "Eiffel" || Record.unit2 == "4")
                {
                    ratioCalc2 = 10100000000;
                }
                if (Record.unit2 == "tonne longue" || Record.unit1 == "tonne" || Record.unit2 == "7")
                {
                    ratioCalc2 = 1016000;
                }
                if (Record.unit2 == "tonne courte" || Record.unit2 == "8")
                {
                    ratioCalc2 = 907185;
                }
                if (Record.unit2 == "stone" || Record.unit2 == "Stone" || Record.unit2 == "11")
                {
                    ratioCalc2 = 6350.29;
                }
                if (Record.unit2 == "livre" || Record.unit2 == "Livre" || Record.unit2 == "9")
                {
                    ratioCalc2 = 453.592;
                }
                if (Record.unit2 == "once" || Record.unit2 == "Once" || Record.unit2 == "10")
                {
                    ratioCalc2 = 28.3495;
                }
                ratio = ratioCalc1 / ratioCalc2;
                Record.result = Record.num1 * ratio;
            }
        }
    }
}
