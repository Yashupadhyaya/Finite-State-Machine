using NUnit.Framework;
using System;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class FiniteStateMachine_Update_97a3df38bc
    {
        private FiniteStateMachine _finiteStateMachine;

        [SetUp]
        public void Setup()
        {
            _finiteStateMachine = new FiniteStateMachine();
        }

        [Test]
        public void Update_WithPositiveDeltaTime_UpdatesSuccessfully()
        {
            float deltaTime = 0.5f;

            Assert.DoesNotThrow(() => _finiteStateMachine.Update(deltaTime));
        }

        [Test]
        public void Update_WithNegativeDeltaTime_ThrowsException()
        {
            float deltaTime = -0.5f;

            Assert.Throws<ArgumentException>(() => _finiteStateMachine.Update(deltaTime));
        }

        [Test]
        public void Update_WithZeroDeltaTime_UpdatesSuccessfully()
        {
            float deltaTime = 0f;

            Assert.DoesNotThrow(() => _finiteStateMachine.Update(deltaTime));
        }

        [TearDown]
        public void Teardown()
        {
            _finiteStateMachine = null;
        }
    }
}
