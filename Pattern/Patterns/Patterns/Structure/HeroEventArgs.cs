using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structure
{
    public class HeroEventArgs : EventArgs
    {
        public string HeroName { get; }

        public HeroEventArgs(string name)
        {
            this.HeroName = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}
