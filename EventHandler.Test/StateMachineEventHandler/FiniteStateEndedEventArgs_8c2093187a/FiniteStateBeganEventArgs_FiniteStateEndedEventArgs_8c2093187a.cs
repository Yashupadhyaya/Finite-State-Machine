using NUnit.Framework;
using FiniteStateMachine;
using System;

namespace FiniteStateMachine.Test
{
    public enum StateType
    {
        ValidState,
        InvalidState
    }

    public class FiniteStateEndedEventArgs : EventArgs
    {
        public StateType Type { get; }

        public FiniteStateEndedEventArgs(StateType type)
        {
            if (type == StateType.InvalidState)
            {
                throw new ArgumentException("Invalid state", nameof(type));
            }

            Type = type;
        }
    }

    [TestFixture]
    public class FiniteStateEndedEventArgs_Test
    {
        [Test]
        public void FiniteStateEndedEventArgs_WithValidState_SetsTypeCorrectly()
        {
            // Arrange
            var expectedState = StateType.ValidState;

            // Act
            var eventArgs = new FiniteStateEndedEventArgs(expectedState);

            // Assert
            Assert.AreEqual(expectedState, eventArgs.Type);
        }

        [Test]
        public void FiniteStateEndedEventArgs_WithInvalidState_ThrowsArgumentException()
        {
            // Arrange
            var invalidState = StateType.InvalidState;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new FiniteStateEndedEventArgs(invalidState));
        }
    }
}
