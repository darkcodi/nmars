using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Srlv : MipsInstruction
    {
        public override string Name => "Shift right logical variable";
        public override string Description =>
            "Shifts a register value right by the amount specified in $s and places the value in the destination register. Zeroes are shifted in.";
        public override string Operation => "$d = $t >> $s; advance_pc (4);";
        public override string Syntax => "srlv $d, $t, $s";
        public override string Encoding => "0000 00ss ssst tttt dddd d000 0000 0110";
    }
}