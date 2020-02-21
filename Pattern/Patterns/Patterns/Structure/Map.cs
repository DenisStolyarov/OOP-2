using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structure
{
    public class Map : IComponent
    {
        private readonly List<IComponent> map = new List<IComponent>();

        public EventHandler<HeroEventArgs> handler;

        public string Title { get; set; }

        public void Draw()
        {
            foreach (var item in this.map)
            {
                item.Draw();
            }
        }

        public void AddComponent(IComponent component)
        {
            if (component is null)
            {
                throw new ArgumentNullException(nameof(component));
            }
            this.handler?.Invoke(this, new HeroEventArgs(component.Title));
            this.map.Add(component);
        }

        public IComponent Find(string title)
        {
            foreach (var item in this.map)
            {
                if (item.Find(title).Title.Equals(title))
                {
                    return item;
                }
            }

            return null;
        }
    }
}
