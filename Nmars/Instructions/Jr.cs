using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Jr : MipsBranchingInstruction
    {
        public override string Name => "Jump register";
        public override string Description => "Jump to the address contained in register $s";
        public override string Operation => "PC = nPC; nPC = $s;";
        public override string Syntax => "jr $s";
        public override string Encoding => "0000 00ss sss0 0000 0000 0000 0000 1000";
    }
}