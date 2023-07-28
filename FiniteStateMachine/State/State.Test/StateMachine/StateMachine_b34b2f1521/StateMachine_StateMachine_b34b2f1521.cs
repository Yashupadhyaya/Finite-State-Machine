using NUnit.Framework;
using System.Collections.Generic;

namespace MyNamespace.Tests
{
    [TestFixture]
    public class StateMachineTests
    {
        [Test]
        public void TestStateMachine_StateMachine_b34b2f1521()
        {
            StateMachine<int> stateMachine = new StateMachine<int>();

            Assert.IsEmpty(stateMachine.m_states);
        }

        [Test]
        public void TestStateMachine_StateMachine_d842e62874()
        {
            StateMachine<int> stateMachine = new StateMachine<int>();
            State<int> state1 = new State<int>(1);
            
            stateMachine.AddState(state1);
            
            Assert.IsTrue(stateMachine.m_states.ContainsKey(1));
            Assert.AreEqual(state1, stateMachine.m_states[1]);
        }
    }
}
