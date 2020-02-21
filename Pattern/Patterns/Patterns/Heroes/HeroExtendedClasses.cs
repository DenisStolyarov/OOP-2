using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Heroes
{
    public static class HeroExtendedClasses
    {
        public static Hero MakeAssassin(this HeroBuilder builder, string name)
        {
            var hero = builder
                .SetName(name)
                .SetArmor("Plate")
                .SetWeapon("Blades")
                .Build();
            return hero;
        }

        public static Hero MakeWarrior(this HeroBuilder builder, string name)
        {
            var hero = builder
                .SetName(name)
                .SetArmor("Chain mail")
                .SetWeapon("Sword")
                .Build();
            return hero;
        }

        public static Hero MakeArcher(this HeroBuilder builder, string name)
        {
            var hero = builder
                .SetName(name)
                .SetArmor("Leather")
                .SetWeapon("Bow")
                .Build();
            return hero;
        }
    }
}
