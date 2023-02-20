using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Main;

namespace ConsoleApp2.Main.Masse
{
    public class ConsoleMasse
    {

        double num1;
        double result = 0;
        string unit1 = ConvertConsole2.ConsoleMain.Record.unit1;
        string unit2 = ConvertConsole2.ConsoleMain.Record.unit2;
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


        //Masse/////////////////////////////////////////////////////


        public void CalculMasse()
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
            if (((unit1 == "1" || unit1 == "2" || unit1 == "3" || unit1 == "6" || unit1 == "5" || unit1 == "4" || unit1 == "7" || unit1 == "8" || unit1 == "11" || unit1 == "9" || unit1 == "10") && (unit2 == "1" || unit2 == "2" || unit2 == "3" || unit2 == "4" || unit2 == "5" || unit2 == "6" || unit2 == "7" || unit2 == "8" || unit2 == "9" || unit2 == "10" || unit2 == "11")) || ((unit1 == "tonne" || unit1 == "kilogramme" || unit1 == "gramme" || unit1 == "milligramme" || unit1 == "banane" || unit1 == "eiffel" || unit1 == "tonne longue" || unit1 == "tonne courte" || unit1 == "stone" || unit1 == "livre" || unit1 == "once" || unit1 == "x" || unit1 == "X") && (unit2 == "tonne" || unit2 == "kilogramme" || unit2 == "gramme" || unit2 == "milligramme" || unit2 == "banane" || unit2 == "eiffel" || unit2 == "tonne longue" || unit2 == "tonne courte" || unit2 == "stone" || unit2 == "livre" || unit2 == "once" || unit2 == "x" || unit2 == "X")))
            {

                if (unit1 == "Tonne" || unit1 == "tonne" || unit1 == "1")
                {
                    ratioCalc1 = 1000000;
                }
                if (unit1 == "kilogramme" || unit1 == "kilo" || unit1 == "2")
                {
                    ratioCalc1 = 1000;
                }
                if (unit1 == "gramme" || unit1 == "g" || unit1 == "3")
                {
                    ratioCalc1 = 1;
                }
                if (unit1 == "milligramme" || unit1 == "mg" || unit1 == "6")
                {
                    ratioCalc1 = 0.001;
                }
                if (unit1 == "banane" || unit1 == "Banane" || unit1 == "5")
                {
                    ratioCalc1 = 120;
                }
                if (unit1 == "eiffel" || unit1 == "Eiffel" || unit1 == "4")
                {
                    ratioCalc1 = 10100000000;
                }
                if (unit1 == "tonne longue" || unit1 == "7")
                {
                    ratioCalc1 = 1016000;
                }
                if (unit1 == "tonne courte" || unit1 == "8")
                {
                    ratioCalc1 = 907185;
                }
                if (unit1 == "stone" || unit1 == "Stone" || unit1 == "11")
                {
                    ratioCalc1 = 6350.29;
                }
                if (unit1 == "livre" || unit1 == "Livre" || unit1 == "9")
                {
                    ratioCalc1 = 453.592;
                }
                if (unit1 == "once" || unit1 == "Once" || unit1 == "10")
                {
                    ratioCalc1 = 28.3495;
                }

                //unité de convertion 
                if (unit2 == "Tonne" || unit2 == "tonne" || unit2 == "1")
                {
                    ratioCalc2 = 1000000;
                }
                if (unit2 == "kilogramme" || unit2 == "kilo" || unit2 == "2")
                {
                    ratioCalc2 = 1000;
                }
                if (unit2 == "gramme" || unit2 == "g" || unit2 == "3")
                {
                    ratioCalc2 = 1;
                }
                if (unit2 == "milligramme" || unit2 == "mg" || unit2 == "6")
                {
                    ratioCalc2 = 0.001;
                }
                if (unit2 == "banane" || unit2 == "Banane" || unit2 == "5")
                {
                    ratioCalc2 = 120;
                }
                if (unit2 == "eiffel" || unit2 == "Eiffel" || unit2 == "4")
                {
                    ratioCalc2 = 10100000000;
                }
                if (unit2 == "tonne longue" || unit1 == "tonne" || unit2 == "7")
                {
                    ratioCalc2 = 1016000;
                }
                if (unit2 == "tonne courte" || unit2 == "8")
                {
                    ratioCalc2 = 907185;
                }
                if (unit2 == "stone" || unit2 == "Stone" || unit2 == "11")
                {
                    ratioCalc2 = 6350.29;
                }
                if (unit2 == "livre" || unit2 == "Livre" || unit2 == "9")
                {
                    ratioCalc2 = 453.592;
                }
                if (unit2 == "once" || unit2 == "Once" || unit2 == "10")
                {
                    ratioCalc2 = 28.3495;
                }
                ratio = ratioCalc1 / ratioCalc2;

                result = num1 * ratio;


                Console.WriteLine("Le résultat est : " + result + " .");

            }

        }
    }
}