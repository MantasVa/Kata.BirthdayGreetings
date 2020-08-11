using Kata.BirthdayGreetings.Data.Models;
using Kata.BirthdayGreetings.Infrastructure.Handlers;

namespace Kata.BirthdayGreetings.Infrastructure.Interfaces
{
    public interface IBirthdayPublisher
    {
        void Attach(Observer observer);
        void Detach(Observer observer);
        void NotifyPerson(Person person);
    }
}