using System;
using Xunit;
using Moq;
using CSharpDemoClassLib;

namespace CSharpDemoTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestMultiply()
        {
            //Arrange
            double left     = 3.0;
            double right    = 4.0;
            double expected = 12.0;
            double actual;
            DemoFunctions testSubject;

            //Act
            testSubject = new DemoFunctions();
            actual = testSubject.Multiply(left, right);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestReverse()
        {
            //Arrange
            string message = "Hello";
            string expected = "olleH";
            string actual;            
            DemoFunctions testSubject;

            //Act
            testSubject = new DemoFunctions();
            actual = testSubject.Reverse(message);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
