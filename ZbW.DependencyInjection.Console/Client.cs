namespace ZbW.DependencyInjection.Console
{
    using System;

    internal class Client
    {
        public void DoWork(IWritable writable)
        {
            writable.Write($"{DateTime.Now}: Judihui ==> Es funzt!");
        }
    }
}