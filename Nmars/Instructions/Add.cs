namespace Nmars.Instructions
{
    public class Add : Instruction
    {
        public override string Name => "Add (with overflow)";
        public override string Description => "Adds two registers and stores the result in a register";
        public override string Operation => "$d = $s + $t; advance_pc (4);";
        public override string Syntax => "add $d, $s, $t";
        public override string Encoding => "0000 00ss ssst tttt dddd d000 0010 0000";
    }
}