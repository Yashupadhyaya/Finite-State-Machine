using NUnit.Framework;

namespace YourNamespace
{
    [TestFixture]
    public class StateTests
    {
        [Test]
        public void TestStateConstructor_ValidParameters_Success()
        {
            var stateMachine = new StateMachine<string>();
            string stateKey = "Active";

            var state = new State<string>(stateMachine, stateKey);

            Assert.IsNotNull(state);
            Assert.AreEqual(stateMachine, state.StateMachine);
            Assert.AreEqual(stateKey, state.StateKey);
        }

        [Test]
        public void TestStateConstructor_NullStateMachine_ThrowsArgumentNullException()
        {
            StateMachine<string> stateMachine = null;
            string stateKey = "Active";

            Assert.Throws<ArgumentNullException>(() => new State<string>(stateMachine, stateKey));
        }
    }
}
