// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using ConsoleApp1.ConsoleMain;
using ConvertConsole2.ConsoleMain;


static IEnumerable<IUnit> LoadUnites()
{
    string[] lines = System.IO.File.ReadAllLines(@"../../../Unite.txt");

    // Create the query. Put field 2 first, then  
    // reverse and combine fields 0 and 1 from the old field  
    IEnumerable<IUnit> list =
        (from line in lines
        select new Unite(
        line.Split(',')[0].Trim(), 
        line.Split(',')[1].Trim(), 
        line.Split(',')[2].Trim(), 
        line.Split(',')[3].Trim(), 
        line.Split(',')[4].Trim(),
        line.Split(',')[5].Trim()))
        .ToList();
    
    return list;
}
/* Output to spreadsheet2.csv:  
111, Svetlana Omelchenko  
112, Claire O'Donnell  
113, Sven Mortensen  
114, Cesar Garcia  
115, Debra Garcia  
116, Fadi Fakhouri  
117, Hanying Feng  
118, Hugo Garcia  
119, Lance Tucker  
120, Terry Adams  
121, Eugene Zabokritski  
122, Michael Tucker  
 */
/* Output:  
    Single Column Query:  
    Exam #4: Average:76.92 High Score:94 Low Score:39  
  
    Multi Column Query:  
    Exam #1 Average: 86.08 High Score: 99 Low Score: 35  
    Exam #2 Average: 86.42 High Score: 94 Low Score: 72  
    Exam #3 Average: 84.75 High Score: 91 Low Score: 65  
    Exam #4 Average: 76.92 High Score: 94 Low Score: 39  
 */


ConsoleDimension currentConsoleDimension = null;

var unites = LoadUnites().OrderBy(u => u.Position);

var dimensions = unites
    .GroupBy(u => u.DimensionLabel)
    .Select(grp => new Dimension(grp.ToList().Min(u => u.Position), grp.Key, grp.ToList()));

var tempConsoleList = new List<ConsoleDimension>();
foreach (var dim in dimensions)
{
    ConsoleDimension consoleDimension = new ConsoleDimension();
    consoleDimension.Dimension = dim;
    tempConsoleList.Add(consoleDimension);
}
ConsoleDimension.AllConsoleDimensions = tempConsoleList;


ConsoleBase.Dimensions = new ConsoleBase[4];
ConsoleBase longueur = new ConsoleLongueur(AfficheLigneResultat, SaisieNombre);
ConsoleBase vitesse = new ConsoleVitesse(AfficheLigneResultat, SaisieNombre);
ConsoleBase masse = new ConsoleMasse(AfficheLigneResultat, SaisieNombre);
ConsoleBase temps = new ConsoleTemps(AfficheLigneResultat, SaisieNombre);
ConsoleBase.Dimensions = new ConsoleBase[4] {
    longueur,
    masse,
    temps,
    vitesse,   
};

ConsoleListener.MouseEvent += ConsoleListener_MouseEvent;
ConsoleListener.KeyEvent += ConsoleListener_KeyEvent;
ConsoleListener.Start();
AfficheMenu();

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
        AfficheMenu();
    }
}

void ConsoleListener_MouseEvent(NativeMethods.MOUSE_EVENT_RECORD r)
{
    ListPeak(r);
}

void WriteBottom() 
{
    Console.WriteLine("");
    Console.WriteLine("Appuyer sur [C] pour nettoyer");
    Console.WriteLine("Appuyer sur [X] pour quitter");
}

