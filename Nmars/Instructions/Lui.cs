using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Lui : MipsInstruction
    {
        public override string Name => "Load upper immediate";
        public override string Description =>
            "The immediate value is shifted left 16 bits and stored in the register. The lower 16 bits are zeroes.";
        public override string Operation => "$t = (imm << 16); advance_pc (4);";
        public override string Syntax => "lui $t, imm";
        public override string Encoding => "0011 11-- ---t tttt iiii iiii iiii iiii";
    }
}