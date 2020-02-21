using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Heroes;

namespace Patterns.Factories
{
    interface IHeroFactory
    {
        Hero MakeDistantHero();
        Hero MakeAttackHero();
        Hero MakeHiddenHero();
    }
}
