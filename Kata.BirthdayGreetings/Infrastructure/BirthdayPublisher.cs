using Kata.BirthdayGreetings.Data.Models;
using Kata.BirthdayGreetings.Infrastructure.Handlers;
using Kata.BirthdayGreetings.Infrastructure.Interfaces;
using System.Collections.Generic;

namespace Kata.BirthdayGreetings.Infrastructure
{
    public class BirthdayPublisher : IBirthdayPublisher
    {
        private List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyPerson(Person person)
        {
            foreach (Observer o in _observers)
            {
                o.Update(person);
            }
        }
    }
}
