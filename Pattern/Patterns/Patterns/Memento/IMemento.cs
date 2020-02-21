using Patterns.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Memento
{
    public interface IMemento
    {
        State GetState();

        void SetState(State state);
    }
}
