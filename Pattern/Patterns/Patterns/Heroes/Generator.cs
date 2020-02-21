using Bogus;

namespace Patterns.Heroes
{
    public static class Generator
    {
        private static Faker generator = new Faker(); 
        public static string GetName()
        {
            string name = generator.Name.FirstName();
            return name;
        }
    }
}
