using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Patterns.States;

namespace Patterns.Memento
{
    public class Restorer
    {
        private Stack<IMemento> mementos = new Stack<IMemento>();
        private readonly Context context;

        public Restorer(Context context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void BackUp()
        {
            this.mementos.Push(this.context.GetMemento());
        }

        public void Undo()
        {
            if (!this.mementos.Count.Equals(0))
            {
                this.context.Update(this.mementos.Pop().GetState());
            }
        }
    }
}
