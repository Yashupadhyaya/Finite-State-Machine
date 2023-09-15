using NUnit.Framework;
using FiniteStateMachine;
using System;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class StateMachine_AddState_95a50d88c6
    {
        private MyStateMachine machine;
        private MyState state;

        [SetUp]
        public void Setup()
        {
            machine = new MyStateMachine();
            state = new MyState(machine, 1);
        }

        [Test]
        public void AddState_ShouldAddState_WhenStateIsValid()
        {
            machine.AddState(state);
            Assert.IsTrue(machine.ContainsState(state.StateKey));
        }

        [Test]
        public void AddState_ShouldThrowException_WhenStateIsNotValid()
        {
            var invalidState = new MyState(new MyStateMachine(), 2);
            Assert.Throws<Exception>(() => machine.AddState(invalidState));
        }
    }

    public class MyStateMachine : StateMachine<int>
    {
        public override void AddState(State<int> state)
        {
            // Implementation here
        }

        public bool ContainsState(int stateKey)
        {
            // Implementation here
            return false;
        }
    }

    public class MyState : State<int>
    {
        public MyState(StateMachine<int> machine, int key) : base(machine, key)
        {
            // Implementation here
        }

        public override void Begin(FiniteStateChangeEventArgs args, int nextState)
        {
            // Implementation here
        }

        public override void Update(float deltaTime)
        {
            // Implementation here
        }

        public override void Load()
        {
            // Implementation here
        }

        public override void End()
        {
            // Implementation here
        }
    }
}
