using System;
using System.Text;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;

namespace Univer
{
    [Serializable]
    public class Student
    {
        [Required]
        public int Id { get; set; }

        [RegularExpression(@"^[A-Z]{1}\w+")]
        [StringLength(60,MinimumLength = 2)]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Patronymic { get; set; }

        [Range(1,200, ErrorMessage = "Wrong Format!")]
        public int Age { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Course { get; set; }

        public int Group { get; set; }

        public double AverageBall { get; set; }

        public char Gender { get; set; }

        public Address HomeAddress { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder
                .Append($"{this.FirstName}, ")
                .Append($"{this.LastName}, ")
                .Append($"{this.Patronymic}, ")
                .Append($"{this.Age}, ")
                .Append($"{this.DateOfBirth.ToShortDateString()}, ")
                .Append($"{this.Course}c, ")
                .Append($"{this.Group}g, ")
                .Append($"{this.AverageBall}, ")
                .Append($"{this.Gender}, ")
                .Append($"{this.HomeAddress.Index}, ")
                .Append($"{this.HomeAddress.City}, ")
                .Append($"{this.HomeAddress.Street}, ")
                .Append($"{this.HomeAddress.House}, ")
                .Append($"{this.HomeAddress.Apartment}, ");

            return builder.ToString();
        }
    }
}
