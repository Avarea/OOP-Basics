namespace BashSoft
{
    using System;

    public class InputReader
    {
        private CommandInterpreter interpreter;
        private const string endCommand = "quit";

        public InputReader(CommandInterpreter interpreter)
        {
            this.interpreter = interpreter;
        }

        public void StartReadingCommands()
        {
            OutputWriter.WriteMessage($"{SessionData.currentPath}>");
            string input = "";


            while (input != endCommand)
            {
                OutputWriter.WriteMessage($"{SessionData.currentPath}>");
                input = input.Trim();
                input = Console.ReadLine();
                interpreter.InterpredComands(input);
            }
        }
    }
}
