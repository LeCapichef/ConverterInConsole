// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using ConsoleApp2.Main.Longueur;
using ConsoleApp2.Main.Masse;
using ConsoleApp2.Main.Temps;
using ConsoleApp2.Main.Vitesse;
using ConvertConsole2.ConsoleMain;

ConsoleLongueur longueur = new(Formulaire, SaisieNombre);
ConsoleVitesse vitesse = new(Formulaire, SaisieNombre);
ConsoleMasse masse = new(Formulaire, SaisieNombre);
ConsoleTemps temps = new(Formulaire, SaisieNombre);

ConsoleListener.MouseEvent += ConsoleListener_MouseEvent;
ConsoleListener.KeyEvent += ConsoleListener_KeyEvent;
ConsoleListener.Start();
FormulaireDevise();

while (ConsoleListener.IsRunning())
{ }

void ConsoleListener_KeyEvent(NativeMethods.KEY_EVENT_RECORD r)
{
    if (r.wVirtualKeyCode == (int)ConsoleKey.X)
    {
        ConsoleListener.Stop(); return;
    }
    if (r.wVirtualKeyCode == (int)ConsoleKey.C)
    {
        Console.Clear();
        FormulaireDevise();
    }
}

void ConsoleListener_MouseEvent(NativeMethods.MOUSE_EVENT_RECORD r)
{
    //Console.WriteLine(string.Format("    X ...............:   {0,4:0}  ", r.dwMousePosition.X));
    //Console.WriteLine(string.Format("    Y ...............:   {0,4:0}  ", r.dwMousePosition.Y));
    //Console.WriteLine(string.Format("    dwButtonState ...: 0x{0:X4}  ", r.dwButtonState));
    listPeak(r);
}

