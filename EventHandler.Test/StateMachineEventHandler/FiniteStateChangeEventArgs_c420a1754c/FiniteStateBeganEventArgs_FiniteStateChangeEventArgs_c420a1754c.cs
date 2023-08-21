using NUnit.Framework;
using FiniteStateMachine;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class FiniteStateChangeEventArgsTest
    {
        [Test]
        public void FiniteStateChangeEventArgs_ValidStateType_ShouldSetRequestedType()
        {
            // Arrange
            var requestedState = StateType.ValidState; // Update 'ExampleState' to a valid state type

            // Act
            var args = new FiniteStateChangeEventArgs(requestedState);

            // Assert
            Assert.AreEqual(requestedState, args.RequestedType);
        }

        [Test]
        public void FiniteStateChangeEventArgs_NullStateType_ShouldThrowArgumentNullException()
        {
            // Arrange
            StateType? requestedState = null; // Update 'StateType' to a nullable type

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new FiniteStateChangeEventArgs(requestedState.Value));
        }
    }
}
