using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConsoleMain
{
    public class InfoMasse
    {
        internal class Tonne : IUnite
        {
            private string _code = "1";

            public string Code { get => _code; private set => _code = value; }


            private string _label = "tonne";

            public string Label { get => _label; private set => _label = value; }

            private Dimension _dimension = Dimension.Masse;

            public Dimension Dimension { get => _dimension; private set => _dimension = value; }

            private double _ratio = 1000000;

            public double Ratio { get => _ratio; set => _ratio = value; }
        }
        internal class Kilogramme : IUnite
        {
            private string _code = "2";

            public string Code { get => _code; private set => _code = value; }


            private string _label = "kilogramme";

            public string Label { get => _label; private set => _label = value; }

            private Dimension _dimension = Dimension.Masse;

            public Dimension Dimension { get => _dimension; private set => _dimension = value; }

            private double _ratio = 1000;

            public double Ratio { get => _ratio; set => _ratio = value; }
        }
        internal class Gramme : IUnite
        {
            private string _code = "3";

            public string Code { get => _code; private set => _code = value; }


            private string _label = "gramme";

            public string Label { get => _label; private set => _label = value; }

            private Dimension _dimension = Dimension.Masse;

            public Dimension Dimension { get => _dimension; private set => _dimension = value; }

            private double _ratio = 1;

            public double Ratio { get => _ratio; set => _ratio = value; }
        }
        internal class Milligramme : IUnite
        {
            private string _code = "4";

            public string Code { get => _code; private set => _code = value; }


            private string _label = "milligramme";

            public string Label { get => _label; private set => _label = value; }

            private Dimension _dimension = Dimension.Masse;

            public Dimension Dimension { get => _dimension; private set => _dimension = value; }

            private double _ratio = 0.001;

            public double Ratio { get => _ratio; set => _ratio = value; }
        }
        internal class BananeM : IUnite
        {
            private string _code = "5";

            public string Code { get => _code; private set => _code = value; }


            private string _label = "banane";

            public string Label { get => _label; private set => _label = value; }

            private Dimension _dimension = Dimension.Masse;

            public Dimension Dimension { get => _dimension; private set => _dimension = value; }

            private double _ratio = 120;

            public double Ratio { get => _ratio; set => _ratio = value; }
        }
        internal class EffeilM : IUnite
        {
            private string _code = "6";

            public string Code { get => _code; private set => _code = value; }


            private string _label = "eiffel";

            public string Label { get => _label; private set => _label = value; }

            private Dimension _dimension = Dimension.Masse;

            public Dimension Dimension { get => _dimension; private set => _dimension = value; }

            private double _ratio = 10100000000;

            public double Ratio { get => _ratio; set => _ratio = value; }
        }
        internal class Tonne_Longue : IUnite
        {
            private string _code = "7";

            public string Code { get => _code; private set => _code = value; }


            private string _label = "tonne longue";

            public string Label { get => _label; private set => _label = value; }

            private Dimension _dimension = Dimension.Masse;

            public Dimension Dimension { get => _dimension; private set => _dimension = value; }

            private double _ratio = 1016000;

            public double Ratio { get => _ratio; set => _ratio = value; }
        }
        internal class Tonne_Courte : IUnite
        {
            private string _code = "8";

            public string Code { get => _code; private set => _code = value; }


            private string _label = "tonne courte";

            public string Label { get => _label; private set => _label = value; }

            private Dimension _dimension = Dimension.Masse;

            public Dimension Dimension { get => _dimension; private set => _dimension = value; }

            private double _ratio = 907185;

            public double Ratio { get => _ratio; set => _ratio = value; }
        }
        internal class Stone : IUnite
        {
            private string _code = "9";

            public string Code { get => _code; private set => _code = value; }


            private string _label = "stone";

            public string Label { get => _label; private set => _label = value; }

            private Dimension _dimension = Dimension.Masse;

            public Dimension Dimension { get => _dimension; private set => _dimension = value; }

            private double _ratio = 6350.29;

            public double Ratio { get => _ratio; set => _ratio = value; }
        }
        internal class Livre : IUnite
        {
            private string _code = "10";

            public string Code { get => _code; private set => _code = value; }


            private string _label = "Livre";

            public string Label { get => _label; private set => _label = value; }

            private Dimension _dimension = Dimension.Masse;

            public Dimension Dimension { get => _dimension; private set => _dimension = value; }

            private double _ratio = 453.592;

            public double Ratio { get => _ratio; set => _ratio = value; }
        }
        internal class Once : IUnite
        {
            private string _code = "11";

            public string Code { get => _code; private set => _code = value; }


            private string _label = "once";

            public string Label { get => _label; private set => _label = value; }

            private Dimension _dimension = Dimension.Masse;

            public Dimension Dimension { get => _dimension; private set => _dimension = value; }

            private double _ratio = 28.3495;

            public double Ratio { get => _ratio; set => _ratio = value; }
        }
    }
}