using Microsoft.VisualStudio.TestTools.UnitTesting;
using usine_s3;
using System;

namespace usine_s3_test
{
    [TestClass]
    public class GreeterTest
    {
        [TestMethod]
        public void TestGreet()
        {
            // Arrangement
            const string name = "bob";
            Greeter greeter = new Greeter();
            // Act
            string text = greeter.Greet(name);
            // Assert
            StringAssert.Contains(text, name);
            // Cleanup
            
            // ... free variables, close files
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullGreet()
        {
            Greeter greeter = new Greeter();
            greeter.Greet(null);
        }

        [TestMethod]
        public void TestUpperGreet()
        {
            const string name = "bob";
            const string mode = "upper";
            Greeter greeter = new Greeter();
            // Act
            string text = greeter.Greet(name, mode);
            // Assert
            StringAssert.Contains(text, name.ToUpper());
            // Cleanup

            // ... free variables, close files
        }
    }
}
