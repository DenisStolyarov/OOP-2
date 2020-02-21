using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Heroes
{
    public sealed class Dragon
    {
        private Dragon() 
        {
            this.Name = Generator.GetName();
        }

        private static volatile Dragon _instance;

        private static readonly object _lock = new object();

        public static Dragon GetDragon()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Dragon();
                    }
                }
            }
            return _instance;
        }

        public string Name { get; }
    }
}
