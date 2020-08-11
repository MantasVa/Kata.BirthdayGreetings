using Kata.BirthdayGreetings.Data.Infrastructure.Interfaces;
using Kata.BirthdayGreetings.Infrastructure.Handlers;
using Kata.BirthdayGreetings.Infrastructure.Interfaces;
using System;
using System.Threading.Tasks;

namespace Kata.BirthdayGreetings
{
    public class BirthdayManager
    {
        private readonly IPersonRepository _personRepository;
        private readonly IBirthdayPublisher _birthdayPublisher;

        public BirthdayManager(IPersonRepository personRepository, IBirthdayPublisher birthdayPublisher)
        {
            _personRepository = personRepository;
            _birthdayPublisher = birthdayPublisher;
            AddSenders();
        }

        public async Task CheckForBirthdaysAsync()
        {
            var people = await _personRepository.GetAllAsync();

            people.ForEach(person =>
            {
                DateTime birthdayThisYear = person.DateOfBirth.AddYears(DateTime.Now.Year - person.DateOfBirth.Year);

                if (birthdayThisYear == DateTime.Now.Date)
                    _birthdayPublisher.NotifyPerson(person);
            });
        }

        protected virtual void AddSenders()
        {
            _birthdayPublisher.Attach(new EmailHandler());
            //_birthdayPublisher.Attach(new SmsHandler());
        }
    }
}
