using ConvertConsole2.ConsoleMain;

namespace ConsoleApp1.ConsoleMain
{
    public class ConsoleVitesse : ConsoleBase
    {
        public ConsoleVitesse(Action? afficheResultat, Action? affichePromptInput)
        {
            ProgramState.AfficheResultat = afficheResultat;
            ProgramState.AffichePromptInput = affichePromptInput;
        }

        public override void Liste()
        {
            Dimensions?[(int)DimensionEnum.Longueur].WriteCloseListe();
            Dimensions?[(int)DimensionEnum.Masse].WriteCloseListe();
            Dimensions?[(int)DimensionEnum.Temps].WriteCloseListe();
            WriteOpenListe();
        }

        public override void WriteCloseListe()
        {
            Console.WriteLine("Vitesse  < ");
        }

        public override void WriteOpenListe()
        {
            Console.WriteLine("Vitesse  > Les unitées disponible sont : 1 - metre/seconde (3.6 km/h)");
            Console.WriteLine("                                         2 - metre/heure (3 600 km/h)");
            Console.WriteLine("                                         3 - kilometre/heure (1 km/h)");
            Console.WriteLine("                                         4 - kilometre/seconde (3 600 km/h)");
            Console.WriteLine("                                         5 - mile/heure (1.609 km/h)");
            Console.WriteLine("                                         6 - pied/seconde (1.097 km/h)");
        }
    }
}
