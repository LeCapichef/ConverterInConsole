namespace ConsoleApp1.ConsoleMain
{
    public interface IDimension
    {
        int Position { get; }
        string DimensionLabel { get; }
        IEnumerable<IUnit> Unites { get; }
    }

    public interface IUnit
    {
        int Position { get; }
        string Code { get; }
        string DimensionLabel { get;  }
        DimensionEnum Dimension { get; }
        string Label { get; }
        double Ratio { get; }
        string Info { get; }
    }

    public interface IListable
    {
        void Liste();
    }
}