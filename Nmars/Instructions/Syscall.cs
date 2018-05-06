using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Syscall : MipsInstruction
    {
        public override string Name => "System call";
        public override string Description => "Generates a software interrupt.";
        public override string Operation => "advance_pc (4);";
        public override string Syntax => "syscall";
        public override string Encoding => "0000 00-- ---- ---- ---- ---- --00 1100";
    }
}