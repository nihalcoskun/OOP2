using OOP3;
using System;

class FileLoggerService : ILoggerService
{
    public void Log()
    {
        Console.WriteLine("Dosyaya loglandı");
    }
}