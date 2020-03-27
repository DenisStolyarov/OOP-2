using System;

namespace Univer
{
    [Serializable]
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }

        [Index]
        public int Index { get; set; }

        public string Street { get; set; }

        public int House { get; set; }

        public int Apartment { get; set; }
    }
}
