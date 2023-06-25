public class PlayerMovementStateMachine : StateMachine
{
    public PlayerIdlingState IdlingState { get; }
    public PlayerWalkingState WalkingState { get; }
    public PlayerSprintingState SprintingState { get; }
    public PlayerRunningState RunningState { get; }

    public PlayerMovementStateMachine()
    {
        // Khởi tạo các trạng thái của máy trạng thái di chuyển của người chơi
        IdlingState = new PlayerIdlingState();
        WalkingState = new PlayerWalkingState();
        SprintingState = new PlayerSprintingState();
        RunningState = new PlayerRunningState();
    }
}