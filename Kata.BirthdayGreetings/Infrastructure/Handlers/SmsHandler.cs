using Kata.BirthdayGreetings.Data.Models;
using Kata.BirthdayGreetings.Infrastructure;
using System;

namespace Kata.BirthdayGreetings.Infrastructure.Handlers
{
    public class SmsHandler : Observer
    {
        public override void Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
