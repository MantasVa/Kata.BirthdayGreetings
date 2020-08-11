using Kata.BirthdayGreetings.Data.Models;

namespace Kata.BirthdayGreetings.Infrastructure.Handlers
{
    public abstract class Observer
    {
        public abstract void Update(Person person);
    }
}
