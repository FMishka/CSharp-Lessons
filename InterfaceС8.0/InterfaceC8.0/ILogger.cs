using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceC8._0
{
    interface ILogger
    {
        void Log(LogLevel logLevel, string message);

        void Foo()
        {
            Console.WriteLine("Реализация в интрефейсе");
        }
    }
}
