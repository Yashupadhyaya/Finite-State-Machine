using NUnit.Framework;

namespace YourNamespace
{
    [TestFixture]
    public class StateMachineTests
    {
        [Test]
        public void Test_Update_CurrentStateNotNull_CallsCurrentStateUpdate()
        {
            StateMachine stateMachine = new StateMachine();
            MockState currentState = new MockState();
            stateMachine.SetCurrentState(currentState);

            float deltaTime = 0.5f;

            stateMachine.Update(deltaTime);

            Assert.IsTrue(currentState.UpdateCalled);
            Assert.AreEqual(deltaTime, currentState.UpdateDeltaTime);
        }

        [Test]
        public void Test_Update_CurrentStateNull_DoesNotCallUpdate()
        {
            StateMachine stateMachine = new StateMachine();
            float deltaTime = 0.5f;

            stateMachine.Update(deltaTime);

            Assert.Pass();
        }
    }

    public class MockState : State
    {
        public bool UpdateCalled { get; private set; }
        public float UpdateDeltaTime { get; private set; }

        public override void _Update(float deltaTime)
        {
            UpdateCalled = true;
            UpdateDeltaTime = deltaTime;
        }
    }
}
