using System;
using NUnit.Framework;

[TestFixture]
public class FiniteStateMachineTests
{
    [Test]
    public void Test_End_Method()
    {
        var stateMachine = new FiniteStateMachine();
        var stateKey = "State1";
        var stateEnded = false;
        FiniteStateEndedEventArgs endedEventArgs = null;
        stateMachine.OnStateEnded += (args) =>
        {
            stateEnded = true;
            endedEventArgs = args;
        };
        
        stateMachine._End();
        
        Assert.IsTrue(stateEnded);
        Assert.AreEqual(stateKey, endedEventArgs.StateKey);
    }
    
    [Test]
    public void Test_End_Method_StateKey_Null()
    {
        var stateMachine = new FiniteStateMachine();
        var stateEnded = false;
        FiniteStateEndedEventArgs endedEventArgs = null;
        stateMachine.OnStateEnded += (args) =>
        {
            stateEnded = true;
            endedEventArgs = args;
        };
        
        stateMachine._End();
        
        Assert.IsTrue(stateEnded);
        Assert.IsNull(endedEventArgs.StateKey);
    }
}

public class FiniteStateMachine
{
    public event Action<FiniteStateEndedEventArgs> OnStateEnded;
    
    public virtual void _End()
    {
        this.End();
        OnStateEnded?.Invoke(new FiniteStateEndedEventArgs(StateKey));
    }
    
    private void End()
    {
    }
}

public class FiniteStateEndedEventArgs
{
    public string StateKey { get; }
    
    public FiniteStateEndedEventArgs(string stateKey)
    {
        StateKey = stateKey;
    }
}
