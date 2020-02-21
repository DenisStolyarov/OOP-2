using Patterns.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.States
{
    public class SingleState : State
    {
        public SingleState(ICommand command) : base(command)
        {
        }
    }
}
