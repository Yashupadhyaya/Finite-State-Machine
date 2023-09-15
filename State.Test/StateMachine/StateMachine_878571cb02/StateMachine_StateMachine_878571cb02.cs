using NUnit.Framework;
using System.Collections.Generic;

namespace FiniteStateMachine.Test
{
    public abstract class State<T>
    {
        public T Value { get; set; }
    }

    public class ConcreteState<T> : State<T> { }

    public interface IStateMachine<T>
    {
        void AddState(State<T> state);
        List<State<T>> GetStates();
    }

    public class StateMachine<T> : IStateMachine<T>
    {
        private List<State<T>> _states = new List<State<T>>();

        public void AddState(State<T> state)
        {
            _states.Add(state);
        }

        public List<State<T>> GetStates()
        {
            return _states;
        }
    }

    [TestFixture]
    public class StateMachine_StateMachine_878571cb02
    {
        private IStateMachine<int> _stateMachine;

        [SetUp]
        public void Setup()
        {
            _stateMachine = new StateMachine<int>();
        }

        [Test]
        public void StateMachine_WhenInstantiated_ShouldHaveNoStates()
        {
            // Arrange
            // Act
            var states = _stateMachine.GetStates();

            // Assert
            Assert.IsEmpty(states);
        }

        [Test]
        public void StateMachine_WhenStateAdded_ShouldContainState()
        {
            // Arrange
            var state = new ConcreteState<int> { Value = 1 };

            // Act
            _stateMachine.AddState(state);
            var states = _stateMachine.GetStates();

            // Assert
            Assert.Contains(state, states);
        }
    }
}
