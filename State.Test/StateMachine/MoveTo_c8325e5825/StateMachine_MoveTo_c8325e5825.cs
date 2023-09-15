using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace FiniteStateMachine.Test
{
    public class State
    {
        public string Name { get; set; }
        public event EventHandler Begin;
        public event EventHandler End;

        public State(string name)
        {
            Name = name;
        }

        public void OnBegin()
        {
            Begin?.Invoke(this, EventArgs.Empty);
        }

        public void OnEnd()
        {
            End?.Invoke(this, EventArgs.Empty);
        }
    }

    public class FiniteStateMachine
    {
        public string CurrentStateKey { get; private set; }
        private Dictionary<string, State> _states;

        public FiniteStateMachine(Dictionary<string, State> states, string initialState)
        {
            _states = states;
            CurrentStateKey = initialState;
        }

        public void MoveTo(string targetState)
        {
            if (!_states.ContainsKey(targetState))
            {
                throw new Exception($"Invalid state: {targetState}");
            }

            if (CurrentStateKey != targetState)
            {
                _states[CurrentStateKey].OnEnd();
                CurrentStateKey = targetState;
                _states[CurrentStateKey].OnBegin();
            }
        }
    }

    [TestFixture]
    public class StateMachine_MoveTo_c8325e5825
    {
        private FiniteStateMachine _stateMachine;
        private Dictionary<string, State> _states;

        [SetUp]
        public void Setup()
        {
            _states = new Dictionary<string, State>
            {
                { "State1", new State("State1") },
                { "State2", new State("State2") },
                { "State3", new State("State3") }
            };
            _stateMachine = new FiniteStateMachine(_states, "State1");
        }

        [Test]
        public void MoveTo_ValidTargetState_ChangesState()
        {
            _stateMachine.MoveTo("State2");
            Assert.AreEqual("State2", _stateMachine.CurrentStateKey);
        }

        [Test]
        public void MoveTo_InvalidTargetState_ThrowsException()
        {
            Assert.Throws<Exception>(() => _stateMachine.MoveTo("State4"));
        }

        [Test]
        public void MoveTo_ValidTargetState_FiresBeginEndEvents()
        {
            bool beginCalled = false;
            bool endCalled = false;
            _states["State1"].Begin += (s, e) => beginCalled = true;
            _states["State1"].End += (s, e) => endCalled = true;

            _stateMachine.MoveTo("State2");

            Assert.True(beginCalled);
            Assert.True(endCalled);
        }

        [Test]
        public void MoveTo_SameState_DoesNotFireBeginEndEvents()
        {
            bool beginCalled = false;
            bool endCalled = false;
            _states["State1"].Begin += (s, e) => beginCalled = true;
            _states["State1"].End += (s, e) => endCalled = true;

            _stateMachine.MoveTo("State1");

            Assert.False(beginCalled);
            Assert.False(endCalled);
        }
    }
}
