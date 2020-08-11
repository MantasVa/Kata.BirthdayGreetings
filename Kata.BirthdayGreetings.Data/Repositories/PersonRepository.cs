using Kata.BirthdayGreetings.Data.Infrastructure.Interfaces;
using Kata.BirthdayGreetings.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kata.BirthdayGreetings.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly SQLiteDbContext _context;
        public PersonRepository()
        {
            _context = new SQLiteDbContext();
        }
        public async Task<List<Person>> GetAllAsync() => await _context.Person.ToListAsync();
        public async Task<Person> GetPersonById(int id) => await _context.Person.Where(p => p.Id == id).FirstOrDefaultAsync();
        public async Task AddAsync(Person person)
        {
            _context.Person.Add(person);
            await _context.SaveChangesAsync();
        }
        public async Task Remove(Person person)
        {
            var dbEntry = await GetPersonById(person.Id);
            _context.Person.Remove(dbEntry);
        }
    }
}
