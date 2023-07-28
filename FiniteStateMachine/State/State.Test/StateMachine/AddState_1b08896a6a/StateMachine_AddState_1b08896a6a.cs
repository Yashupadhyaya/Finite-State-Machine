using NUnit.Framework;

namespace YourNamespace // TODO: Replace with your namespace name
{
    [TestFixture]
    public class YourClassName // TODO: Replace with your class name
    {
        [Test]
        public void Test_AddState_Success()
        {
            // Arrange
            var stateMachine = new FiniteStateMachine<T>(); // TODO: Replace with your state machine instance creation
            var state = new State<T>(); // TODO: Replace with your state instance creation
            
            // Act
            stateMachine.AddState(state);
            
            // Assert
            Assert.AreEqual(state, stateMachine.GetState(state.StateKey)); // TODO: Replace with your own assertion
        }

        [Test]
        public void Test_AddState_ThrowsException()
        {
            // Arrange
            var stateMachine = new FiniteStateMachine<T>(); // TODO: Replace with your state machine instance creation
            var state = new State<T>(); // TODO: Replace with your state instance creation
            
            // Act and Assert
            Assert.Throws<Exception>(() => stateMachine.AddState(state)); // TODO: Replace with your own assertion
        }
    }
}
