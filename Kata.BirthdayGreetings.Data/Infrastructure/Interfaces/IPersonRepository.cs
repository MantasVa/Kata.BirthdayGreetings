using Kata.BirthdayGreetings.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kata.BirthdayGreetings.Data.Infrastructure.Interfaces
{
    public interface IPersonRepository
    {
        Task AddAsync(Person person);
        Task<List<Person>> GetAllAsync();
        Task<Person> GetPersonById(int id);
        Task Remove(Person person);
    }
}