using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Multu : MipsInstruction
    {
        public override string Name => "Multiply unsigned";
        public override string Description => "Multiplies $s by $t and stores the result in $LO.";
        public override string Operation => "$LO = $s * $t; advance_pc (4);";
        public override string Syntax => "multu $s, $t";
        public override string Encoding => "0000 00ss ssst tttt 0000 0000 0001 1001";
    }
}