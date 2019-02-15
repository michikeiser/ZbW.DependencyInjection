namespace ZbW.DependencyInjection.Console
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var builder = new Builder();
            builder.Start();

            Console.ReadLine();
        }
    }
}