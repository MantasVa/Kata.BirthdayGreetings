using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Kata.BirthdayGreetings.Infrastructure
{
    public static class Message
    {
        public static string GetSubject()
        {
            return "Happy birthday!";
        }

        public static string GetBody(string firstName)
        {
            return $"Happy birthday, dear {firstName}!";
        }
    }
}
