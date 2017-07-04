using System;
using System.Linq;

namespace CSharpDemoClassLib
{
    public class DemoFunctions
    {
        public double Multiply(double left, double right)
        {
            return left * right;
        }

        public string Reverse(string message)
        {
            return new string(message.Reverse().ToArray());
        }
    }
}
