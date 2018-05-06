using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Blez : MipsBranchingInstruction
    {
        public override string Name => "Branch on less than or equal to zero";
        public override string Description => "Branches if the register is less than or equal to zero";
        public override string Operation => "if $s <= 0 advance_pc (offset << 2)); else advance_pc (4);";
        public override string Syntax => "blez $s, offset";
        public override string Encoding => "0001 10ss sss0 0000 oooo oooo oooo oooo";
    }
}