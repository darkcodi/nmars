using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class J : MipsBranchingInstruction
    {
        public override string Name => "Jump";
        public override string Description => "Jumps to the calculated address";
        public override string Operation => "PC = nPC; nPC = (PC & 0xf0000000) | (target << 2);";
        public override string Syntax => "j target";
        public override string Encoding => "0000 10tt tttt tttt tttt tttt tttt tttt";
    }
}