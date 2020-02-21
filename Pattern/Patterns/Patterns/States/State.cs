using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Structure;
using Patterns.Command;

namespace Patterns.States
{
    public abstract class State
    {
        protected Context context;
        protected ICommand _command;

        public ICommand Command {
            get
            {
                return this._command;
            }

            set
            {
                if (value != null)
                {
                    this._command = value;
                }
            }
        }

        public State(ICommand command)
        {
            this._command = command ?? throw new ArgumentNullException(nameof(command));
        }

        public void SetContext(Context context)
        {
            this.context = context;
        }

        public virtual void Handle(string name)
        {
            Console.Write($"Hero {name}:");
            this._command.Exicute();
            Console.WriteLine();
        }
    }
}
