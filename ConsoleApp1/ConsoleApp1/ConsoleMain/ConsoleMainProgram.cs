// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using ConsoleApp2.Main.Longueur;
using ConsoleApp2.Main.Masse;
using ConsoleApp2.Main.Temps;
using ConsoleApp2.Main.Vitesse;

bool end = false;

ConsoleLongueur longueur = new();
ConsoleVitesse vitesse = new();
ConsoleMasse masse = new();
ConsoleTemps temps = new();

ConsoleListener.MouseEvent += ConsoleListener_MouseEvent;
ConsoleListener.KeyEvent += ConsoleListener_KeyEvent;
ConsoleListener.Start();
FormulaireDevise();
while (ConsoleListener.IsRunning())
{ }




void ConsoleListener_KeyEvent(NativeMethods.KEY_EVENT_RECORD r)
{
    if (r.wVirtualKeyCode == (int)ConsoleKey.Escape)
    {
        ConsoleListener.Stop(); return;
    }
}

void ConsoleListener_MouseEvent(NativeMethods.MOUSE_EVENT_RECORD r)
{
    //Console.WriteLine(string.Format("    X ...............:   {0,4:0}  ", r.dwMousePosition.X));
    //Console.WriteLine(string.Format("    Y ...............:   {0,4:0}  ", r.dwMousePosition.Y));
    //Console.WriteLine(string.Format("    dwButtonState ...: 0x{0:X4}  ", r.dwButtonState));
    listPeak(r);
    unit_peak(r);
}

