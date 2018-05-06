using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Nmars
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.CancelKeyPress += CancelHandler;
            Console.WriteLine(Constants.WelcomeMessage);

            var loadedInstructions = LoadInstructions().ToList();
            while (true)
            {
                Console.Write(Constants.ConsoleInputInvitation);
                
                var input = Console.ReadLine().TrimStart("0x");
                if (!int.TryParse(input, NumberStyles.HexNumber, NumberFormatInfo.CurrentInfo, out var instruction))
                {
                    Console.WriteLine(Constants.InvalidInputMessage);
                    continue;
                }
                
                var instructionBinary = Convert.ToString(instruction, 2).PadLeft(32, '0');
                var matchingInstruction = loadedInstructions.FirstOrDefault(x => x.Match(instructionBinary));
                
                if (matchingInstruction == null)
                    Console.WriteLine(Constants.InstructionNotFoundMessage);
                else
                {
                    Console.WriteLine($"{matchingInstruction.Abbreviation} - {matchingInstruction.Name}");
                    Console.WriteLine($"{nameof(matchingInstruction.Description)}: {matchingInstruction.Description}");
                    Console.WriteLine($"{nameof(matchingInstruction.Operation)}: {matchingInstruction.Operation}");
                    Console.WriteLine($"{nameof(matchingInstruction.Syntax)}: {matchingInstruction.Syntax}");
                    Console.WriteLine($"{nameof(matchingInstruction.Encoding)}: {matchingInstruction.Encoding}");
                }
            }
            // ReSharper disable once FunctionNeverReturns
        }
        
        private static void CancelHandler(object sender, ConsoleCancelEventArgs args)
        {
            Console.WriteLine(Constants.ExitMessage);
            Environment.Exit(0);
        }

        private static IEnumerable<IInstruction> LoadInstructions()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var namespaceName = $"{assembly.GetName().Name}.{Constants.InstructionsFolderPath}";
            
            var typelist = assembly.GetTypes()
                .Where(t => string.Equals(t.Namespace, namespaceName, StringComparison.Ordinal));
            var instances = typelist.Select(t => (IInstruction) Activator.CreateInstance(t));

            return instances;
        }
    }
}