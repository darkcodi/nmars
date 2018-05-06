using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Subu : MipsInstruction
    {
        public override string Name => "Subtract unsigned";
        public override string Description => "Subtracts two registers and stores the result in a register";
        public override string Operation => "$d = $s - $t; advance_pc (4);";
        public override string Syntax => "subu $d, $s, $t";
        public override string Encoding => "0000 00ss ssst tttt dddd d000 0010 0011";
    }
}