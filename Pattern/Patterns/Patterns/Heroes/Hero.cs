using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Heroes
{
    public enum HeroType
    {
        Warrior,
        Assassin,
        Archer,
    }

    public class Hero : ICloneable
    {
        public virtual string Name { get; set; }

        public virtual string Weapon { get; set; }

        public virtual string Armor { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            string noInformationMessage = "--Absent--";
            var builder = new StringBuilder();
            builder.Append($"Hero name: ");
            if (this.Name != null)
            {
                builder.Append(this.Name);
            }
            else
            {
                builder.Append(noInformationMessage);
            }

            builder.Append(Environment.NewLine + "Weapon: ");
            if (this.Weapon != null)
            {
                builder.Append(this.Weapon);
            }
            else
            {
                builder.Append(noInformationMessage);
            }

            builder.Append(Environment.NewLine + "Armor: ");
            if (this.Weapon != null)
            {
                builder.Append(this.Armor);
            }
            else
            {
                builder.Append(noInformationMessage);
            }

            return builder.ToString();
        }
    }
}
