using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Divu : MipsInstruction
    {
        public override string Name => "Divide unsigned";
        public override string Description =>
            "Divides $s by $t and stores the quotient in $LO and the remainder in $HI";
        public override string Operation => "$LO = $s / $t; $HI = $s % $t; advance_pc (4);";
        public override string Syntax => "divu $s, $t";
        public override string Encoding => "0000 00ss ssst tttt 0000 0000 0001 1011";
    }
}