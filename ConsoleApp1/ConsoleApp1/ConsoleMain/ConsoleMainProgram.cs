// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System;
using ConsoleApp1.Main;
using ConsoleApp1.Main.Longueur;
using ConsoleApp1.Main.Masse;
using ConsoleApp1.Main.Temps;
using ConsoleApp1.Main.Vitesse;

bool end = false;

ConsoleLongueur longueur = new();
ConsoleVitesse vitesse = new();
ConsoleMasse masse = new();
ConsoleTemps temps = new();
double num1;
double result = 0;
string unit1 = "";
string unit2 = "";
double ratio;
string devise;
double ratioCalc1 = 1;
double ratioCalc2 = 1;




//var key = Console.ReadKey(true);
//if (key.Key == ConsoleKey.Z)
//{
//    end = true;
//}




FormulaireDevise();

while (true) {

    //test de verification////////////////////////////////
    if (devise == "Longueur" || devise == "longueur" || devise == "Vitesse" || devise == "vitesse" || devise == "Masse" || devise == "masse" || devise == "Temps" || devise == "temps" || devise == "x" || devise == "X" || devise == "quitter" || devise == "Quitter" || devise == "c" || devise == "C" || devise == "Clear" || devise == "clear")
    {



//Vitesse/////////////////////////////////////////////


    if (devise == "Vitesse" || devise == "vitesse")
    {
        vitesse.ListeDeviseVitesse();
        vitesse.Formulaire();
        vitesse.CalculVitesse();
    }


    //Longueur////////////////////////////////////////////


    if (devise == "Longueur" || devise == "longueur")
    {
        longueur.ListeDeviseLongueur();
        longueur.Formulaire();
        longueur.CalculLongueur();
    }


    


    //Masse///////////////////////////////////////////////


    if (devise == "Masse" || devise == "masse")
    {
        masse.ListeDeviseMasse();
        masse.Formulaire();
        masse.CalculMasse();
    }


    //Temps///////////////////////////////////////////////


    if (devise == "Temps" || devise == "temps")
    {
        temps.ListeDeviseTemps();
        temps.Formulaire();
        temps.CalculTemps();
    }




    if ( devise == "x" || devise == "X")
        {
            Console.WriteLine("Vous allez quittez l'application");
            Environment.Exit(0);
        }



    if ( devise == "c" || devise == "C" || devise == "Clear" || devise == "clear")
        {
            Console.WriteLine("Clear");
            Console.Clear();
        }
}  
if (devise != "Longueur" || devise != "longueur" || devise != "Vitesse" || devise != "vitesse" || devise != "Masse" || devise != "masse" || devise != "Temps" || devise != "temps" || devise != "x" || devise != "X" || devise == "quitter" || devise == "Quitter" || devise != "c" || devise != "C" || devise != "Clear" || devise != "clear")
    {
        Console.WriteLine("Réessayer");
        FormulaireDevise();
    }
}



void FormulaireDevise()
{
    Console.WriteLine("Choisissez votre referentiel entre :");
    Console.WriteLine("Longueur");
    Console.WriteLine("Masse");
    Console.WriteLine("Temps");
    Console.WriteLine("Vitesse");
    Console.WriteLine("");
    Console.WriteLine("Appuyer sur [C] pour nettoyer");
    Console.WriteLine("Appuyer sur [X] pour quitter");
    devise = Console.ReadLine();
}


void Formulaire()
{
    Console.Write("1er - le nombre à convertir : ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("2ieme - l'unité de base à convertir : ");
    unit1 = Console.ReadLine();
    Console.Write("3ieme - l'unité de convertion : ");
    unit2 = Console.ReadLine();
}
