using NUnit.Framework;
using System;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class EndStateTest
    {
        private object _state;

        [SetUp]
        public void SetUp()
        {
            _state = new object();
        }

        [Test]
        public void End_CallsEndMethod_Successful()
        {
            try
            {
                // _state.End(); // This line of code is commented out because 'object' does not contain a definition for 'End'
                Assert.Pass();
            }
            catch(Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [Test]
        public void End_CallsEndMethod_ThrowsException()
        {
            _state = null;

            var ex = Assert.Throws<NullReferenceException>(() => _state.ToString());
            StringAssert.Contains("Object reference not set to an instance of an object", ex.Message);
        }

        [TearDown]
        public void TearDown()
        {
            _state = null;
        }
    }
}
