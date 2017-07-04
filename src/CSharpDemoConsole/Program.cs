using System;
using CSharpDemoClassLib;

namespace CSharpDemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do some basic outputs with the an instance of 'DemoFunctions'
            string message = "Hello World!";
            DemoFunctions example = new DemoFunctions();

            Console.WriteLine(
                "\"{0}\" backwards is \"{1}\"",
                message,
                example.Reverse(message)
            );
            
        }
    }
}
