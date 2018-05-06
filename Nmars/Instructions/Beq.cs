using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Beq : MipsBranchingInstruction
    {
        public override string Name => "Branch on equal";
        public override string Description => "Branches if the two registers are equal";
        public override string Operation => "if $s == $t advance_pc (offset << 2)); else advance_pc (4);";
        public override string Syntax => "beq $s, $t, offset";
        public override string Encoding => "0001 00ss ssst tttt oooo oooo oooo oooo";
    }
}