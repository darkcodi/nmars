using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Bgezal : MipsBranchingInstruction
    {
        public override string Name => "Branch on greater than or equal to zero and link";
        public override string Description =>
            "Branches if the register is greater than or equal to zero and saves the return address in $31";
        public override string Operation =>
            "if $s >= 0 $31 = PC + 8 (or nPC + 4); advance_pc (offset << 2)); else advance_pc (4);";
        public override string Syntax => "bgezal $s, offset";
        public override string Encoding => "0000 01ss sss1 0001 oooo oooo oooo oooo";
    }
}