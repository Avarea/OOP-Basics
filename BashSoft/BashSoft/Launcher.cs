namespace BashSoft
{
    using BashSoft.Static_data;

    class Launcher
    {
        static void Main()
        {
            Welcome.Message();
            Tester tester = new Tester();
            IOManager ioManager = new IOManager();
            StudentsRepository repo = new StudentsRepository(new RepositoryFilter(), new RepositorySorter());
            
            CommandInterpreter currentInterpreter = new CommandInterpreter(tester,repo, ioManager);
            InputReader reader = new InputReader(currentInterpreter);
            reader.StartReadingCommands();
        }
    }
}
