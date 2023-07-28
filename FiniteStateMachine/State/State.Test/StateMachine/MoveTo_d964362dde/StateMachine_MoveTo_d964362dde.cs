using NUnit.Framework;
using System;
using System.Collections.Generic;

[TestFixture]
public class FiniteStateMachineTests
{
    [Test]
    public void TestMoveTo_Success()
    {
        // Arrange
        FiniteStateMachine<StateKey> fsm = new FiniteStateMachine<StateKey>();
        StateKey state1 = new StateKey("State1");
        StateKey state2 = new StateKey("State2");
        fsm.AddState(state1);
        fsm.AddState(state2);

        // Act
        StateKey result = fsm.MoveTo(state2);

        // Assert
        Assert.AreEqual(state2, result);
    }

    [Test]
    public void TestMoveTo_StateDoesNotExist()
    {
        // Arrange
        FiniteStateMachine<StateKey> fsm = new FiniteStateMachine<StateKey>();
        StateKey state1 = new StateKey("State1");

        // Act & Assert
        Assert.Throws<Exception>(() => fsm.MoveTo(state1));
    }

    private class FiniteStateMachine<T>
    {
        private Dictionary<T, State<T>> m_states = new Dictionary<T, State<T>>();
        private State<T> m_currentState;

        public void AddState(State<T> state)
        {
            m_states.Add(state.StateKey, state);
        }

        public T MoveTo(T targetStateKey, FiniteStateChangeEventArgs eventArgs = null)
        {
            if (!this.m_states.ContainsKey(targetStateKey))
            {
                throw new Exception("[FiniteStateMachine::MoveTo()] -> Target state did not exist. Please add the State<T> for key: '" + targetStateKey);
            }
            T previousStateKey = targetStateKey;
            if (this.m_currentState != null)
            {
                previousStateKey = this.m_currentState.StateKey;
                this.m_currentState._End();
            }
            this.m_currentState = this.m_states[targetStateKey];
            this.m_currentState._Begin(eventArgs, previousStateKey);
            return this.m_currentState.StateKey;
        }
    }

    private class State<T>
    {
        public T StateKey { get; }

        public State(T stateKey)
        {
            StateKey = stateKey;
        }

        public void _Begin(FiniteStateChangeEventArgs eventArgs, T previousStateKey)
        {
            // Begin state logic here
        }

        public void _End()
        {
            // End state logic here
        }
    }

    private class StateKey
    {
        public string Key { get; }

        public StateKey(string key)
        {
            Key = key;
        }
    }

    private class FiniteStateChangeEventArgs
    {
        // Event arguments here
    }
}
