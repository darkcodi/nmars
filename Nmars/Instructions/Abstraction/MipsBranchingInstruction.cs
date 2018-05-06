using System;

namespace Nmars.Instructions.Abstraction
{
    public abstract class MipsBranchingInstruction : MipsInstruction
    {
        public override string Decode(string instructionBinary)
        {
            var originalDecodedInstruction = base.Decode(instructionBinary);

            return $"{originalDecodedInstruction}{Environment.NewLine}" +
                   $"(NOTE: Replace hex with label. Label offset relatively to this instruction is specified by hex)";
        }
    }
}