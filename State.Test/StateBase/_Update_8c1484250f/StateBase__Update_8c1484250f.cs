using NUnit.Framework;
using FiniteStateMachine;
using System;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class StateBase__Update_8c1484250f
    {
        private StateBase _stateBase;

        private class TestStateBase : StateBase
        {
            public override void Update(float dt)
            {
                // Implementation here...
            }

            public override void Load()
            {
                // Implementation here...
            }

            public override void End()
            {
                // Implementation here...
            }

            public override void Begin(FiniteStateChangeEventArgs args, StateType stateType)
            {
                // Implementation here...
            }
        }

        [SetUp]
        public void Setup()
        {
            _stateBase = new TestStateBase();
        }

        [Test]
        public void Update_CalledWithPositiveValue_UpdatesState()
        {
            // Arrange
            float dt = 1.0f;

            // Act
            _stateBase.Update(dt);

            // Assert
            // TODO: Add assertions relevant to your code here.
        }

        [Test]
        public void Update_CalledWithZero_DoesNotUpdateState()
        {
            // Arrange
            float dt = 0.0f;

            // Act
            _stateBase.Update(dt);

            // Assert
            // TODO: Add assertions relevant to your code here.
        }

        [Test]
        public void Update_CalledWithNegativeValue_ThrowsException()
        {
            // Arrange
            float dt = -1.0f;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _stateBase.Update(dt));
        }

        [TearDown]
        public void TearDown()
        {
            _stateBase = null;
        }
    }
}
