using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Bltzal : MipsBranchingInstruction
    {
        public override string Name => "Branch on less than zero and link";
        public override string Description =>
            "Branches if the register is less than zero and saves the return address in $31";
        public override string Operation =>
            "if $s < 0 $31 = PC + 8 (or nPC + 4); advance_pc (offset << 2)); else advance_pc (4);";
        public override string Syntax => "bltzal $s, offset";
        public override string Encoding => "0000 01ss sss1 0000 oooo oooo oooo oooo";
    }
}