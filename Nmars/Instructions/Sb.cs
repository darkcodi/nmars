using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Sb : MipsInstruction
    {
        public override string Name => "Store byte";
        public override string Description => "The least significant byte of $t is stored at the specified address.";
        public override string Operation => "MEM[$s + offset] = (0xff & $t); advance_pc (4);";
        public override string Syntax => "sb $t, offset ($s)";
        public override string Encoding => "1010 00ss ssst tttt oooo oooo oooo oooo";
    }
}