using NUnit.Framework;
using FiniteStateMachine;
using System;
using System.Collections.Generic;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class StateMachine_MoveTo_c8325e5825
    {
        private StateMachine<int> _stateMachine;
        private Dictionary<int, State<int>> _states;

        [SetUp]
        public void Setup()
        {
            _states = new Dictionary<int, State<int>>
            {
                {1, new State<int>(1)},
                {2, new State<int>(2)},
                {3, new State<int>(3)}
            };
            _stateMachine = new StateMachine<int>(_states);
        }

        [Test]
        public void MoveTo_WhenTargetStateExists_ShouldReturnTargetStateKey()
        {
            int targetStateKey = 2;

            State<int> result = _stateMachine.MoveTo(_states[targetStateKey]);

            Assert.AreEqual(targetStateKey, result.StateID);
        }

        [Test]
        public void MoveTo_WhenTargetStateDoesNotExist_ShouldThrowException()
        {
            int targetStateKey = 4;

            var ex = Assert.Throws<Exception>(() => _stateMachine.MoveTo(new State<int>(targetStateKey)));

            StringAssert.Contains(targetStateKey.ToString(), ex.Message);
        }

        [Test]
        public void MoveTo_WhenCurrentStateExists_ShouldEndCurrentState()
        {
            int targetStateKey = 2;
            int currentStateKey = 1;

            _stateMachine.MoveTo(_states[currentStateKey]);
            _stateMachine.MoveTo(_states[targetStateKey]);

            Assert.IsFalse(_states[currentStateKey].IsActive);
        }

        [Test]
        public void MoveTo_WhenCurrentStateExists_ShouldBeginTargetState()
        {
            int targetStateKey = 2;

            _stateMachine.MoveTo(_states[targetStateKey]);

            Assert.IsTrue(_states[targetStateKey].IsActive);
        }
    }
}
