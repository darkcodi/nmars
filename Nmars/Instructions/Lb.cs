using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Lb : MipsInstruction
    {
        public override string Name => "Load byte";
        public override string Description => "A byte is loaded into a register from the specified address.";
        public override string Operation => "$t = MEM[$s + offset]; advance_pc (4);";
        public override string Syntax => "lb $t, offset ($s)";
        public override string Encoding => "1000 00ss ssst tttt oooo oooo oooo oooo";
    }
}