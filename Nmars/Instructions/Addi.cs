namespace Nmars.Instructions
{
    public class Addi : Instruction
    {
        public override string Name => "Add immediate (with overflow)";
        public override string Description =>
            "Adds a register and a sign-extended immediate value and stores the result in a register";
        public override string Operation => "$t = $s + imm; advance_pc (4);";
        public override string Syntax => "addi $t, $s, imm";
        public override string Encoding => "0010 00ss ssst tttt iiii iiii iiii iiii";
    }
}