async void listPeak(NativeMethods.MOUSE_EVENT_RECORD r)
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
                    ConvertConsole2.ConsoleMain.Record.list_Longueur = true;
                }
                if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE2)
                {

                    masse.ListeDeviseMasse();
                    ConvertConsole2.ConsoleMain.Record.list_Masse = true;
                }
                if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE3)
                {
                    temps.ListeDeviseTemps();
                    ConvertConsole2.ConsoleMain.Record.list_Temps = true;
                }
                if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE4)
                {
                    vitesse.ListeDeviseVitesse();
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
                        ConvertConsole2.ConsoleMain.Record.list_Longueur = false;
                        ConvertConsole2.ConsoleMain.Record.list_Masse = false;
                        ConvertConsole2.ConsoleMain.Record.list_Temps = false;
                        ConvertConsole2.ConsoleMain.Record.list_Vitesse = false;
                        Environment.Exit(0);
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE6_PEAK_L)
                    {
                        Console.WriteLine("Clear");
                        Console.Clear();
                        ConvertConsole2.ConsoleMain.Record.list_Longueur = false;
                        ConvertConsole2.ConsoleMain.Record.list_Masse = false;
                        ConvertConsole2.ConsoleMain.Record.list_Temps = false;
                        ConvertConsole2.ConsoleMain.Record.list_Vitesse = false;
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





            if (r.dwMousePosition.X == ConvertConsole2.ConsoleMain.Record.COL_3)
            {
                if (ConvertConsole2.ConsoleMain.Record.list_Longueur == true)
                {
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE1_SELECT_L)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = longueur.CalculLongueur;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "kilometre";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "kilometre";

                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE2_SELECT_L)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = longueur.CalculLongueur;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "eiffel";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "eiffel";

                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE3_SELECT_L)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = longueur.CalculLongueur;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "metre";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "metre";

                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE4_SELECT_L)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = longueur.CalculLongueur;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "banane";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "banane";

                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE5_SELECT_L)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = longueur.CalculLongueur;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "centimetre";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "centimetre";
                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE6_SELECT_L)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = longueur.CalculLongueur;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "millimetre";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "millimetre";

                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE7_SELECT_L)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = longueur.CalculLongueur;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "micrometre";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "micrometre";
                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE8_SELECT_L)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = longueur.CalculLongueur;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "nanometre";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "nanometre";

                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE9_SELECT_L)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = longueur.CalculLongueur;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "mile";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "mile";

                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE10_SELECT_L)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = longueur.CalculLongueur;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "yard";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "yard";

                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE11_SELECT_L)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = longueur.CalculLongueur;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "pied";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "pied";

                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE12_SELECT_L)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = longueur.CalculLongueur;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "pouce";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "pouce";

                        }
                    }
                }




                if (ConvertConsole2.ConsoleMain.Record.list_Masse == true)
                {
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE1_SELECT_M)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = masse.CalculMasse;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "tonne";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "tonne";

                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE2_SELECT_M)
                    {
                        if (
                            ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = masse.CalculMasse;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "kilogramme";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "kilogramme";

                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE3_SELECT_M)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = masse.CalculMasse;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "gramme";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "gramme";

                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE4_SELECT_M)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = masse.CalculMasse;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "eiffel";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "eiffel";

                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE5_SELECT_M)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = masse.CalculMasse;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "banane";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "banane";
                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE6_SELECT_M)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = masse.CalculMasse;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "milligramme";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "milligramme";
                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE7_SELECT_M)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = masse.CalculMasse;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "tonne longue";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "tonne longue";
                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE8_SELECT_M)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = masse.CalculMasse;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "tonne courte";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "tonne courte";
                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE9_SELECT_M)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = masse.CalculMasse;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "livre";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "livre";
                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE10_SELECT_M)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = masse.CalculMasse;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "once";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "once";
                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE11_SELECT_M)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = masse.CalculMasse;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "stone";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "stone";
                        }
                    }
                }


                if (ConvertConsole2.ConsoleMain.Record.list_Temps == true)
                {
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE1_SELECT_T)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = temps.CalculTemps;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "nanoseconde";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "nanoseconde";
                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE2_SELECT_T)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = temps.CalculTemps;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "microseconde";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "microseconde";
                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE3_SELECT_T)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = temps.CalculTemps;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "milliseconde";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "milliseconde";
                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE4_SELECT_T)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = temps.CalculTemps;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "seconde";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "seconde";
                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE5_SELECT_T)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = temps.CalculTemps;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "minute";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "minute";
                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE6_SELECT_T)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = temps.CalculTemps;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "heure";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "heure";
                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE7_SELECT_T)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = temps.CalculTemps;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "jour";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "jour";
                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE8_SELECT_T)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = temps.CalculTemps;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "semaine";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "semaine";
                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE9_SELECT_T)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = temps.CalculTemps;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "mois";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "mois";
                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE10_SELECT_T)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = temps.CalculTemps;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "annee";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "annee";
                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE11_SELECT_T)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = temps.CalculTemps;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "lustre";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "lustre";
                        }
                    }
                }






                if (ConvertConsole2.ConsoleMain.Record.list_Vitesse == true)
                {
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE1_SELECT_V)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = vitesse.CalculVitesse;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "metre/seconde";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "metre/seconde";
                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE2_SELECT_V)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = vitesse.CalculVitesse;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "metre/heure";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "metre/heure";
                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE3_SELECT_V)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = vitesse.CalculVitesse;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "kilometre/heure";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "kilometre/heure";
                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE4_SELECT_V)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = vitesse.CalculVitesse;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "kilometre/seconde";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "kilometre/seconde";
                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE5_SELECT_V)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = vitesse.CalculVitesse;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "mile/heure";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "mile/heure";
                        }
                    }
                    if (r.dwMousePosition.Y == ConvertConsole2.ConsoleMain.Record.LIGNE6_SELECT_V)
                    {
                        if (ConvertConsole2.ConsoleMain.Record.unit_select == true)
                        {
                            Record.Cacule = vitesse.CalculVitesse;
                            ConvertConsole2.ConsoleMain.Record.unit2 = "pied/seconde";
                            ConvertConsole2.ConsoleMain.Record.fini = true;
                        }
                        else
                        {
                            ConvertConsole2.ConsoleMain.Record.unit1 = "pied/seconde";
                        }
                    }
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
    Record.unit1 = "";
    Record.unit2 = "";
    Record.unit_select = false;
}

void SaisieNombre()
{
    Console.Write("Nombre à convertir : ");
    var str = Console.ReadLine();
    double num = 0;

    while (double.TryParse(str, out num) == false)
    {
        Console.Clear();
        FormulaireDevise();
        Console.Write("Nombre à convertir : ");
    }
    Record.num1 = num;
}

void Formulaire()
{
    Console.WriteLine("Le résultat est : " + Record.result + " .");
}