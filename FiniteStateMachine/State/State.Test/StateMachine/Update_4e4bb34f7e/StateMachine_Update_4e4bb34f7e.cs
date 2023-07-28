// Test generated by RoostGPT for test unt-test using AI Type Azure Open AI and AI Model roost-gpt

using NUnit.Framework;

namespace YourNamespace.Tests
{
    [TestFixture]
    public class StateMachineTests
    {
        [Test]
        public void TestStateMachine_Update_ShouldCallStateUpdate()
        {
            // Arrange
            var stateMachine = new StateMachine();
            var state = new State();
            stateMachine.SetState(state);

            // Act
            stateMachine.Update(0.1f);

            // Assert
            Assert.IsTrue(state.UpdateCalled);
        }

        [Test]
        public void TestStateMachine_Update_WithNoState_ShouldNotCallStateUpdate()
        {
            // Arrange
            var stateMachine = new StateMachine();

            // Act
            stateMachine.Update(0.1f);

            // Assert
            // TODO: Assert that state.UpdateCalled is false or stateMachine.CurrentState is null
        }
    }

    public class StateMachine
    {
        private State m_currentState;

        public void SetState(State state)
        {
            m_currentState = state;
        }

        public void Update(float deltaTime)
        {
            if (m_currentState != null)
            {
                m_currentState._Update(deltaTime);
            }
        }
    }

    public class State
    {
        public bool UpdateCalled { get; private set; }

        public void _Update(float deltaTime)
        {
            UpdateCalled = true;
            // TODO: Add any additional logic you want to test here
        }
    }
}
