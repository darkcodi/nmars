using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Ori : MipsInstruction
    {
        public override string Name => "Bitwise or immediate";
        public override string Description =>
            "Bitwise ors a register and an immediate value and stores the result in a register";
        public override string Operation => "$t = $s | imm; advance_pc (4);";
        public override string Syntax => "ori $t, $s, imm";
        public override string Encoding => "0011 01ss ssst tttt iiii iiii iiii iiii";
    }
}