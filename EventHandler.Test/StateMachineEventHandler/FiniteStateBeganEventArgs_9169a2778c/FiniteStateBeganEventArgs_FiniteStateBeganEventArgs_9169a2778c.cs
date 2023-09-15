using NUnit.Framework;
using FiniteStateMachine;

namespace FiniteStateMachine.Test
{
    public enum TestStateType
    {
        ValidState,
        InvalidState
    }

    [TestFixture]
    public class FiniteStateBeganEventArgs_FiniteStateBeganEventArgs_9169a2778c
    {
        [Test]
        public void FiniteStateBeganEventArgs_ValidStateType_ExpectCorrectAssignment()
        {
            // Arrange
            var stateType = TestStateType.ValidState;

            // Act
            var eventArgs = new FiniteStateBeganEventArgs((StateType)(int)stateType);

            // Assert
            Assert.AreEqual((StateType)(int)stateType, eventArgs.Type);
        }

        [Test]
        public void FiniteStateBeganEventArgs_InvalidStateType_ExpectException()
        {
            // Arrange
            var stateType = TestStateType.InvalidState;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new FiniteStateBeganEventArgs((StateType)(int)stateType));
        }
    }
}
