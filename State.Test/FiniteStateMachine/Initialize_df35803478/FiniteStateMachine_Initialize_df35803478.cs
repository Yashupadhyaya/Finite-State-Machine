using NUnit.Framework;
using Moq;

namespace FiniteStateMachine.Test
{
    public class FiniteStateMachine_Initialize_df35803478
    {
        private Mock<IFiniteStateMachine> _finiteStateMachine;

        [SetUp]
        public void Setup()
        {
            _finiteStateMachine = new Mock<IFiniteStateMachine>();
        }

        [Test]
        public void Initialize_WhenCalled_CallsBaseInitialize()
        {
            // Arrange
            _finiteStateMachine.Setup(f => f.Initialize());

            // Act
            _finiteStateMachine.Object.Initialize();

            // Assert
            _finiteStateMachine.Verify(f => f.Initialize(), Times.Once);
        }

        [Test]
        public void Initialize_WhenCalledMultipleTimes_CallsBaseInitializeMultipleTimes()
        {
            // Arrange
            _finiteStateMachine.Setup(f => f.Initialize());

            // Act
            _finiteStateMachine.Object.Initialize();
            _finiteStateMachine.Object.Initialize();

            // Assert
            _finiteStateMachine.Verify(f => f.Initialize(), Times.Exactly(2));
        }
    }

    public interface IFiniteStateMachine
    {
        void Initialize();
    }
}
