using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Mult : MipsInstruction
    {
        public override string Name => "Multiply";
        public override string Description => "Multiplies $s by $t and stores the result in $LO.";
        public override string Operation => "$LO = $s * $t; advance_pc (4);";
        public override string Syntax => "mult $s, $t";
        public override string Encoding => "0000 00ss ssst tttt 0000 0000 0001 1000";
    }
}