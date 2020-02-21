using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Heroes;

namespace Patterns.Structure
{
    public class FlyHeroDecorator : Hero
    {
        private readonly Hero hero;

        public FlyHeroDecorator(Hero hero)
        {
            this.hero = hero ?? throw new ArgumentNullException(nameof(hero));
        }

        public override string Name { get => this.hero.Name; set => this.hero.Name = value; }

        public override string Armor { get => this.hero.Armor; set => this.hero.Armor = value; }

        public override string Weapon { get => this.hero.Weapon; set => this.hero.Weapon = value; }

        public override string ToString()
        {
            string info = $"-- This hero can fly -- {Environment.NewLine}";
            return info + this.hero.ToString();
        }
    }
}
