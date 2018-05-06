using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Sra : MipsInstruction
    {
        public override string Name => "Shift right arithmetic";
        public override string Description =>
            "Shifts a register value right by the shift amount (shamt) and places the value in the destination register. The sign bit is shifted in.";
        public override string Operation => "$d = $t >> h; advance_pc (4);";
        public override string Syntax => "sra $d, $t, h";
        public override string Encoding => "0000 00-- ---t tttt dddd dhhh hh00 0011";
    }
}