using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class RubyPlatform : IPlatform
    {
        public RubyPlatform()
        {
            Console.WriteLine("Ruby Platform object created");
        }

        public void Execute(Code code)
        {
            Console.WriteLine($"Compiling and executing {code} code.");
        }
    }
}
