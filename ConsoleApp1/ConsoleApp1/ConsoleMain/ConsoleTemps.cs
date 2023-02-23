using ConvertConsole2.ConsoleMain;

namespace ConsoleApp1.ConsoleMain
{
    public class ConsoleTemps : ConsoleBase
    {
        public ConsoleTemps(Action? afficheResultat, Action? affichePromptInput)
        {
            ProgramState.AfficheResultat = afficheResultat;
            ProgramState.AffichePromptInput = affichePromptInput;
        }

        public override void Liste()
        {
            Dimensions?[(int)DimensionEnum.Longueur].WriteCloseListe();
            Dimensions?[(int)DimensionEnum.Masse].WriteCloseListe();
            WriteOpenListe();
            Dimensions?[(int)DimensionEnum.Vitesse].WriteCloseListe();
        }

        public override void WriteCloseListe()
        {
            Console.WriteLine("Temps    < ");
        }

        public override void WriteOpenListe()
        {
            Console.WriteLine("Temps    > Les unitées disponible sont : 1 - nanoseconde (1^-9 s)");
            Console.WriteLine("                                         2 - microseconde (1^-6 s)");
            Console.WriteLine("                                         3 - milliseconde (0.001 s)");
            Console.WriteLine("                                         4 - seconde (1 s)");
            Console.WriteLine("                                         5 - minute (60 s)");
            Console.WriteLine("                                         6 - heure (3 600 s)");
            Console.WriteLine("                                         7 - jour (86 400 s)");
            Console.WriteLine("                                         8 - semaine (604 800 s)");
            Console.WriteLine("                                         9 - mois (2 592 000 s)");
            Console.WriteLine("                                         10 - annee (31 104 000 s)");
            Console.WriteLine("                                         11 - lustre (155 520 000 s)");
        }
    }
}