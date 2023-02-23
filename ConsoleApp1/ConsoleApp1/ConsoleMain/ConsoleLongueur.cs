using ConvertConsole2.ConsoleMain;

namespace ConsoleApp1.ConsoleMain
{
    public class ConsoleLongueur : ConsoleBase
    {

        public ConsoleLongueur(Action? afficheResultat, Action? affichePromptInput)
        {
            ProgramState.AfficheResultat = afficheResultat;
            ProgramState.AffichePromptInput = affichePromptInput;
        }

        public override void Liste()
        {            
            WriteOpenListe();
            Dimensions?[(int)DimensionEnum.Masse].WriteCloseListe();
            Dimensions?[(int)DimensionEnum.Temps].WriteCloseListe();
            Dimensions?[(int)DimensionEnum.Vitesse].WriteCloseListe();            
        }

        public override void WriteCloseListe()
        {
            Console.WriteLine("Longueur < ");
        }

        public override void WriteOpenListe()
        {
            Console.WriteLine("Longueur > Les unitées disponible sont : 1 - kilometre (1000 m)");
            Console.WriteLine("                                         2 - eiffel (324 m)");
            Console.WriteLine("                                         3 - metre (1 m)");
            Console.WriteLine("                                         4 - banane (0.12 m)");
            Console.WriteLine("                                         5 - centimetre (0.1 m)");
            Console.WriteLine("                                         6 - millimetre (0.01 m)");
            Console.WriteLine("                                         7 - micrometre (1^-6 m)");
            Console.WriteLine("                                         8 - nanometre (1^-9 m)");
            Console.WriteLine("                                         9 - mile (1609.34 m)");
            Console.WriteLine("                                         10 - yard (0.9144 m)");
            Console.WriteLine("                                         11 - pied (0.3048 m)");
            Console.WriteLine("                                         12 - pouce (0.0254 m)");
        }
    }
}