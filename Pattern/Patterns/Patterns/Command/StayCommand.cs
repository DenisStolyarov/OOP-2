using System;

namespace Patterns.Command
{
    public class StayCommand : ICommand
    {
        public void Exicute()
        {
            Console.Write("I'm staying ...");
        }
    }
}
