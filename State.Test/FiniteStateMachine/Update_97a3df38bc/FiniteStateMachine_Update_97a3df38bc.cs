using NUnit.Framework;
using FiniteStateMachine;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class FiniteStateMachine_Update_97a3df38bc
    {
        private FiniteStateMachine fsm;

        [SetUp]
        public void SetUp()
        {
            fsm = new FiniteStateMachine();
        }

        [Test]
        public void Update_WithPositiveDeltaTime_UpdatesCorrectly()
        {
            // Arrange
            float deltaTime = 0.5f;

            // Act
            fsm.Update(deltaTime);

            //Assert
            // TODO: Add your assertions here
        }

        [Test]
        public void Update_WithNegativeDeltaTime_ThrowsException()
        {
            // Arrange
            float deltaTime = -0.5f;

            // Act & Assert
            Assert.Throws<System.ArgumentException>(() => fsm.Update(deltaTime));
        }

        [Test]
        public void Update_WithZeroDeltaTime_DoesNotChangeState()
        {
            // Arrange
            float deltaTime = 0.0f;

            // Act
            fsm.Update(deltaTime);

            //Assert
            // TODO: Add your assertions here
        }
    }
}
