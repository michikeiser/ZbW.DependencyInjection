namespace ZbW.DependencyInjection.Console
{
    using System;

    internal class Builder
    {
        public void Start()
        {
            var client = new Client();

            Console.WriteLine("C = Console | F = File");
            var consoleKeyInfo = Console.ReadKey();

            IWritable writer = null;

            switch (consoleKeyInfo.KeyChar)
            {
                case 'C':
                    writer = new ConsoleWriter();
                    break;

                case 'F':
                    writer = new FileSystemWriter();
                    break;

                default:
                    return;
            }

            client.DoWork(writer);
        }
    }
}