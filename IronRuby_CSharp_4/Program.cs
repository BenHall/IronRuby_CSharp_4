using System;
using Microsoft.Scripting.Hosting;

namespace IronRuby_CSharp_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing from C#");
            ScriptRuntime runtime = IronRuby.Ruby.CreateRuntime();
            ScriptScope scope = runtime.ExecuteFile("person.rb");
            dynamic person = scope.Engine.Execute("Person.new");
            person.say_hello();

            Console.ReadLine();
        }
    }
}
