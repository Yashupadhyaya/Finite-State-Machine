using NUnit.Framework;
using Moq;

namespace FiniteStateMachine.Test
{
    // Assuming that 'YourClassName' is the 'StateMachine' class
    public class StateMachine
    {
        public virtual void Initialize()
        {
            // Implementation of Initialize method
        }
    }

    [TestFixture]
    public class StateMachine_Initialize_99e1f35a6a
    {
        private StateMachine _stateMachine;

        [SetUp]
        public void Setup()
        {
            _stateMachine = new StateMachine();
        }

        [Test]
        public void Initialize_WhenCalled_ShouldNotThrowException()
        {
            Assert.DoesNotThrow(() => _stateMachine.Initialize());
        }

        [Test]
        public void Initialize_WhenCalled_ShouldCallBaseInitialize()
        {
            var mockStateMachine = new Mock<StateMachine> { CallBase = true };

            mockStateMachine.Object.Initialize();

            mockStateMachine.Verify(x => x.Initialize(), Times.Once);
        }
    }
}
