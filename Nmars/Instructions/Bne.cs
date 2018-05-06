using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Bne : MipsBranchingInstruction
    {
        public override string Name => "Branch on not equal";
        public override string Description => "Branches if the two registers are not equal";
        public override string Operation => "if $s != $t advance_pc (offset << 2)); else advance_pc (4);";
        public override string Syntax => "bne $s, $t, offset";
        public override string Encoding => "0001 01ss ssst tttt oooo oooo oooo oooo";
    }
}