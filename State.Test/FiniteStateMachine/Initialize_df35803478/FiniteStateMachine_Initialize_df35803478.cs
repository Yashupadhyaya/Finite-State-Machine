using NUnit.Framework;
using FiniteStateMachine;
using System;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class FiniteStateMachine_Initialize_df35803478
    {
        private FiniteStateMachine fsm;

        [SetUp]
        public void Setup()
        {
            fsm = new FiniteStateMachine();
        }

        [Test]
        public void Initialize_StateMachineInitialized_Successful()
        {
            Assert.DoesNotThrow(() => fsm.Initialize());
        }

        [Test]
        public void Initialize_StateMachineInitializedTwice_ThrowsException()
        {
            fsm.Initialize();

            Assert.Throws<InvalidOperationException>(() => fsm.Initialize());
        }

        [TearDown]
        public void Teardown()
        {
            fsm = null;
        }
    }
}
