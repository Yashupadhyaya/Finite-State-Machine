using NUnit.Framework;

namespace YourNamespace
{
    [TestFixture]
    public class YourTestClass
    {
        [Test]
        public void TestStateBase__Begin_Success()
        {
            // Arrange
            var eventArgs = new FiniteStateChangeEventArgs();
            StateType previousStateKey = StateType.State1;
            var stateBase = new StateBase();

            // Act
            stateBase._Begin(eventArgs, previousStateKey);

            // Assert
            // TODO: Add assertions to verify the expected behavior
        }

        [Test]
        public void TestStateBase__Begin_Failure()
        {
            // Arrange
            var eventArgs = new FiniteStateChangeEventArgs();
            StateType previousStateKey = StateType.Unknown;
            var stateBase = new StateBase();

            // Act
            stateBase._Begin(eventArgs, previousStateKey);

            // Assert
            // TODO: Add assertions to verify the expected behavior
        }
    }

    public enum StateType
    {
        State1,
        Unknown
    }

    public class FiniteStateChangeEventArgs { }

    public class FiniteStateBeganEventArgs
    {
        public StateType StateKey { get; }

        public FiniteStateBeganEventArgs(StateType stateKey)
        {
            StateKey = stateKey;
        }
    }

    public class FiniteStateMachine
    {
        public static FiniteStateMachine Instance { get; } = new FiniteStateMachine();

        public event Action<FiniteStateBeganEventArgs> OnStateBegan;
    }

    public class StateBase
    {
        public StateType StateKey { get; } = StateType.State1;

        public virtual void _Begin(FiniteStateChangeEventArgs eventArgs, StateType previousStateKey)
        {
            FiniteStateMachine.Instance.OnStateBegan += new Action<FiniteStateBeganEventArgs>((e) => { });
            FiniteStateMachine.Instance.OnStateBegan -= new Action<FiniteStateBeganEventArgs>((e) => { });
            FiniteStateMachine.Instance.OnStateBegan?.Invoke(new FiniteStateBeganEventArgs(StateKey));
            this.Begin(eventArgs, previousStateKey);
        }

        private void Begin(FiniteStateChangeEventArgs eventArgs, StateType previousStateKey)
        {
            // TODO: Implement the functionality
        }
    }
}
