using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Xori : MipsInstruction
    {
        public override string Name => "Bitwise exclusive or immediate";
        public override string Description =>
            "Bitwise exclusive ors a register and an immediate value and stores the result in a register";
        public override string Operation => "$t = $s ^ imm; advance_pc (4);";
        public override string Syntax => "xori $t, $s, imm";
        public override string Encoding => "0011 10ss ssst tttt iiii iiii iiii iiii";
    }
}