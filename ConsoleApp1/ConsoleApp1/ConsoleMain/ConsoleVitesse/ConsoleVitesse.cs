using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Main;


namespace ConsoleApp2.Main.Vitesse
{

    public class ConsoleVitesse
    {

        double num1;
        double result = 0;
        string unit1 = "";
        string unit2 = "";
        double ratio;
        string devise = "";
        double ratioCalc1 = 1;
        double ratioCalc2 = 1;

        public void ListeDeviseVitesse()
        {
            Console.Clear();
            Console.WriteLine("Choisissez votre referentiel entre :");
            Console.WriteLine("Longueur <");
            Console.WriteLine("Masse    < ");
            Console.WriteLine("Temps    < ");
            Console.WriteLine("Vitesse  > Les unitées disponible sont : 1 - metre/seconde");
            Console.WriteLine("                                         2 - metre/heure");
            Console.WriteLine("                                         3 - kilometre/heure");
            Console.WriteLine("                                         4 - kilometre/seconde");
            Console.WriteLine("                                         5 - mile/heure");
            Console.WriteLine("                                         6 - pied/seconde");
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


        //Vitesse////////////////////////////////////////


        public void CalculVitesse()
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
            if (((unit1 == "1" || unit1 == "2" || unit1 == "3" || unit1 == "5" || unit1 == "4" || unit1 == "6") && (unit2 == "1" || unit2 == "2" || unit2 == "3" || unit2 == "5" || unit2 == "4" || unit2 == "6")) || ((unit1 == "metre/seconde" || unit1 == "metre/heure" || unit1 == "kilometre/heure" || unit1 == "mile/heure" || unit1 == "kilometre/seconde" || unit1 == "pied/seconde" || unit1 == "x" || unit1 == "X") && (unit2 == "metre/seconde" || unit2 == "metre/heure" || unit2 == "kilometre/heure" || unit2 == "mile/heure" || unit2 == "kilometre/seconde" || unit2 == "pied/seconde" || unit2 == "x" || unit2 == "X")))
            {


                if (unit1 == "metre/seconde" || unit1 == "1")
                {
                    ratioCalc1 = 0.277778;
                }
                if (unit1 == "metre/heure" || unit1 == "2")
                {
                    ratioCalc1 = 1000.00008;
                }
                if (unit1 == "kilometre/heure" || unit1 == "3")
                {
                    ratioCalc1 = 1;
                }
                if (unit1 == "kilometre/seconde" || unit1 == "4")
                {
                    ratioCalc1 = 0.00028;
                }
                if (unit1 == "mile/heure" || unit1 == "5")
                {
                    ratioCalc1 = 0.62138;
                }
                if (unit1 == "pied/seconde" || unit1 == "6")
                {
                    ratioCalc1 = 0.9114;
                }
                //unité de convertion 

                if (unit2 == "metre/seconde" || unit2 == "1")
                {
                    ratioCalc2 = 0.278;
                }
                if (unit2 == "metre/heure" || unit2 == "2")
                {
                    ratioCalc2 = 1000.00008;
                }
                if (unit2 == "kilometre/heure" || unit2 == "3")
                {
                    ratioCalc2 = 1;
                }
                if (unit2 == "kilometre/seconde" || unit2 == "4")
                {
                    ratioCalc2 = 0.000278;
                }
                if (unit2 == "mile/heure" || unit2 == "5")
                {
                    ratioCalc2 = 0.62138;
                }
                if (unit2 == "pied/seconde" || unit2 == "6")
                {
                    ratioCalc2 = 0.9113;
                }


                ratio = ratioCalc2 / ratioCalc1;
                result = num1 * ratio;

                Console.WriteLine("Le résultat est : " + result + " .");

            }
        }
    }

}
