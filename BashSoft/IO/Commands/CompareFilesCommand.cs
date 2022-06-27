namespace BashSoft.IO.Commands
{
    using Execptions;

    public class CompareFilesCommand : Command
    {
        private string firstPath;
        private string secondPath;
        public CompareFilesCommand(string input, string[] data, Tester judge, StudentsRepository repository,
            IOManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager) 
        {
            this.firstPath = SessionData.CurrentPath + "\\" + data[1]; ;
            this.secondPath = SessionData.CurrentPath + "\\" + data[2]; ;
        }

        public override void Execute()
        {
            if (this.Data.Length != 3)
            {
                throw new InvalidCommandException(this.Input);
            }

            this.Judge.CompareContent(this.firstPath, this.secondPath);
        }
    }
}
