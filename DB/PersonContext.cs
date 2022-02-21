using System;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using APIAssignment1.Entities;
using APIAssignment1.Enum;

namespace APIAssignment1.DB
{
    public class PersonContext : DB
    {
        public PersonContext(DBOptions<PersonContext> options) : base(options) { }

        public DbSet<Person> People {get; set;}
       protected override void OnModelCreating(ModuleBuilder moduleBuilder){
           modelBuilder.Entity<Person>().HasData (
               new Person {Id = 1, FirstName= "Truong", LastName="Nguyen", DateofBirth = new DateTime(2000,01,02), Gender = Gender.Male,BirthPlace = "bac ninh"},
               new Person {Id = 1, FirstName= "Trung Anh", LastName="Do", DateofBirth = new DateTime(1999,01,02), Gender = Gender.Male,BirthPlace = "bac kan"},
               new Person {Id = 1, FirstName= "Huong", LastName="Bui", DateofBirth = new DateTime(1998,01,02), Gender = Gender.Male,BirthPlace = "nam ninh"},
               new Person {Id = 1, FirstName= "Chien", LastName="Nguyen", DateofBirth = new DateTime(2000,01,02), Gender = Gender.Male,BirthPlace = "bac ninh"}
           );
       }
    }
}