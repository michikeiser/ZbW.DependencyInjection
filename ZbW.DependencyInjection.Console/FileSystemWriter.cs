namespace ZbW.DependencyInjection.Console
{
    using System.IO;

    internal class FileSystemWriter : IWritable
    {
        private const string PATH = @"C:\Temp\TempFile.txt";

        public void Write(string message)
        {
            File.WriteAllText(PATH, message);
        }
    }
}