﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Heroes
{
    public class Warrior : IHeroDirector
    {
        private readonly IHeroBuilder builder;

        public Warrior(IHeroBuilder builder)
        {
            this.builder = builder ?? throw new ArgumentNullException(nameof(builder));
        }

        public Hero GetHero()
        {
            var name = Generator.GetName();
            var hero = builder
                .SetName(name)
                .SetArmor("Plate")
                .SetWeapon("Blades")
                .Build();
            return hero;
        }
    }
}
