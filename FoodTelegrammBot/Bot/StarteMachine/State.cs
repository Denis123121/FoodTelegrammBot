namespace FoodTelegrammBot.Bot.StarteMachine;

public class State
{
    public enum StateVariant
    {
        WaitingStart,
        WaitingName,
        WaitingAge,
        WaitingCity
    }

    private StateVariant _currentState;

    public State(StateVariant state)
    {
        _currentState = state;
    }

    public string GetCurrentStateName()
    {
        return _currentState.ToString();
    }
    
    public void SetState(StateVariant state)
    {
        _currentState = state;
    }
}