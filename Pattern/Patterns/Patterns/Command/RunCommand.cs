using System;

namespace Patterns.Command
{
    public class RunCommand : ICommand
    {
        public void Exicute()
        {
            Console.Write("I'm running ...");
        }
    }
}
