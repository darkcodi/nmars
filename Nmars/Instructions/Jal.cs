using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Jal : MipsBranchingInstruction
    {
        public override string Name => "Jump and link";
        public override string Description => "Jumps to the calculated address and stores the return address in $31";
        public override string Operation =>
            "$31 = PC + 8 (or nPC + 4); PC = nPC; nPC = (PC & 0xf0000000) | (target << 2);";
        public override string Syntax => "jal target";
        public override string Encoding => "0000 11tt tttt tttt tttt tttt tttt tttt";
    }
}