void listPeak(NativeMethods.MOUSE_EVENT_RECORD r)
{

    if (r.dwButtonState == ConvertConsole2.ConsoleMain.Record.BTN_PRESS)
    {
        switch (r.dwMousePosition.X)
        {
            case ConvertConsole2.ConsoleMain.Record.COL_1:
                break;

            case ConvertConsole2.ConsoleMain.Record.COL_2:
                break;

            case ConvertConsole2.ConsoleMain.Record.COL_3:
                break;
        }
        if ((ConvertConsole2.ConsoleMain.Record.list_Longueur == false) && (ConvertConsole2.ConsoleMain.Record.list_Masse == false) && (ConvertConsole2.ConsoleMain.Record.list_Temps == false) && (ConvertConsole2.ConsoleMain.Record.list_Vitesse == false))
        {

            if (r.dwMousePosition.X == ConvertConsole2.ConsoleMain.Record.COL_1)
            {
                if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE1)
                {

                    longueur.ListeDeviseLongueur();
                    longueur.Formulaire();
                    longueur.CalculLongueur();
                    ConvertConsole2.ConsoleMain.Record.list_Longueur = true;
                }
                if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE2)
                {

                    masse.ListeDeviseMasse();
                    masse.Formulaire();
                    masse.CalculMasse();
                    ConvertConsole2.ConsoleMain.Record.list_Masse = true;
                }
                if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE3)
                {
                    temps.ListeDeviseTemps();
                    temps.Formulaire();
                    temps.CalculTemps();
                    ConvertConsole2.ConsoleMain.Record.list_Temps = true;
                }
                if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE4)
                {
                    vitesse.ListeDeviseVitesse();
                    vitesse.Formulaire();
                    vitesse.CalculVitesse();
                    ConvertConsole2.ConsoleMain.Record.list_Vitesse = true;
                }


            }

            if (r.dwMousePosition.X == ConvertConsole2.ConsoleMain.Record.COL_2)
            {
                if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE7)
                {
                    Console.Clear();
                    Console.WriteLine("Vous allez quittez l'application");
                    Environment.Exit(0);
                }
                if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE6)
                {
                    Console.WriteLine("Clear");
                    Console.Clear();
                    FormulaireDevise();

                }
            }
        }
        else if (r.dwButtonState == ConvertConsole2.ConsoleMain.Record.BTN_PRESS)
        {
            if (r.dwMousePosition.X == ConvertConsole2.ConsoleMain.Record.COL_1)
            {
                if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE1_PEAK)
                {
                    ConvertConsole2.ConsoleMain.Record.list_Longueur = false;
                    FormulaireDevise();
                }
                if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE2_PEAK)
                {
                    ConvertConsole2.ConsoleMain.Record.list_Masse = false;
                    FormulaireDevise();
                }
                if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE3_PEAK)
                {
                    ConvertConsole2.ConsoleMain.Record.list_Temps = false;
                    FormulaireDevise();
                }
                if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE4_PEAK)
                {
                    ConvertConsole2.ConsoleMain.Record.list_Vitesse = false;
                    FormulaireDevise();
                }


            }

            if ((ConvertConsole2.ConsoleMain.Record.list_Longueur == true) && (ConvertConsole2.ConsoleMain.Record.list_Masse == false) && (ConvertConsole2.ConsoleMain.Record.list_Temps == false) && (ConvertConsole2.ConsoleMain.Record.list_Vitesse == false))
            {
                if (r.dwMousePosition.X == ConvertConsole2.ConsoleMain.Record.COL_2)
                {
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE7_PEAK_L)
                    {
                        Console.Clear();
                        Console.WriteLine("Vous allez quittez l'application");
                        Environment.Exit(0);
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE6_PEAK_L)
                    {
                        Console.WriteLine("Clear");
                        Console.Clear();
                        ConvertConsole2.ConsoleMain.Record.list_Masse = false;
                        FormulaireDevise();

                    }
                }

            }

            if (r.dwMousePosition.X == ConvertConsole2.ConsoleMain.Record.COL_1)
            {
                if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE1_PEAK)
                {
                    Console.WriteLine("Clear");
                    Console.Clear();
                    ConvertConsole2.ConsoleMain.Record.list_Masse = false;
                    FormulaireDevise();
                }
            }



            if ((ConvertConsole2.ConsoleMain.Record.list_Longueur == false) && (ConvertConsole2.ConsoleMain.Record.list_Masse == true) && (ConvertConsole2.ConsoleMain.Record.list_Temps == false) && (ConvertConsole2.ConsoleMain.Record.list_Vitesse == false))
            {
                if (r.dwMousePosition.X == ConvertConsole2.ConsoleMain.Record.COL_2)
                {
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE7_PEAK_M)
                    {
                        Console.Clear();
                        Console.WriteLine("Vous allez quittez l'application");
                        Environment.Exit(0);
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE6_PEAK_M)
                    {
                        Console.WriteLine("Clear");
                        Console.Clear();
                        ConvertConsole2.ConsoleMain.Record.list_Masse = false;
                        FormulaireDevise();

                    }
                }

            }

            if (r.dwMousePosition.X == ConvertConsole2.ConsoleMain.Record.COL_1)
            {
                if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE2_PEAK)
                {
                    Console.WriteLine("Clear");
                    Console.Clear();
                    ConvertConsole2.ConsoleMain.Record.list_Masse = false;
                    FormulaireDevise();
                }
            }

            if ((ConvertConsole2.ConsoleMain.Record.list_Longueur == false) && (ConvertConsole2.ConsoleMain.Record.list_Masse == false) && (ConvertConsole2.ConsoleMain.Record.list_Temps == true) && (ConvertConsole2.ConsoleMain.Record.list_Vitesse == false))
            {
                if (r.dwMousePosition.X == ConvertConsole2.ConsoleMain.Record.COL_2)
                {
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE7_PEAK_T)
                    {
                        Console.Clear();
                        Console.WriteLine("Vous allez quittez l'application");
                        Environment.Exit(0);
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE6_PEAK_T)
                    {
                        Console.WriteLine("Clear");
                        Console.Clear();
                        ConvertConsole2.ConsoleMain.Record.list_Temps = false;
                        FormulaireDevise();

                    }
                }
            }

            if (r.dwMousePosition.X == ConvertConsole2.ConsoleMain.Record.COL_1)
            {
                if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE3_PEAK)
                {
                    Console.WriteLine("Clear");
                    Console.Clear();
                    ConvertConsole2.ConsoleMain.Record.list_Temps = false;
                    FormulaireDevise();
                }
            }


            if ((ConvertConsole2.ConsoleMain.Record.list_Longueur == false) && (ConvertConsole2.ConsoleMain.Record.list_Masse == false) && (ConvertConsole2.ConsoleMain.Record.list_Temps == false) && (ConvertConsole2.ConsoleMain.Record.list_Vitesse == true))
            {
                if (r.dwMousePosition.X == ConvertConsole2.ConsoleMain.Record.COL_2)
                {
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE7_PEAK_V)
                    {
                        Console.Clear();
                        Console.WriteLine("Vous allez quittez l'application");
                        Environment.Exit(0);
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE6_PEAK_V)
                    {
                        Console.WriteLine("Clear");
                        Console.Clear();
                        ConvertConsole2.ConsoleMain.Record.list_Vitesse = false;
                        FormulaireDevise();

                    }
                }

            }

            if (r.dwMousePosition.X == ConvertConsole2.ConsoleMain.Record.COL_1)
            {
                if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE4_PEAK)
                {
                    Console.WriteLine("Clear");
                    Console.Clear();
                    ConvertConsole2.ConsoleMain.Record.list_Vitesse = false;
                    FormulaireDevise();
                }
            }

        }
    }
}

