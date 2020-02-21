using System;
using Patterns.Factories;
using Patterns.Heroes;
using Patterns.Structure;
using Patterns.Command;
using Patterns.States;
using Patterns.Memento;

namespace Patterns
{
    public class Program
    {
        private static readonly IHeroFactory heroFactory = new HeroFactory(new HeroBuilder());
        private static Dragon singletonHero = Dragon.GetDragon();
        private static Map map = new Map();
        public static void Main(string[] args)
        {
            FillHeroes();
            map.Title = "Main map";
            map.handler += ShowAchievement;

            do
            {
                switch (ShowMenu())
                {
                    case 1:
                        map.AddComponent(new HeroComponentAdapter(MakeHero()));
                        break;
                    case 2:
                        ShowHeroes();
                        break;
                    case 3:
                        FindHero();
                        break;
                    case 4:
                        MoveHero();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        continue;
                }
            } while (true);
        }

        private static void TestSingleton()
        {
            Console.WriteLine(singletonHero.Name);
            singletonHero = Dragon.GetDragon();
            Console.WriteLine(singletonHero.Name);
            Console.ReadKey();
        }

        private static void ShowAchievement(object sender, HeroEventArgs e)
        {
            Console.WriteLine($"Hero {e.HeroName} was added to {(sender as Map).Title}");
            Console.ReadKey();
        }

        private static void FillHeroes()
        {
            var defaultHero = new HeroBuilder()
                .SetArmor("Infinity")
                .SetName("Denis")
                .SetWeapon("--|====>")
                .Build();
            var flyHero = new FlyHeroDecorator(defaultHero);
            map.AddComponent(new HeroComponentAdapter(defaultHero));
            map.AddComponent(new HeroComponentAdapter(heroFactory.MakeAttackHero()));
            map.AddComponent(new HeroComponentAdapter(heroFactory.MakeDistantHero()));
            map.AddComponent(new HeroComponentAdapter(heroFactory.MakeHiddenHero()));
            map.AddComponent(new HeroComponentAdapter(flyHero));
            var winterMap = new Map();
            winterMap.Title = "Winter Map";
            winterMap.AddComponent(new HeroComponentAdapter(
                new HeroBuilder()
                .SetName("Snow")
                .Build())
                );
            map.AddComponent(winterMap);
        }

        private static void MoveHero()
        {
            IComponent hero = null;
            while (hero is null)
            {
                hero = GetComponent();
            }

            var stayState = new SingleState(new StayCommand());
            var runState = new SingleState(new RunCommand());
            var jumpState = new ComplexState(new JumpCommand(), stayState);
            var attackState = new ComplexState(new AttackCommand(), stayState);
            var heroContext = new Context(stayState, hero.Title);
            var stateRestorer = new Restorer(heroContext);
            Console.WriteLine("Game start!");
            do
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        heroContext.Update(jumpState);
                        stateRestorer.BackUp();
                        break;

                    case ConsoleKey.LeftArrow:
                        heroContext.Update(runState);
                        stateRestorer.BackUp();
                        break;
                    case ConsoleKey.RightArrow:
                        heroContext.Update(runState);
                        stateRestorer.BackUp();
                        break;
                    case ConsoleKey.DownArrow:
                        heroContext.Update(attackState);
                        stateRestorer.BackUp();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        stateRestorer.Undo();
                        break;
                }

                heroContext.Request();
            } while (true);
        }

        private static IComponent GetComponent()
        {
            Console.Clear();
            Console.Write("Hero name: ");
            string title = Console.ReadLine();
            var hero = map.Find(title);
            Console.Clear();
            return hero;
        }

        private static void FindHero()
        {
            var hero = GetComponent();
            if (hero is null)
            {
                Console.WriteLine("Information not found");
            }
            else
            {
                hero.Draw();
            }

            Console.ReadKey();
        }

        private static int GetCommand()
        {
            int command;
            do
            {
                Console.Write("Command: ");
            } while (!int.TryParse(Console.ReadLine(), out command));

            return command;
        }

        private static int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Make hero(es)");
            Console.WriteLine("2 - Show hero(es)");
            Console.WriteLine("3 - Find hero");
            Console.WriteLine("4 - Play hero");
            Console.WriteLine("5 - Exit");
            return GetCommand();
        }

        private static void ShowHeroes()
        {
            map.Draw();

            Console.WriteLine("Press key to continue ...");
            Console.ReadKey();
        }

        private static Hero MakeHero()
        {
            Console.Clear();
            Console.WriteLine("1 - Make custom hero(es)");
            Console.WriteLine("2 - Make factory hero(es)");
            do
            {
                switch (GetCommand())
                {
                    case 1:
                        return MakeCustomHero();
                    case 2:
                        return MakeFactoryHero();
                }
            } while (true);
        }

        private static Hero MakeCustomHero()
        {
            var builder = new HeroBuilder();
            bool isFlyHero = false;
            do
            {
                Console.Clear();
                Console.WriteLine("0 - Set\\Unset fly mode");
                Console.WriteLine("1 - Set name");
                Console.WriteLine("2 - Set armor");
                Console.WriteLine("3 - Set weapon");
                Console.WriteLine("4 - Build hero");
                switch (GetCommand())
                {
                    case 0:
                        isFlyHero = !isFlyHero;
                        break;
                    case 1:
                        Console.Write("Name: ");
                        builder.SetName(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("Armor: ");
                        builder.SetArmor(Console.ReadLine());
                        break;
                    case 3:
                        Console.Write("Weapon: ");
                        builder.SetWeapon(Console.ReadLine());
                        break;
                    case 4:
                        if (isFlyHero)
                        {
                            return new FlyHeroDecorator(builder.Build());
                        }
                        else
                        {
                            return builder.Build();
                        }
                }
            } while (true);
        }

        private static Hero MakeFactoryHero()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Warrior");
                Console.WriteLine("2 - Assassin");
                Console.WriteLine("3 - Archer");
                switch (GetCommand())
                {
                    case 1:
                        return heroFactory.MakeAttackHero();
                    case 2:
                        return heroFactory.MakeHiddenHero();
                    case 3:
                        return heroFactory.MakeDistantHero();
                }
            } while (true);
        }
    }
}
