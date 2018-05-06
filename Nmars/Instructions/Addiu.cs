using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Addiu : MipsInstruction
    {
        public override string Name => "Add immediate unsigned (no overflow)";
        public override string Description =>
            "Adds a register and a sign-extended immediate value and stores the result in a register";
        public override string Operation => "$t = $s + imm; advance_pc (4);";
        public override string Syntax => "addiu $t, $s, imm";
        public override string Encoding => "0010 01ss ssst tttt iiii iiii iiii iiii";
    }
}