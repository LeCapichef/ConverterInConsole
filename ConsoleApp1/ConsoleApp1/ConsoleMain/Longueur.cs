using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConsoleMain
{
    public class InfoLongueur
    {
        internal class Kilometre : IUnite
        {
            private string _code = "1";

            public string Code { get => _code; private set => _code = value; }


            private string _label = "kilometre";

            public string Label { get => _label; private set => _label = value; }

            private Dimension _dimension = Dimension.Longueur;

            public Dimension Dimension { get => _dimension; private set => _dimension = value; }

            private double _ratio = 1000;

            public double Ratio { get => _ratio; set => _ratio = value; }
        }

        internal class EiffelL : IUnite
        {
            private string _code = "2";

            public string Code { get => _code; private set => _code = value; }


            private string _label = "effeil";

            public string Label { get => _label; private set => _label = value; }

            private Dimension _dimension = Dimension.Longueur;

            public Dimension Dimension { get => _dimension; private set => _dimension = value; }

            private double _ratio = 324;

            public double Ratio { get => _ratio; set => _ratio = value; }
        }

        internal class Metre : IUnite
        {
            private string _code = "3";

            public string Code { get => _code; private set => _code = value; }


            private string _label = "metre";

            public string Label { get => _label; private set => _label = value; }

            private Dimension _dimension = Dimension.Longueur;

            public Dimension Dimension { get => _dimension; private set => _dimension = value; }

            private double _ratio = 1;

            public double Ratio { get => _ratio; set => _ratio = value; }
        }
        internal class Centimetre : IUnite
        {
            private string _code = "4";

            public string Code { get => _code; private set => _code = value; }


            private string _label = "centimetre";

            public string Label { get => _label; private set => _label = value; }

            private Dimension _dimension = Dimension.Longueur;

            public Dimension Dimension { get => _dimension; private set => _dimension = value; }

            private double _ratio = 0.01;

            public double Ratio { get => _ratio; set => _ratio = value; }
        }
        internal class BananeL : IUnite
        {
            private string _code = "5";

            public string Code { get => _code; private set => _code = value; }


            private string _label = "banane";

            public string Label { get => _label; private set => _label = value; }

            private Dimension _dimension = Dimension.Longueur;

            public Dimension Dimension { get => _dimension; private set => _dimension = value; }

            private double _ratio = 0.12;

            public double Ratio { get => _ratio; set => _ratio = value; }
        }
        internal class Millimetre : IUnite
        {
            private string _code = "6";

            public string Code { get => _code; private set => _code = value; }


            private string _label = "millimetre";

            public string Label { get => _label; private set => _label = value; }

            private Dimension _dimension = Dimension.Longueur;

            public Dimension Dimension { get => _dimension; private set => _dimension = value; }

            private double _ratio = 0.001;

            public double Ratio { get => _ratio; set => _ratio = value; }
        }
        internal class Micrometre : IUnite
        {
            private string _code = "7";

            public string Code { get => _code; private set => _code = value; }


            private string _label = "micrometre";

            public string Label { get => _label; private set => _label = value; }

            private Dimension _dimension = Dimension.Longueur;

            public Dimension Dimension { get => _dimension; private set => _dimension = value; }

            private double _ratio = 7;

            public double Ratio { get => _ratio; set => _ratio = value; }
        }
        internal class Nanometre : IUnite
        {
            private string _code = "8";

            public string Code { get => _code; private set => _code = value; }


            private string _label = "nanometre";

            public string Label { get => _label; private set => _label = value; }

            private Dimension _dimension = Dimension.Longueur;

            public Dimension Dimension { get => _dimension; private set => _dimension = value; }

            private double _ratio = 0.000000001;

            public double Ratio { get => _ratio; set => _ratio = value; }
        }
        internal class Mile : IUnite
        {
            private string _code = "9";

            public string Code { get => _code; private set => _code = value; }


            private string _label = "mile";

            public string Label { get => _label; private set => _label = value; }

            private Dimension _dimension = Dimension.Longueur;

            public Dimension Dimension { get => _dimension; private set => _dimension = value; }

            private double _ratio = 1609.34;

            public double Ratio { get => _ratio; set => _ratio = value; }
        }
        internal class Yard : IUnite
        {
            private string _code = "10";

            public string Code { get => _code; private set => _code = value; }


            private string _label = "yard";

            public string Label { get => _label; private set => _label = value; }

            private Dimension _dimension = Dimension.Longueur;

            public Dimension Dimension { get => _dimension; private set => _dimension = value; }

            private double _ratio = 0.9144;

            public double Ratio { get => _ratio; set => _ratio = value; }
        }
        internal class Pied : IUnite
        {
            private string _code = "11";

            public string Code { get => _code; private set => _code = value; }


            private string _label = "pied";

            public string Label { get => _label; private set => _label = value; }

            private Dimension _dimension = Dimension.Longueur;

            public Dimension Dimension { get => _dimension; private set => _dimension = value; }

            private double _ratio = 0.3048;

            public double Ratio { get => _ratio; set => _ratio = value; }
        }
        internal class Pouce : IUnite
        {
            private string _code = "12";

            public string Code { get => _code; private set => _code = value; }


            private string _label = "pouce";

            public string Label { get => _label; private set => _label = value; }

            private Dimension _dimension = Dimension.Longueur;

            public Dimension Dimension { get => _dimension; private set => _dimension = value; }

            private double _ratio = 0.0254;

            public double Ratio { get => _ratio; set => _ratio = value; }
        }
    }
}
