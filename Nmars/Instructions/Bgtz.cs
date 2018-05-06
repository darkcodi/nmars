using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Bgtz : MipsBranchingInstruction
    {
        public override string Name => "Branch on greater than zero";
        public override string Description => "Branches if the register is greater than zero";
        public override string Operation => "if $s > 0 advance_pc (offset << 2)); else advance_pc (4);";
        public override string Syntax => "bgtz $s, offset";
        public override string Encoding => "0001 11ss sss0 0000 oooo oooo oooo oooo";
    }
}