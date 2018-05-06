using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Or : MipsInstruction
    {
        public override string Name => "Bitwise or";
        public override string Description => "Bitwise logical ors two registers and stores the result in a register";
        public override string Operation => "$d = $s | $t; advance_pc (4);";
        public override string Syntax => "or $d, $s, $t";
        public override string Encoding => "0000 00ss ssst tttt dddd d000 0010 0101";
    }
}