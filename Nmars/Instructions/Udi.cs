using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Udi : MipsInstruction
    {
        public override string Name => "User defined instruction";
        public override string Description => "A custom instruction that is defined via CorExtend interface";
        public override string Operation => "<unknown>";
        public override string Syntax => "udi (x) $s, $t, user-defined";
        public override string Encoding => "0111 00ss ssst tttt uuuu uuuu uu01 xxxx";
    }
}
