using System;

namespace Nmars
{
    public abstract class Instruction : IInstruction
    {
        public string Abbreviation => GetType().Name.ToUpper();
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract string Operation { get; }
        public abstract string Syntax { get; }
        public abstract string Encoding { get; }
        
        public bool Match(string instructionBinary)
        {
            var encoding = Encoding.Replace(" ", "");
            if (encoding.Length != instructionBinary.Length)
                return false;

            for (int i = 0; i < encoding.Length; i++)
            {
                var encodingChar = encoding[i];
                if (encodingChar != '0' && encodingChar != '1')
                    continue;

                if (encodingChar != instructionBinary[i])
                    return false;
            }

            return true;
        }
    }
}