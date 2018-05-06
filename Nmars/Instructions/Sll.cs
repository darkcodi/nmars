using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Sll : MipsInstruction
    {
        public override string Name => "Shift left logical";
        public override string Description =>
            "Shifts a register value left by the shift amount listed in the instruction and places the result in a third register. Zeroes are shifted in.";
        public override string Operation => "$d = $t << h; advance_pc (4);";
        public override string Syntax => "sll $d, $t, h";
        public override string Encoding => "0000 00ss ssst tttt dddd dhhh hh00 0000";
    }
}