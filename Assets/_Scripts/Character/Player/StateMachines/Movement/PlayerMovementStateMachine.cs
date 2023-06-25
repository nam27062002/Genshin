public class PlayerMovementStateMachine : StateMachine
{
    public PlayerIdlingState IdlingState { get; }
    public PlayerWalkingState WalkingState { get; }
    public PlayerSprintingState SprintingState { get; }
    public PlayerRunningState RunningState { get; }
    public PlayerMovementStateMachine()
    {
        IdlingState = new PlayerIdlingState();
        WalkingState = new PlayerWalkingState();
        SprintingState = new PlayerSprintingState();
        RunningState = new PlayerRunningState();
    }
}
