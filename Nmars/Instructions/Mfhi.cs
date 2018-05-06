using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Mfhi : MipsInstruction
    {
        public override string Name => "Move from HI";
        public override string Description => "The contents of register HI are moved to the specified register.";
        public override string Operation => "$d = $HI; advance_pc (4);";
        public override string Syntax => "mfhi $d";
        public override string Encoding => "0000 0000 0000 0000 dddd d000 0001 0000";
    }
}