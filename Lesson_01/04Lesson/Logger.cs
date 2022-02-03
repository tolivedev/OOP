using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons._04Lesson
{
    public abstract class Logger
    {
        public abstract void ShowMessage(string message);
    }
    public sealed class ConsoleLogger : Logger
    {
        public override void ShowMessage(string message)
        {
            if (message != "")
                System.Console.Write(System.DateTime.Now + "  " + message + '\n');
        }
    }
}
