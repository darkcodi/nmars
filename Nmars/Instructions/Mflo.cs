using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Mflo : MipsInstruction
    {
        public override string Name => "Move from LO";
        public override string Description => "The contents of register LO are moved to the specified register.";
        public override string Operation => "$d = $LO; advance_pc (4);";
        public override string Syntax => "mflo $d";
        public override string Encoding => "0000 0000 0000 0000 dddd d000 0001 0010";
    }
}