using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Bltz : MipsBranchingInstruction
    {
        public override string Name => "Branch on less than zero";
        public override string Description => "Branches if the register is less than zero";
        public override string Operation => "if $s < 0 advance_pc (offset << 2)); else advance_pc (4);";
        public override string Syntax => "bltz $s, offset";
        public override string Encoding => "0000 01ss sss0 0000 oooo oooo oooo oooo";
    }
}