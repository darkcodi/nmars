using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class And : MipsInstruction
    {
        public override string Name => "Bitwise and";
        public override string Description => "Bitwise ands two registers and stores the result in a register";
        public override string Operation => "$d = $s & $t; advance_pc (4);";
        public override string Syntax => "and $d, $s, $t";
        public override string Encoding => "0000 00ss ssst tttt dddd d000 0010 0100";
    }
}