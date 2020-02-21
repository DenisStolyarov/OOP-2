using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    public class AttackCommand : ICommand
    {
        public void Exicute()
        {
            Console.Write("I'm attack");
        }
    }
}
