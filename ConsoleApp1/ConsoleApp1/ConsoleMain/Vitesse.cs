using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConsoleMain
{
    public class InfoVitesse { 
    internal class Metre_Seconde : IUnite
    {
        private string _code = "1";

        public string Code { get => _code; private set => _code = value; }


        private string _label = "metre/seconde";

        public string Label { get => _label; private set => _label = value; }

        private Dimension _dimension = Dimension.Vitesse;

        public Dimension Dimension { get => _dimension; private set => _dimension = value; }

        private double _ratio = 3.6;

        public double Ratio { get => _ratio; set => _ratio = value; }
    }
    internal class Metre_Heure : IUnite
    {
        private string _code = "2";

        public string Code { get => _code; private set => _code = value; }


        private string _label = "metre/heure";

        public string Label { get => _label; private set => _label = value; }

        private Dimension _dimension = Dimension.Vitesse;

        public Dimension Dimension { get => _dimension; private set => _dimension = value; }

        private double _ratio = 3600;

        public double Ratio { get => _ratio; set => _ratio = value; }
    }
    internal class Kilometre_Heure : IUnite
    {
        private string _code = "3";

        public string Code { get => _code; private set => _code = value; }


        private string _label = "kilometre/heure";

        public string Label { get => _label; private set => _label = value; }

        private Dimension _dimension = Dimension.Vitesse;

        public Dimension Dimension { get => _dimension; private set => _dimension = value; }

        private double _ratio = 1;

        public double Ratio { get => _ratio; set => _ratio = value; }
    }
    internal class Kilometre_Seconde : IUnite
    {
        private string _code = "4";

        public string Code { get => _code; private set => _code = value; }


        private string _label = "kilometre/seconde";

        public string Label { get => _label; private set => _label = value; }

        private Dimension _dimension = Dimension.Vitesse;

        public Dimension Dimension { get => _dimension; private set => _dimension = value; }

        private double _ratio = 0.000277;

        public double Ratio { get => _ratio; set => _ratio = value; }    }
    internal class Mile_Heure : IUnite
    {
        private string _code = "5";

        public string Code { get => _code; private set => _code = value; }


        private string _label = "mile/heure";

        public string Label { get => _label; private set => _label = value; }

        private Dimension _dimension = Dimension.Vitesse;

        public Dimension Dimension { get => _dimension; private set => _dimension = value; }

        private double _ratio = 1.609;

        public double Ratio { get => _ratio; set => _ratio = value; }
    }
    internal class Pied_Seconde : IUnite
    {
        private string _code = "6";

        public string Code { get => _code; private set => _code = value; }


        private string _label = "pied/seconde";

        public string Label { get => _label; private set => _label = value; }

        private Dimension _dimension = Dimension.Vitesse;

        public Dimension Dimension { get => _dimension; private set => _dimension = value; }

        private double _ratio = 1.097;

        public double Ratio { get => _ratio; set => _ratio = value; }
    }
}
}
