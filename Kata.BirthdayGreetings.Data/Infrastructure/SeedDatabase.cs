using Kata.BirthdayGreetings.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.BirthdayGreetings.Data.Infrastructure
{
    public static class SeedDatabase
    {
        public static void SeedPersonTable(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    Id = 1,
                    FirstName = "Mantas",
                    LastName = "Valuckas",
                    DateOfBirth = new DateTime(1999, 08, 11),
                    Email = "valuckas.mantas@gmail.com",
                    PhoneNumber = "865741254"
                },
                new Person
                {
                    Id = 2,
                    FirstName = "Rutenis",
                    LastName = "Naugzemis",
                    DateOfBirth = new DateTime(1999, 05, 05),
                    Email = "rutenis@gmail.com",
                    PhoneNumber = "865741254"
                },
                new Person
                {
                    Id = 3,
                    FirstName = "Aidanas",
                    LastName = "Naugzemis",
                    DateOfBirth = new DateTime(1999, 05, 22),
                    Email = "aidanas93@gmail.com",
                    PhoneNumber = "864741327"
                }
            );
        }
    }
}
