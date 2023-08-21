using NUnit.Framework;
using Moq;

namespace FiniteStateMachine.Test
{
    public class StateBase__End_3643a6cf0d
    {
        private Mock<FiniteStateMachine> _mockFiniteStateMachine;
        private FiniteStateEndedEventArgs _finiteStateEndedEventArgs;
        private Mock<StateBase> _mockStateBase;

        [SetUp]
        public void Setup()
        {
            _mockFiniteStateMachine = new Mock<FiniteStateMachine>();
            _finiteStateEndedEventArgs = new FiniteStateEndedEventArgs(); // Removed 'StateType.testStateKey' as it was causing an error
            _mockStateBase = new Mock<StateBase>();
        }

        [Test]
        public void _End_StateEndedEventIsInvoked()
        {
            // Arrange
            bool eventRaised = false;
            _mockStateBase.Object.StateEnded += (s, e) => eventRaised = true; // Changed 'OnStateEnded' to 'StateEnded'

            // Act
            _mockStateBase.Object._End();

            // Assert
            Assert.IsTrue(eventRaised);
        }

        [Test]
        public void _End_StateEndedEventIsNotInvoked()
        {
            // Arrange
            bool eventRaised = false;
            _mockStateBase.Object.StateEnded += (s, e) => eventRaised = true; // Changed 'OnStateEnded' to 'StateEnded'

            // Act
            _mockStateBase.Object._End();

            // Assert
            Assert.IsFalse(eventRaised);
        }
    }
}
