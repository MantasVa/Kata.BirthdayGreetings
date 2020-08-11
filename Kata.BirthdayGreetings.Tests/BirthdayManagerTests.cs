using Kata.BirthdayGreetings.Data.Repositories;
using Kata.BirthdayGreetings.Infrastructure;
using System.Threading.Tasks;
using Xunit;

namespace Kata.BirthdayGreetings.Tests
{
    public class BirthdayManagerTests
    {
        [Fact]
        public async Task BirthdayManagerAsync()
        {
            System.Diagnostics.Debugger.Launch();
            var repo = new PersonRepository();
            await repo.AddAsync(new Data.Models.Person
            {
                FirstName = "vardas",
                LastName = "kazkas",
                PhoneNumber = "f",
                Email = "Aidanas93@gmail.com",
                DateOfBirth = new System.DateTime(1995, 08, 11)
            });
            BirthdayManager bdayManager = new BirthdayManager(repo, new BirthdayPublisher());

            await bdayManager.CheckForBirthdaysAsync();
        }
    }
}