void ListPeak(NativeMethods.MOUSE_EVENT_RECORD r)
{
    if (ConsoleDimension.AllConsoleDimensions == null) return;
    if (r.dwButtonState == ProgramState.BTN_PRESS)
    {
        switch (r.dwMousePosition.X)
        {
            case ProgramState.COL_1:
                break;

            case ProgramState.COL_2:
                break;

            case ProgramState.COL_3:
                break;
        }
        
        if (/*(ProgramState.list_Longueur == false) && 
            (ProgramState.list_Masse == false) && 
            (ProgramState.list_Temps == false) && 
            (ProgramState.list_Vitesse == false)*/
            currentConsoleDimension == null)
        {

            if (r.dwMousePosition.X == ProgramState.COL_1)
            {
                var consoleDimension = ConsoleDimension.AllConsoleDimensions.FirstOrDefault(cd => cd.Dimension?.Position == r.dwMousePosition.Y);
                if (consoleDimension != null)
                {                    
                    Console.Clear();
                    Console.WriteLine("Choisissez votre referentiel entre :");

                    consoleDimension.IsOpen = true;
                    consoleDimension.Liste();
                    currentConsoleDimension = consoleDimension;

                    //ProgramState.list_Longueur = true;

                   WriteBottom();
                }


                /*

                if (r.dwMousePosition.Y == ProgramState.LIGNE1)
                {
                    Console.Clear();
                    Console.WriteLine("Choisissez votre referentiel entre :");
                    longueur.Liste();
                    ProgramState.list_Longueur = true;
                    Console.WriteLine("");
                    Console.WriteLine("Appuyer sur [C] pour nettoyer");
                    Console.WriteLine("Appuyer sur [X] pour quitter");
                }
                if (r.dwMousePosition.Y == ProgramState.LIGNE2)
                {
                    Console.Clear();
                    Console.WriteLine("Choisissez votre referentiel entre :");
                    masse.Liste();
                    ProgramState.list_Masse = true;
                    Console.WriteLine("");
                    Console.WriteLine("Appuyer sur [C] pour nettoyer");
                    Console.WriteLine("Appuyer sur [X] pour quitter");
                }
                if (r.dwMousePosition.Y == ProgramState.LIGNE3)
                {
                    Console.Clear();
                    Console.WriteLine("Choisissez votre referentiel entre :");
                    temps.Liste();
                    ProgramState.list_Temps = true;
                    Console.WriteLine("");
                    Console.WriteLine("Appuyer sur [C] pour nettoyer");
                    Console.WriteLine("Appuyer sur [X] pour quitter");
                }
                if (r.dwMousePosition.Y == ProgramState.LIGNE4)
                {
                    Console.Clear();
                    Console.WriteLine("Choisissez votre referentiel entre :");
                    vitesse.Liste();
                    ProgramState.list_Vitesse = true;
                    Console.WriteLine("");
                    Console.WriteLine("Appuyer sur [C] pour nettoyer");
                    Console.WriteLine("Appuyer sur [X] pour quitter");
                }
                */
            }

            if (r.dwMousePosition.X == ProgramState.COL_2)
            {
                if (r.dwMousePosition.Y == ProgramState.LIGNE7)
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Environment.Exit(0);
                }
                if (r.dwMousePosition.Y == ProgramState.LIGNE6)
                {
                    Console.WriteLine("Clear");
                    Console.Clear();
                    AfficheMenu();
                }
            }
        }
        else if (r.dwButtonState == ProgramState.BTN_PRESS)
        {
            if (r.dwMousePosition.X == ProgramState.COL_1)
            {
                if(currentConsoleDimension != null && currentConsoleDimension.Dimension?.Position == r.dwMousePosition.Y)
                {
                    currentConsoleDimension.IsOpen = false;
                    currentConsoleDimension = null;
                    AfficheMenu();
                }
                /*if (r.dwMousePosition.Y == ProgramState.LIGNE1_PEAK)
                {
                    ProgramState.list_Longueur = false;
                    AfficheMenu();
                }
                if (r.dwMousePosition.Y == ProgramState.LIGNE2_PEAK)
                {
                    ProgramState.list_Masse = false;
                    AfficheMenu();
                }
                if (r.dwMousePosition.Y == ProgramState.LIGNE3_PEAK)
                {
                    ProgramState.list_Temps = false;
                    AfficheMenu();
                }
                if (r.dwMousePosition.Y == ProgramState.LIGNE4_PEAK)
                {
                    ProgramState.list_Vitesse = false;
                    AfficheMenu();
                }*/


            }

            if ((ProgramState.list_Longueur == true) && (ProgramState.list_Masse == false) && (ProgramState.list_Temps == false) && (ProgramState.list_Vitesse == false))
            {
                if (r.dwMousePosition.X == ProgramState.COL_2)
                {
                    if (r.dwMousePosition.Y == ProgramState.LIGNE7_PEAK_L)
                    {
                        Console.Clear();
                        Console.WriteLine("Vous allez quittez l'application");
                        currentConsoleDimension.IsOpen = false;
                        currentConsoleDimension = null;
                        Environment.Exit(0);
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE6_PEAK_L)
                    {
                        Console.WriteLine("Clear");
                        Console.Clear();
                        currentConsoleDimension.IsOpen = false;
                        currentConsoleDimension = null;
                        AfficheMenu();

                    }
                }
            }

            if (r.dwMousePosition.X == ProgramState.COL_1)
            {
                if (r.dwMousePosition.Y == ProgramState.LIGNE1_PEAK)
                {
                    Console.WriteLine("Clear");
                    Console.Clear();
                    ProgramState.list_Masse = false;
                    AfficheMenu();
                }
            }

            if ((ProgramState.list_Longueur == false) && (ProgramState.list_Masse == true) && (ProgramState.list_Temps == false) && (ProgramState.list_Vitesse == false))
            {
                if (r.dwMousePosition.X == ProgramState.COL_2)
                {
                    if (r.dwMousePosition.Y == ProgramState.LIGNE7_PEAK_M)
                    {
                        Console.Clear();
                        Console.WriteLine("Vous allez quittez l'application");
                        Environment.Exit(0);
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE6_PEAK_M)
                    {
                        Console.WriteLine("Clear");
                        Console.Clear();
                        ProgramState.list_Masse = false;
                        AfficheMenu();
                    }
                }
            }

            if (r.dwMousePosition.X == ProgramState.COL_1)
            {
                if (r.dwMousePosition.Y == ProgramState.LIGNE2_PEAK)
                {
                    Console.WriteLine("Clear");
                    Console.Clear();
                    ProgramState.list_Masse = false;
                    AfficheMenu();
                }
            }

            if ((ProgramState.list_Longueur == false) && (ProgramState.list_Masse == false) && (ProgramState.list_Temps == true) && (ProgramState.list_Vitesse == false))
            {
                if (r.dwMousePosition.X == ProgramState.COL_2)
                {
                    if (r.dwMousePosition.Y == ProgramState.LIGNE7_PEAK_T)
                    {
                        Console.Clear();
                        Console.WriteLine("Vous allez quittez l'application");
                        Environment.Exit(0);
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE6_PEAK_T)
                    {
                        Console.WriteLine("Clear");
                        Console.Clear();
                        ProgramState.list_Temps = false;
                        AfficheMenu();

                    }
                }
            }

            if (r.dwMousePosition.X == ProgramState.COL_1)
            {
                if (r.dwMousePosition.Y == ProgramState.LIGNE3_PEAK)
                {
                    Console.WriteLine("Clear");
                    Console.Clear();
                    ProgramState.list_Temps = false;
                    AfficheMenu();
                }
            }

            if ((ProgramState.list_Longueur == false) && (ProgramState.list_Masse == false) && (ProgramState.list_Temps == false) && (ProgramState.list_Vitesse == true))
            {
                if (r.dwMousePosition.X == ProgramState.COL_2)
                {
                    if (r.dwMousePosition.Y == ProgramState.LIGNE7_PEAK_V)
                    {
                        Console.Clear();
                        Console.WriteLine("Vous allez quittez l'application");
                        Environment.Exit(0);
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE6_PEAK_V)
                    {
                        Console.WriteLine("Clear");
                        Console.Clear();
                        ProgramState.list_Vitesse = false;
                        AfficheMenu();

                    }
                }
            }

            if (r.dwMousePosition.X == ProgramState.COL_1)
            {
                if (r.dwMousePosition.Y == ProgramState.LIGNE4_PEAK)
                {
                    Console.WriteLine("Clear");
                    Console.Clear();
                    ProgramState.list_Vitesse = false;
                    AfficheMenu();
                }
            }

            if (r.dwMousePosition.X == ProgramState.COL_3)
            {
                if (ProgramState.list_Longueur == true)
                {
                    if (r.dwMousePosition.Y == ProgramState.LIGNE1_SELECT_L)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("kilometre");
                        }
                        else
                        {
                            SetUnite1("kilometre");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE2_SELECT_L)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("eiffel");
                        }
                        else
                        {
                            SetUnite1("eiffel");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE3_SELECT_L)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("metre");
                        }
                        else
                        {
                            SetUnite1("metre");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE4_SELECT_L)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("banane");
                        }
                        else
                        {
                            SetUnite1("banane");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE5_SELECT_L)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("centimetre");
                        }
                        else
                        {
                            SetUnite1("centimetre");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE6_SELECT_L)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("millimetre");
                        }
                        else
                        {
                            SetUnite1("millimetre");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE7_SELECT_L)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("millimetre");
                        }
                        else
                        {
                            SetUnite1("micrometre");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE8_SELECT_L)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("nanometre");
                        }
                        else
                        {
                            SetUnite1("nanometre");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE9_SELECT_L)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("mile");
                        }
                        else
                        {
                            SetUnite1("mile");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE10_SELECT_L)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("yard");
                        }
                        else
                        {
                            SetUnite1("yard");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE11_SELECT_L)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("pied");
                        }
                        else
                        {
                            SetUnite1("pied");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE12_SELECT_L)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("pouce");
                        }
                        else
                        {
                            SetUnite1("pouce");
                        }
                    }
                }


                if (ProgramState.list_Masse == true)
                {
                    if (r.dwMousePosition.Y == ProgramState.LIGNE1_SELECT_M)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("tonne");
                        }
                        else
                        {
                            SetUnite1("tonne");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE2_SELECT_M)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("kilogramme");
                        }
                        else
                        {
                            SetUnite1("kilogramme");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE3_SELECT_M)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("gramme");
                        }
                        else
                        {
                            SetUnite1("gramme");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE4_SELECT_M)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("eiffel");
                        }
                        else
                        {
                            SetUnite1("eiffel");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE5_SELECT_M)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("banane");
                        }
                        else
                        {
                            SetUnite1("kilometre");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE6_SELECT_M)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("milligramme");
                        }
                        else
                        {
                            SetUnite1("milligramme");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE7_SELECT_M)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("tonne longue");
                        }
                        else
                        {
                            SetUnite1("tonne longue");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE8_SELECT_M)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("tonne courte");
                        }
                        else
                        {
                            SetUnite1("tonne courte");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE9_SELECT_M)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("livre");
                        }
                        else
                        {
                            SetUnite1("livre");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE10_SELECT_M)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("once");
                        }
                        else
                        {
                            SetUnite1("once");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE11_SELECT_M)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("stone");
                        }
                        else
                        {
                            SetUnite1("stone");
                        }
                    }
                }


                if (ProgramState.list_Temps == true)
                {
                    if (r.dwMousePosition.Y == ProgramState.LIGNE1_SELECT_T)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("nanoseconde");
                        }
                        else
                        {
                            SetUnite1("nanoseconde");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE2_SELECT_T)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("microseconde");
                        }
                        else
                        {
                            SetUnite1("microseconde");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE3_SELECT_T)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("milliseconde");
                        }
                        else
                        {
                            SetUnite1("milliseconde");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE4_SELECT_T)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("seconde");
                        }
                        else
                        {
                            SetUnite1("seconde");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE5_SELECT_T)
                    {
                        if (ProgramState.unit_select == true)
                        {
                             SetUnite2("minute");
                        }
                        else
                        {
                            SetUnite1("minute");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE6_SELECT_T)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("heure");
                        }
                        else
                        {
                            SetUnite1("heure");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE7_SELECT_T)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("jour");
                        }
                        else
                        {
                            SetUnite1("jour");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE8_SELECT_T)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("semaine");
                        }
                        else
                        {
                            SetUnite1("semaine");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE9_SELECT_T)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("mois");
                        }
                        else
                        {
                            SetUnite1("mois");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE10_SELECT_T)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("annee");
                        }
                        else
                        {
                            SetUnite1("annee");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE11_SELECT_T)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("lustre");
                        }
                        else
                        {
                            SetUnite1("lustre");
                        }
                    }
                }


                if (ProgramState.list_Vitesse == true)
                {
                    if (r.dwMousePosition.Y == ProgramState.LIGNE1_SELECT_V)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("metre/seconde");
                        }
                        else
                        {
                            SetUnite1("metre/seconde");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE2_SELECT_V)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2( "metre/heure");
                        }
                        else
                        {
                            SetUnite1("metre/heure");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE3_SELECT_V)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("kilometre/heure");
                        }
                        else
                        {
                            SetUnite1("kilometre/heure");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE4_SELECT_V)
                    {
                        if (ProgramState.unit_select == true)
                        {                            
                            SetUnite2("kilometre/seconde");
                        }
                        else
                        {
                            SetUnite1("kilometre/seconde");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE5_SELECT_V)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("mile/heure");
                        }
                        else
                        {
                            SetUnite1("mile/heure");
                        }
                    }
                    if (r.dwMousePosition.Y == ProgramState.LIGNE6_SELECT_V)
                    {
                        if (ProgramState.unit_select == true)
                        {
                            SetUnite2("pied/seconde");
                        }
                        else
                        {
                            SetUnite1("pied/seconde");
                        }
                    }
                }
            }
        }
    }
}

void AfficheMenu()
{
    Console.WriteLine("Choisissez votre referentiel entre :");
    if (ConsoleBase.Dimensions != null)
    {
        for (int i = 0; i < ConsoleBase.Dimensions.Length; i++)
        {
            ConsoleBase.Dimensions[i].WriteCloseListe();
        }
    }
    WriteBottom();
    ProgramState.Unite1 = null;
    ProgramState.Unite2 = null;
    ProgramState.unit_select = false;
}

void SaisieNombre()
{
    Console.Write("Nombre à convertir : ");
    var str = Console.ReadLine();
    double num = 0;

    while (double.TryParse(str, out num) == false)
    {
        Console.Clear();
        AfficheMenu();
        Console.Write("Nombre à convertir : ");
    }
    ProgramState.num1 = num;
}

void AfficheLigneResultat()
{
    Console.WriteLine("Le résultat est : " + ProgramState.Result + " .");
}

void SetUnite1(string unit)
{
    ProgramState.Unite1 = unites.First(u => u.Label == unit);
}

void SetUnite2(string unit)
{
    ProgramState.ComputeDelegate = ConsoleBase.Calcul;
    ProgramState.Unite2 = unites.First(u => u.Label == unit);
}