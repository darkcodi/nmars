using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Lw : MipsInstruction
    {
        public override string Name => "Load word";
        public override string Description => "A word is loaded into a register from the specified address.";
        public override string Operation => "$t = MEM[$s + offset]; advance_pc (4);";
        public override string Syntax => "lw $t, offset ($s)";
        public override string Encoding => "1000 11ss ssst tttt oooo oooo oooo oooo";
    }
}