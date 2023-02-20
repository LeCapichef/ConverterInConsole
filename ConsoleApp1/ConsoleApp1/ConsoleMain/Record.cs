using ConsoleApp2.Main.Longueur;
using ConsoleApp2.Main.Masse;
using ConsoleApp2.Main.Temps;
using ConsoleApp2.Main.Vitesse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;





namespace ConvertConsole2.ConsoleMain
{
    internal class Record
    {
        internal static double num1;
        internal static double result = 0;
        internal static string unit1 = "3";
        internal static string unit2 = "3";
        internal static double ratio;
        internal static double ratioCalc1 = 1;
        internal static double ratioCalc2 = 1;
        internal static bool list_Longueur = false;
        internal static bool list_Masse = false;
        internal static bool list_Temps = false;
        internal static bool list_Vitesse = false;
        internal static bool unit_select = false;

        internal const int BTN_PRESS = 0x0001;
        internal const int LIGNE1 = 1;
        internal const int LIGNE2 = 2;
        internal const int LIGNE3 = 3;
        internal const int LIGNE4 = 4;
        internal const int LIGNE5 = 5;
        internal const int LIGNE6 = 6;
        internal const int LIGNE7 = 7;

        internal const int LIGNE1_SELECT_L = 1;
        internal const int LIGNE2_SELECT_L = 2;
        internal const int LIGNE3_SELECT_L = 3;
        internal const int LIGNE4_SELECT_L = 4;
        internal const int LIGNE5_SELECT_L = 5;
        internal const int LIGNE6_SELECT_L = 6;
        internal const int LIGNE7_SELECT_L = 7;
        internal const int LIGNE8_SELECT_L = 8;
        internal const int LIGNE9_SELECT_L = 9;
        internal const int LIGNE10_SELECT_L = 10;
        internal const int LIGNE11_SELECT_L = 11;
        internal const int LIGNE12_SELECT_L = 12;

        internal const int LIGNE1_SELECT_M = 2;
        internal const int LIGNE2_SELECT_M = 3;
        internal const int LIGNE3_SELECT_M = 4;
        internal const int LIGNE4_SELECT_M = 5;
        internal const int LIGNE5_SELECT_M = 6;
        internal const int LIGNE6_SELECT_M = 7;
        internal const int LIGNE7_SELECT_M = 8;
        internal const int LIGNE8_SELECT_M = 9;
        internal const int LIGNE9_SELECT_M = 10;
        internal const int LIGNE10_SELECT_M = 11;
        internal const int LIGNE11_SELECT_M = 12;

        internal const int LIGNE1_SELECT_T = 3;
        internal const int LIGNE2_SELECT_T = 4;
        internal const int LIGNE3_SELECT_T = 5;
        internal const int LIGNE4_SELECT_T = 6;
        internal const int LIGNE5_SELECT_T = 7;
        internal const int LIGNE6_SELECT_T = 8;
        internal const int LIGNE7_SELECT_T = 9;
        internal const int LIGNE8_SELECT_T = 10;
        internal const int LIGNE9_SELECT_T = 11;
        internal const int LIGNE10_SELECT_T = 12;
        internal const int LIGNE11_SELECT_T = 13;

        internal const int LIGNE1_SELECT_V = 4;
        internal const int LIGNE2_SELECT_V = 5;
        internal const int LIGNE3_SELECT_V = 6;
        internal const int LIGNE4_SELECT_V = 7;
        internal const int LIGNE5_SELECT_V = 8;
        internal const int LIGNE6_SELECT_V = 9;

        internal const int COL_1 = 9;
        internal const int COL_2 = 13;
        internal const int COL_3 = 41;

        internal const int LIGNE1_PEAK = 1;
        internal const int LIGNE2_PEAK = 2;
        internal const int LIGNE3_PEAK = 3;
        internal const int LIGNE4_PEAK = 4;
        internal const int LIGNE5_PEAK = 5;
        internal const int LIGNE6_PEAK_L = 17;
        internal const int LIGNE7_PEAK_L = 18;
        internal const int LIGNE6_PEAK_M = 16;
        internal const int LIGNE7_PEAK_M = 17;
        internal const int LIGNE6_PEAK_T = 16;
        internal const int LIGNE7_PEAK_T = 17;
        internal const int LIGNE6_PEAK_V = 11;
        internal const int LIGNE7_PEAK_V = 12;

    }
}
