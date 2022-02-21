using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIAssignment1.Entities
{
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName {get;set;}
        public string Gender {get; set;}
        public string BirthPlace { get; set; }
    }
}