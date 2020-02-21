using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Heroes
{
    public interface IHeroBuilder
    {
        IHeroBuilder SetName(string name);
        IHeroBuilder SetWeapon(string weapon);
        IHeroBuilder SetArmor(string armor);
        Hero Build();
    }
}
