using ConvertConsole2.ConsoleMain;

namespace ConsoleApp1.ConsoleMain
{
    public class ConsoleMasse : ConsoleBase
    {
        public ConsoleMasse(Action? afficheResultat, Action? affichePromptInput)
        {
            ProgramState.AfficheResultat = afficheResultat;
            ProgramState.AffichePromptInput = affichePromptInput;
        }

        public override void Liste()
        {
            Dimensions?[(int)DimensionEnum.Longueur].WriteCloseListe();
            WriteOpenListe();
            Dimensions?[(int)DimensionEnum.Temps].WriteCloseListe();
            Dimensions?[(int)DimensionEnum.Vitesse].WriteCloseListe();
        }

        public override void WriteCloseListe()
        {
            Console.WriteLine("Masse    < ");
        }

        public override void WriteOpenListe()
        {
            Console.WriteLine("Masse    > Les unitées disponible sont : 1 - tonne (1 000 000g)");
            Console.WriteLine("                                         2 - kilogramme (1000 g)");
            Console.WriteLine("                                         3 - gramme (1 g)");
            Console.WriteLine("                                         4 - eiffel (10 100 000 g)");
            Console.WriteLine("                                         5 - banane (120 g)");
            Console.WriteLine("                                         6 - milligramme (0.001 g)");
            Console.WriteLine("                                         7 - tonne longue (1 016 000 g)");
            Console.WriteLine("                                         8 - tonne courte (907 185 g)");
            Console.WriteLine("                                         9 - livre (453.592 g)");
            Console.WriteLine("                                         10 - once (28.3495 g)");
            Console.WriteLine("                                         11 - stone (6350.29 g)");
        }
    
    }
}
