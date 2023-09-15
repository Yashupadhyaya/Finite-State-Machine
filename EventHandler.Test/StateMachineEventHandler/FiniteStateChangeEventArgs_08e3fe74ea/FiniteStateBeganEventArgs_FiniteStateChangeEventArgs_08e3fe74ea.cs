using NUnit.Framework;
using FiniteStateMachine;
using System;

namespace FiniteStateMachine.Test
{
    public class ConcreteStateInfo : StateInfo
    {
        // Implementation of the abstract class or interface 'StateInfo'
    }

    [TestFixture]
    public class FiniteStateBeganEventArgs_FiniteStateChangeEventArgs_08e3fe74ea
    {
        [Test]
        public void FiniteStateChangeEventArgs_ValidStateTypeAndStateInfo_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var requestedState = new StateType(); // Assuming StateType is a valid non-abstract class or struct
            var stateInfo = new ConcreteStateInfo();

            // Act
            var args = new FiniteStateChangeEventArgs(requestedState, stateInfo);

            // Assert
            Assert.AreEqual(requestedState, args.RequestedType);
            Assert.AreEqual(stateInfo, args.StateInfo);
        }

        [Test]
        public void FiniteStateChangeEventArgs_NullStateInfo_ShouldThrowArgumentNullException()
        {
            // Arrange
            var requestedState = new StateType();
            ConcreteStateInfo stateInfo = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new FiniteStateChangeEventArgs(requestedState, stateInfo));
        }
    }
}
