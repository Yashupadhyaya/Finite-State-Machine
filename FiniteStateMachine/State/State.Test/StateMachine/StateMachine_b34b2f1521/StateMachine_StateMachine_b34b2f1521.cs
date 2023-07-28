// Test generated by RoostGPT for test unt-test using AI Type Azure Open AI and AI Model roost-gpt

using System;
using NUnit.Framework;

namespace YourNamespace
{
    [TestFixture]
    public class StateMachineTests
    {
        [Test]
        public void TestStateMachine_StateMachine_b34b2f1521()
        {
            // Arrange
            var stateMachine = new StateMachine<int>();
            int state1 = 1;
            int state2 = 2;

            // Act
            stateMachine.AddState(state1);
            stateMachine.AddState(state2);

            // Assert
            Assert.AreEqual(2, stateMachine.StatesCount);
            Assert.IsTrue(stateMachine.HasState(state1));
            Assert.IsTrue(stateMachine.HasState(state2));
        }

        [Test]
        public void TestStateMachine_StateMachine_b34b2f1521WithDuplicateState()
        {
            // Arrange
            var stateMachine = new StateMachine<int>();
            int state1 = 1;

            // Act
            stateMachine.AddState(state1);
            stateMachine.AddState(state1);

            // Assert
            Assert.AreEqual(1, stateMachine.StatesCount);
        }
    }

    public class StateMachine<T>
    {
        private Dictionary<T, State<T>> m_states;

        public int StatesCount => m_states.Count;

        public StateMachine()
        {
            m_states = new Dictionary<T, State<T>>();
        }

        public void AddState(T state)
        {
            if (!m_states.ContainsKey(state))
            {
                m_states.Add(state, new State<T>());
            }
        }

        public bool HasState(T state)
        {
            return m_states.ContainsKey(state);
        }
    }

    public class State<T>
    {
        // Your implementation here
    }
}
