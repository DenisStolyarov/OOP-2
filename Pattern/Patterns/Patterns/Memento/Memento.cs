using Patterns.States;
using System;
namespace Patterns.Memento
{
    public class Memento : IMemento
    {
        private State state;

        public Memento(State state)
        {
            this.state = state ?? throw new ArgumentNullException(nameof(state));
        }

        public State GetState()
        {
            return this.state;
        }

        public void SetState(State state)
        {
            if (state != null)
            {
                this.state = state;
            }
        }
    }
}
