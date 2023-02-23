using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConsoleMain
{
    public class InfoTemps { 
    internal class Nanoseconde : IUnite
    {
        private string _code = "1";

        public string Code { get => _code; private set => _code = value; }


        private string _label = "nanoseconde";

        public string Label { get => _label; private set => _label = value; }

        private Dimension _dimension = Dimension.Temps;

        public Dimension Dimension { get => _dimension; private set => _dimension = value; }

        private double _ratio = 0.000000001;

        public double Ratio { get => _ratio; set => _ratio = value; }
    }
    internal class Microseconde : IUnite
    {
        private string _code = "2";

        public string Code { get => _code; private set => _code = value; }


        private string _label = "microseconde";

        public string Label { get => _label; private set => _label = value; }

        private Dimension _dimension = Dimension.Temps;

        public Dimension Dimension { get => _dimension; private set => _dimension = value; }

        private double _ratio = 0.000001;

        public double Ratio { get => _ratio; set => _ratio = value; }
    }
    internal class Milliseconde : IUnite
    {
        private string _code = "3";

        public string Code { get => _code; private set => _code = value; }


        private string _label = "milliseconde";

        public string Label { get => _label; private set => _label = value; }

        private Dimension _dimension = Dimension.Temps;

        public Dimension Dimension { get => _dimension; private set => _dimension = value; }

        private double _ratio = 0.001;

        public double Ratio { get => _ratio; set => _ratio = value; }
    }
    internal class Seconde : IUnite
    {
        private string _code = "4";

        public string Code { get => _code; private set => _code = value; }


        private string _label = "seconde";

        public string Label { get => _label; private set => _label = value; }

        private Dimension _dimension = Dimension.Temps;

        public Dimension Dimension { get => _dimension; private set => _dimension = value; }

        private double _ratio = 1;

        public double Ratio { get => _ratio; set => _ratio = value; }
    }
    internal class Minute : IUnite
    {
        private string _code = "5";

        public string Code { get => _code; private set => _code = value; }


        private string _label = "minute";

        public string Label { get => _label; private set => _label = value; }

        private Dimension _dimension = Dimension.Temps;

        public Dimension Dimension { get => _dimension; private set => _dimension = value; }

        private double _ratio = 60;

        public double Ratio { get => _ratio; set => _ratio = value; }
    }
    internal class Heure : IUnite
    {
        private string _code = "6";

        public string Code { get => _code; private set => _code = value; }


        private string _label = "heure";

        public string Label { get => _label; private set => _label = value; }

        private Dimension _dimension = Dimension.Temps;

        public Dimension Dimension { get => _dimension; private set => _dimension = value; }

        private double _ratio = 3600;

        public double Ratio { get => _ratio; set => _ratio = value; }
    }
    internal class Jour : IUnite
    {
        private string _code = "7";

        public string Code { get => _code; private set => _code = value; }


        private string _label = "jour";

        public string Label { get => _label; private set => _label = value; }

        private Dimension _dimension = Dimension.Temps;

        public Dimension Dimension { get => _dimension; private set => _dimension = value; }

        private double _ratio = 86400;

        public double Ratio { get => _ratio; set => _ratio = value; }
    }
    internal class Semaine : IUnite
    {
        private string _code = "8";

        public string Code { get => _code; private set => _code = value; }


        private string _label = "semaine";

        public string Label { get => _label; private set => _label = value; }

        private Dimension _dimension = Dimension.Temps;

        public Dimension Dimension { get => _dimension; private set => _dimension = value; }

        private double _ratio = 604800;

        public double Ratio { get => _ratio; set => _ratio = value; }
    }
    internal class Mois : IUnite
    {
        private string _code = "9";

        public string Code { get => _code; private set => _code = value; }


        private string _label = "mois";

        public string Label { get => _label; private set => _label = value; }

        private Dimension _dimension = Dimension.Temps;

        public Dimension Dimension { get => _dimension; private set => _dimension = value; }

        private double _ratio = 2592000;

        public double Ratio { get => _ratio; set => _ratio = value; }
    }
    internal class Annee : IUnite
    {
        private string _code = "10";

        public string Code { get => _code; private set => _code = value; }


        private string _label = "annee";

        public string Label { get => _label; private set => _label = value; }

        private Dimension _dimension = Dimension.Temps;

        public Dimension Dimension { get => _dimension; private set => _dimension = value; }

        private double _ratio = 31104000;

        public double Ratio { get => _ratio; set => _ratio = value; }
    }
    internal class Lustre : IUnite
    {
        private string _code = "11";

        public string Code { get => _code; private set => _code = value; }


        private string _label = "lustre";

        public string Label { get => _label; private set => _label = value; }

        private Dimension _dimension = Dimension.Temps;

        public Dimension Dimension { get => _dimension; private set => _dimension = value; }

        private double _ratio = 155520000;

        public double Ratio { get => _ratio; set => _ratio = value; }
    }
    }
}
