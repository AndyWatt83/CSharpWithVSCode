using System;
using System.Linq;

namespace CSharpWithVSCode.ClassLib
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
