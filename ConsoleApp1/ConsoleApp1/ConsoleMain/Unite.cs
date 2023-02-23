using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.ConsoleMain
{
    public class Dimension : IDimension
    {
        private int _Position;
        public int Position { get => _Position; }

        private string _DimensionLabel;
        public string DimensionLabel { get => _DimensionLabel; }

        private IEnumerable<IUnit> _Unites;
        public IEnumerable<IUnit> Unites { get => _Unites; }

        public Dimension(int position, string dimensionLabel, IEnumerable<IUnit> unites)
        {
            _Position = position;
            _DimensionLabel = dimensionLabel;
            _Unites = unites;
        }
    }

    public class Unite : IUnit
    {
        private int _Position;
        public int Position { get => _Position; }

        private string _Code;
        public string Code { get => _Code; }

        private string _DimensionLabel;
        public string DimensionLabel { get => _DimensionLabel; }

        private DimensionEnum _Dimension;
        public DimensionEnum Dimension { get=> _Dimension; }

        private string _Label;
        public string Label { get => _Label; }

        private double _Ratio;
        public double Ratio { get => _Ratio; }

        private string _Info;
        public string Info { get => _Info; }

        public Unite(string position, string dimension, string code, string label, string ratio, string info)
        {
            if (string.IsNullOrWhiteSpace(position)) throw new ArgumentNullException(nameof(position));
            if (string.IsNullOrWhiteSpace(dimension)) throw new ArgumentNullException(nameof(dimension));
            if(string.IsNullOrWhiteSpace(code)) throw new ArgumentNullException(nameof(code));
            if(string.IsNullOrWhiteSpace(label)) throw new ArgumentNullException(nameof(label));
            if(string.IsNullOrWhiteSpace(ratio)) throw new ArgumentNullException(nameof(ratio));
            if (string.IsNullOrWhiteSpace(info)) throw new ArgumentNullException(nameof(info));

            ///a supprimer pour plustard
            dimension = dimension.ToLower();
            switch (dimension)
            {
                case "longueur": _Dimension = DimensionEnum.Longueur; break;
                case "masse": _Dimension = DimensionEnum.Masse; break;
                case "temps": _Dimension = DimensionEnum.Temps; break;
                case "vitesse": _Dimension = DimensionEnum.Vitesse; break;
            }
            int.TryParse(position, out _Position);
            double.TryParse(ratio.Replace('.',','),out _Ratio);
            _Label = label;
            _Info = info;
            _Code= code;

            _DimensionLabel = dimension.ToUpper()[0] + dimension.ToLower().Substring(1, dimension.Length - 1);
        }
    }
}
