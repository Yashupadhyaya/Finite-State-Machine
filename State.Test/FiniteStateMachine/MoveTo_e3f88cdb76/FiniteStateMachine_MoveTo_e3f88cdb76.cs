using NUnit.Framework;
using FiniteStateMachine;
using System;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class FiniteStateMachine_MoveTo_e3f88cdb76
    {
        private FiniteStateMachine _finiteStateMachine;

        [SetUp]
        public void Setup()
        {
            _finiteStateMachine = new FiniteStateMachine();
        }

        [Test]
        public void MoveTo_ValidTargetState_ChangesState()
        {
            StateType targetStateKey = new StateType(); 

            _finiteStateMachine.OnStateChange += (eventArgs) => { };

            StateType result = _finiteStateMachine.MoveTo(targetStateKey);

            Assert.AreEqual(targetStateKey, result);
        }

        [Test]
        public void MoveTo_InvalidTargetState_ThrowsException()
        {
            StateType targetStateKey = new StateType(); 

            _finiteStateMachine.OnStateChange += (eventArgs) => { };

            Assert.Throws<InvalidOperationException>(() => _finiteStateMachine.MoveTo(targetStateKey));
        }

        [Test]
        public void MoveTo_ValidTargetState_FiresOnStateChange()
        {
            StateType targetStateKey = new StateType(); 
            bool eventWasFired = false;

            _finiteStateMachine.OnStateChange += (eventArgs) => { eventWasFired = true; };

            _finiteStateMachine.MoveTo(targetStateKey);

            Assert.IsTrue(eventWasFired);
        }
    }
}
