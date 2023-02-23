using ConvertConsole2.ConsoleMain;

namespace ConsoleApp1.ConsoleMain
{
    public abstract class ConsoleBase : /*ICalculable,*/ IListable
    {
        public static void Calcul()
        {
            ProgramState.Result = ProgramState.num1 * (ProgramState.Unite1.Ratio / ProgramState.Unite2.Ratio);
        }

        public abstract void Liste();
        public abstract void WriteCloseListe();
        public abstract void WriteOpenListe();

        public static ConsoleBase[]? Dimensions { get; set; }
    }

    public abstract class Console<T> : ConsoleBase where T : Dimension {
        public T? Dimension { get; set; }
        public bool IsOpen { get; set; }
    }

    public class ConsoleDimension : Console<Dimension>
    {
        public static IEnumerable<ConsoleDimension>? AllConsoleDimensions
        {
            get; set;
        }

        public override void Liste()
        {
            if (AllConsoleDimensions == null) return;
            foreach(var consoleDimension in AllConsoleDimensions)
            {
                if (consoleDimension.IsOpen)
                {
                    consoleDimension.WriteOpenListe();
                }
                else
                {
                    consoleDimension.WriteCloseListe();
                }
            }
        }

        public override void WriteCloseListe()
        {
            Console.WriteLine(Dimension?.DimensionLabel.PadRight(9) + "<");
        }

        public override void WriteOpenListe()
        {
            if (Dimension == null) return;
            if (Dimension.Unites == null) return;

            // Console.WriteLine(Dimension?.DimensionLabel + " > Les unitées disponible sont : 1 - metre/seconde (3.6 km/h)");
            Console.WriteLine(Dimension.DimensionLabel.PadRight(9) + 
                "> Les unitées disponible sont : " + 
                Dimension.Unites.First().Code + " - " + 
                Dimension.Unites.First().Label + " " + 
                Dimension.Unites.First().Info);
            foreach(var unite in Dimension.Unites.Skip(1))
            {
                //Console.WriteLine("                                         2 - metre/heure (3 600 km/h)");
                Console.WriteLine("                                         "+ unite.Code + " - " + unite.Label + " " + unite.Info);
            }
        }
    }
}