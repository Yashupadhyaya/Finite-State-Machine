using NUnit.Framework;
using FiniteStateMachine;
using System.Collections.Generic;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class StateMachine_StateMachine_878571cb02
    {
        private StateMachine<State<string>> stateMachine;

        [SetUp]
        public void Setup()
        {
            stateMachine = new StateMachine<State<string>>();
        }

        [Test]
        public void StateMachine_WhenCalled_ShouldInitializeStatesDictionary()
        {
            // Arrange
            var expected = new Dictionary<string, State<string>>();

            // Act
            var result = stateMachine.m_states;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<Dictionary<string, State<string>>>(result);
            Assert.AreEqual(expected.Count, result.Count);
        }

        [Test]
        public void StateMachine_WhenCalledMultipleTimes_ShouldInitializeNewStatesDictionaryEachTime()
        {
            // Arrange
            var stateMachine1 = new StateMachine<State<string>>();
            var stateMachine2 = new StateMachine<State<string>>();

            // Act
            var result1 = stateMachine1.m_states;
            var result2 = stateMachine2.m_states;

            // Assert
            Assert.IsNotNull(result1);
            Assert.IsNotNull(result2);
            Assert.AreNotSame(result1, result2);
        }
    }
}
