using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Heroes
{
    public class HeroBuilder : IHeroBuilder
    {
        private readonly Hero hero = new Hero();

        public IHeroBuilder SetArmor(string armor)
        {
            if (!string.IsNullOrEmpty(armor))
            {
                this.hero.Armor = armor;
            }

            return this;
        }


        public IHeroBuilder SetName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                this.hero.Name = name;
            }

            return this;
        }

        public IHeroBuilder SetWeapon(string weapon)
        {
            if (!string.IsNullOrEmpty(weapon))
            {
                this.hero.Weapon = weapon;
            }

            return this;
        }

        public Hero Build()
        {
            return (Hero)this.hero.Clone();
        }
    }
}
