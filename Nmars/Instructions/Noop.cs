using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Noop : MipsInstruction
    {
        public override string Name => "no operation";
        public override string Description => "Performs no operation.";
        public override string Operation => "advance_pc (4);";
        public override string Syntax => "noop";
        public override string Encoding => "0000 0000 0000 0000 0000 0000 0000 0000";
    }
}