void FormulaireDevise()
{
    Console.WriteLine("Choisissez votre referentiel entre :");
    Console.WriteLine("Longueur < ");
    Console.WriteLine("Masse    < ");
    Console.WriteLine("Temps    < ");
    Console.WriteLine("Vitesse  < ");
    Console.WriteLine("");
    Console.WriteLine("Appuyer sur [C] pour nettoyer");
    Console.WriteLine("Appuyer sur [X] pour quitter");
}


void Formulaire()
{
    Console.Write("1er - le nombre à convertir : ");
    ConvertConsole2.ConsoleMain.Record.num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("2ieme - l'unité de base à convertir : ");
    ConvertConsole2.ConsoleMain.Record.unit1 = Console.ReadLine();
    Console.Write("3ieme - l'unité de convertion : ");
    ConvertConsole2.ConsoleMain.Record.unit2 = Console.ReadLine();
}



void unit_peak(NativeMethods.MOUSE_EVENT_RECORD r)
{
    if (r.dwMousePosition.X == ConvertConsole2.ConsoleMain.Record.COL_3)
    {
        if (ConvertConsole2.ConsoleMain.Record.list_Longueur == true)
        {
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE1_SELECT_L)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "kilometre"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "kilometre"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE2_SELECT_L)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "eiffel"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "eiffel"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE3_SELECT_L)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "metre"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "metre"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE4_SELECT_L)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "banane"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "banane"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE5_SELECT_L)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "centimetre"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "centimetre"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE6_SELECT_L)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "millimetre"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "millimetre"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE7_SELECT_L)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "micrometre"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "micrometre"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE8_SELECT_L)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "nanometre"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "nanometre"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE9_SELECT_L)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "mile"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "mile"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE10_SELECT_L)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "yard"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "yard"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE11_SELECT_L)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "pied"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "pied"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE12_SELECT_L)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "pouce"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "pouce"; return; }
            }
        }
        if (ConvertConsole2.ConsoleMain.Record.list_Masse == true)
        {
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE1_SELECT_M)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "tonne"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "tonne"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE2_SELECT_M)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "kilogramme"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "kilogramme"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE3_SELECT_M)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "gramme"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "gramme"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE4_SELECT_M)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "eiffel"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "eiffel"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE5_SELECT_M)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "banane"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "banane"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE6_SELECT_M)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "milligramme"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "milligramme"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE7_SELECT_M)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "tonne longue"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "tonne longue"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE8_SELECT_M)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "tonne courte"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "tonne courte"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE9_SELECT_M)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "livre"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "livre"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE10_SELECT_M)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "once"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "once"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE11_SELECT_M)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "stone"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "stone"; return; }
            }
        }
        if (ConvertConsole2.ConsoleMain.Record.list_Temps == true)
        {
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE1_SELECT_T)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "nanoseconde"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "nanoseconde"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE2_SELECT_T)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "microseconde"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "microseconde"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE3_SELECT_T)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "milliseconde"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "milliseconde"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE4_SELECT_T)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "seconde"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "seconde"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE5_SELECT_T)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "minute"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "minute"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE6_SELECT_T)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "heure"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "heure"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE7_SELECT_T)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "jour"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "jour"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE8_SELECT_T)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "semaine"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "semaine"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE9_SELECT_T)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "mois"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "mois"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE10_SELECT_T)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "annee"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "annee"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE11_SELECT_T)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "lustre"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "lustre"; return; }
            }
        }
        if (ConvertConsole2.ConsoleMain.Record.list_Vitesse == true)
        {
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE1_SELECT_V)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "metre/seconde"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "metre/seconde"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE2_SELECT_V)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "metre/heure"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "metre/heure"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE3_SELECT_V)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "kilometre/heure"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "kilometre/heure"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE4_SELECT_V)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "kilometre/seconde"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "kilometre/seconde"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE5_SELECT_V)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "mile/heure"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "mile/heure"; return; }
            }
            if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE6_SELECT_V)
            {
                if (ConvertConsole2.ConsoleMain.Record.unit_select = true) { ConvertConsole2.ConsoleMain.Record.unit2 = "pied/seconde"; return; }
                else { ConvertConsole2.ConsoleMain.Record.unit1 = "pied/seconde"; return; }
            }
        }
    }
}