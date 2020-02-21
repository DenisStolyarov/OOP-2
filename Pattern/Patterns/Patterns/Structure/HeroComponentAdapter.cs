using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Patterns.Heroes;

namespace Patterns.Structure
{
    public class HeroComponentAdapter : IComponent
    {
        private readonly Hero hero;

        public HeroComponentAdapter(Hero hero)
        {
            this.hero = hero ?? throw new ArgumentNullException(nameof(hero));
        }

        public string Title { get => this.hero.Name; set => this.hero.Name = value; }

        public void Draw()
        {
            Thread.Sleep(50);
            var random = new Random();
            int x = random.Next(0, 100);
            int y = random.Next(0, 100);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(this.hero);
            Console.WriteLine($"Position -X:{x}-Y:{y}-");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------------------------");
            Console.ResetColor();
        }

        public IComponent Find(string title)
        {
            return this;
        }

        public override string ToString()
        {
            return this.hero.ToString();
        }
    }
}
