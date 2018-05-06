using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Andi : MipsInstruction
    {
        public override string Name => "Bitwise and immediate";
        public override string Description =>
            "Bitwise ands a register and an immediate value and stores the result in a register";
        public override string Operation => "$t = $s & imm; advance_pc (4);";
        public override string Syntax => "andi $t, $s, imm";
        public override string Encoding => "0011 00ss ssst tttt iiii iiii iiii iiii";
    }
}