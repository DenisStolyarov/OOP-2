using Patterns.Heroes;
using System;

namespace Patterns.Factories
{
    public class HeroFactory : IHeroFactory
    {
        private readonly IHeroBuilder builder;
        public HeroFactory(IHeroBuilder builder)
        {
            this.builder = builder ?? throw new ArgumentNullException(nameof(builder));
        }

        public Hero MakeAttackHero()
        {
            return new Warrior(this.builder).GetHero();
        }

        public Hero MakeDistantHero()
        {
            return new Archer(this.builder).GetHero();
        }

        public Hero MakeHiddenHero()
        {
            return new Assassin(this.builder).GetHero();
        }
    }
}
