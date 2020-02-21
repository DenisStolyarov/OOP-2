using Patterns.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.States
{
    public class ComplexState : State
    {
        private readonly State state;   
        public ComplexState(ICommand command, State state) : base(command)
        {
            this.state = state ?? throw new ArgumentNullException(nameof(state));
        }

        public override void Handle(string name)
        {
            base.Handle(name);
            this.context.Update(this.state);
            this.state.Handle(name);
        }
    }
}
