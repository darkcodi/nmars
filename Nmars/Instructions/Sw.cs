using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Sw : MipsInstruction
    {
        public override string Name => "Store word";
        public override string Description => "The contents of $t is stored at the specified address.";
        public override string Operation => "MEM[$s + offset] = $t; advance_pc (4);";
        public override string Syntax => "sw $t, offset ($s)";
        public override string Encoding => "1010 11ss ssst tttt oooo oooo oooo oooo";
    }
}