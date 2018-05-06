namespace Nmars
{
    public interface IInstruction
    {
        string Abbreviation { get; }
        string Name { get; }
        string Description { get; }
        string Operation { get; }
        string Syntax { get; }
        string Encoding { get; }

        bool Match(string instructionBinary);
    }
}