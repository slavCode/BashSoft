namespace BashSoft
{
    using System;

    public class InputReader
    {
        private const string endCommand = "quit";
        private CommandInterpreter interpreter;

        public InputReader(CommandInterpreter interpreter)
        {
            this.interpreter = interpreter;
        }
        public  void StartReadingCommands()
        {
            OutputWriter.WriteMessage($"{SessionData.CurrentPath}" + "> ");
            string input = Console.ReadLine().Trim();

            while (input != endCommand)
            {
                this.interpreter.InterpretCommand(input);
                OutputWriter.WriteMessage($"{SessionData.CurrentPath}" + "> ");
                input = Console.ReadLine().Trim();
            }
        }
    }
}
