using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Slti : MipsInstruction
    {
        public override string Name => "Set on less than immediate (signed)";
        public override string Description => "If $s is less than immediate, $t is set to one. It gets zero otherwise.";
        public override string Operation => "if $s < imm $t = 1; advance_pc (4); else $t = 0; advance_pc (4);";
        public override string Syntax => "slti $t, $s, imm";
        public override string Encoding => "0010 10ss ssst tttt iiii iiii iiii iiii";
    }
}