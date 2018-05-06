using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Bgez : MipsBranchingInstruction
    {
        public override string Name => "Branch on greater than or equal to zero";
        public override string Description => "Branches if the register is greater than or equal to zero";
        public override string Operation => "if $s >= 0 advance_pc (offset << 2)); else advance_pc (4);";
        public override string Syntax => "bgez $s, offset";
        public override string Encoding => "0000 01ss sss0 0001 oooo oooo oooo oooo";
    }
}