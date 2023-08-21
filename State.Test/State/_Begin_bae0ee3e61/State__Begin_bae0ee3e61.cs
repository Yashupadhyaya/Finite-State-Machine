using NUnit.Framework;
using FiniteStateMachine;
using System;
using Moq;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class State__Begin_bae0ee3e61
    {
        private Mock<FiniteStateChangeEventArgs> _mockEventArgs;
        private PreviousStateKey _mockPreviousStateKey;
        private State<MyType> _state;

        [SetUp]
        public void Setup()
        {
            _mockEventArgs = new Mock<FiniteStateChangeEventArgs>();
            _mockPreviousStateKey = new PreviousStateKey();
            _state = new State<MyType>();
        }

        [Test]
        public void _Begin_WithValidArgs_ShouldCallBegin()
        {
            var isBeginCalled = false;
            _state.Begin += (s, e) => isBeginCalled = true;

            _state._Begin(_mockEventArgs.Object, _mockPreviousStateKey);

            Assert.IsTrue(isBeginCalled);
        }

        [Test]
        public void _Begin_WithNullEventArgs_ShouldThrowException()
        {
            Assert.Throws<ArgumentNullException>(() => _state._Begin(null, _mockPreviousStateKey));
        }

        [Test]
        public void _Begin_WithNullPreviousStateKey_ShouldThrowException()
        {
            Assert.Throws<ArgumentNullException>(() => _state._Begin(_mockEventArgs.Object, null));
        }

        [TearDown]
        public void TearDown()
        {
            _state = null;
        }
    }
}
