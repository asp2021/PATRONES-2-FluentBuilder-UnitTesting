using FluentBuilder2_UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1
{
    public class GreetingBuilder
    {
        private readonly Greet _greeting;

        private GreetingBuilder()
        {
            _greeting = new Greet();
        }

        public static GreetingBuilder CreateNew()
        {
            return new GreetingBuilder();
        }

        public GreetingBuilder TimeOfDay(string timeOfDay)
        {
            _greeting.TimeOfDay = timeOfDay;
            return this;
        }

        public GreetingBuilder To(string to)
        {
            _greeting.To = to;
            return this;
        }

        public Greet Build()
        {
            return _greeting;
        }
    }
}
