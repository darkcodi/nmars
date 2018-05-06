using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Sllv : MipsInstruction
    {
        public override string Name => "Shift left logical variable";
        public override string Description =>
            "Shifts a register value left by the value in a second register and places the result in a third register. Zeroes are shifted in.";
        public override string Operation => "$d = $t << $s; advance_pc (4);";
        public override string Syntax => "sllv $d, $t, $s";
        public override string Encoding => "0000 00ss ssst tttt dddd d--- --00 0100";
    }
}