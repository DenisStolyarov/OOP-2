using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGenerator
{
    public class Randomer
    {
        private static Random randomer = new Random();
        public int Value { get; }
        public Randomer()
        {
            this.Value = randomer.Next(0, 1000);
        }

        public override string ToString()
        {
            return $"Random value: {this.Value}";
        }
    }
}
