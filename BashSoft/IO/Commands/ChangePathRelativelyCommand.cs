namespace BashSoft.IO.Commands
{
    using Execptions;
    using System;

    public class ChangePathRelativelyCommand : Command
    {
        public ChangePathRelativelyCommand(string input, string[] data, Tester judge, StudentsRepository repository,
            IOManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager) { }

        public override void Execute()
        {
            if (this.Data.Length < 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            string relPath = GetReleativePath(this.Data);
            this.InputOutputManager.ChangeCurrentDirectoryRelative(relPath);
        }

        private string GetReleativePath(string[] data)
        {
            string path = String.Join(" ", data);
            int firstIndex = path.IndexOf(' ');

            return path.Substring(firstIndex + 1);
        }
    }
}
