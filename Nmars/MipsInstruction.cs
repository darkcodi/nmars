using System;
using System.Collections.Generic;
using System.Linq;

namespace Nmars
{
    public abstract class MipsInstruction : IInstruction
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

        public string Decode(string instructionBinary)
        {
            if (!Match(instructionBinary))
                throw new ArgumentException(nameof(instructionBinary));
            
            var syntaxParts = Syntax.Split(' ');
            
            var decodedInstruction = syntaxParts.First();
            for (int i = 1; i < syntaxParts.Length; i++)
            {
                var encodingChar = syntaxParts[i].Replace("(", "").Replace(")", "").TrimStart('$').First();
                var value = GetParamValue(instructionBinary, encodingChar);

                bool isRegister = syntaxParts[i].Contains("$");
                decodedInstruction += isRegister ?
                    $" {Registers[value]}," :
                    $" 0x{value:X},";
            }

            return decodedInstruction.TrimEnd(',');
        }

        private int GetParamValue(string instructionBinary, char encodingChar)
        {
            var encoding = Encoding.Replace(" ", "");
            
            var binaryValue = "";
            for (int j = 0; j < encoding.Length; j++)
            {
                if (encoding[j] == encodingChar)
                    binaryValue += instructionBinary[j];
            }

            return Convert.ToInt32(binaryValue, 2);
        }

        private readonly Dictionary<int, string> Registers = new Dictionary<int, string>
        {
            { 0, "$0" },
            { 1, "$at" },
            { 2, "$v0" },
            { 3, "$v1" },
            { 4, "$a0" },
            { 5, "$a1" },
            { 6, "$a2" },
            { 7, "$a3" },
            { 8, "$t0" },
            { 9, "$t1" },
            { 10, "$t2" },
            { 11, "$t3" },
            { 12, "$t4" },
            { 13, "$t5" },
            { 14, "$t6" },
            { 15, "$t7" },
            { 16, "$s0" },
            { 17, "$s1" },
            { 18, "$s2" },
            { 19, "$s3" },
            { 20, "$s4" },
            { 21, "$s5" },
            { 22, "$s6" },
            { 23, "$s7" },
            { 24, "$t8" },
            { 25, "$t9" },
            { 26, "$k0" },
            { 27, "$k1" },
            { 28, "$gp" },
            { 29, "$sp" },
            { 30, "$fp" },
            { 31, "$ra" },
        };
    }
}