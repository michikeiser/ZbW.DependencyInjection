namespace ZbW.DependencyInjection.Console
{
    internal class ConsoleWriter : IWritable
    {
        public void Write(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}