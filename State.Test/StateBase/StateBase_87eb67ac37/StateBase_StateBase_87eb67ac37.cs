using NUnit.Framework;
using FiniteStateMachine;
using System;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class StateBase_StateBase_87eb67ac37
    {
        private FiniteStateMachine _fsm;
        private StateType _stateKey;
        private StateBase _stateBase;

        [SetUp]
        public void Setup()
        {
            _fsm = new FiniteStateMachine();
            _stateKey = new StateType();
            _stateBase = new DerivedState(_fsm, _stateKey); 
        }

        [Test]
        public void Constructor_WithValidParameters_ShouldNotThrowException()
        {
            Assert.DoesNotThrow(() => new DerivedState(_fsm, _stateKey)); 
        }

        [Test]
        public void Constructor_WithNullFiniteStateMachine_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new DerivedState(null, _stateKey)); 
        }

        [Test]
        public void Constructor_WithNullStateKey_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new DerivedState(_fsm, null)); 
        }
    }

    public class DerivedState : StateBase
    {
        public DerivedState(FiniteStateMachine fsm, StateType stateKey) : base(fsm, stateKey)
        {
        }

        public override void Load()
        {
            // Implementation for Load
        }

        public override void Update(float deltaTime)
        {
            // Implementation for Update
        }

        public override void End()
        {
            // Implementation for End
        }

        public override void Begin(FiniteStateChangeEventArgs args, StateType stateType)
        {
            // Implementation for Begin
        }
    }
}
