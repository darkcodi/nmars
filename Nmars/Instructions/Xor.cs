using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Xor : MipsInstruction
    {
        public override string Name => "Bitwise exclusive or";
        public override string Description => "Exclusive ors two registers and stores the result in a register";
        public override string Operation => "$d = $s ^ $t; advance_pc (4);";
        public override string Syntax => "xor $d, $s, $t";
        public override string Encoding => "0000 00ss ssst tttt dddd d--- --10 0110";
    }
}