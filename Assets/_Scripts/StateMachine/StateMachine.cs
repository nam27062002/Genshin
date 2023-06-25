public abstract class StateMachine
{
    protected IState currentState;

    // Phương thức này chuyển đổi trạng thái hiện tại sang trạng thái mới
    public void ChangeState(IState newState)
    {
        currentState?.Exit();   // Gọi phương thức Exit() của trạng thái hiện tại (nếu có)
        currentState = newState;   // Gán trạng thái mới cho currentState
        currentState.Enter();   // Gọi phương thức Enter() của trạng thái mới
    }

    // Phương thức này xử lý các sự kiện đầu vào
    public void HandleInput()
    {
        currentState?.HandleInput();   // Gọi phương thức HandleInput() của trạng thái hiện tại (nếu có)
    }

    // Phương thức này được gọi trong mỗi khung cập nhật (update)
    public void Update()
    {
        currentState?.Update();   // Gọi phương thức Update() của trạng thái hiện tại (nếu có)
    }

    // Phương thức này được gọi trong mỗi khung cập nhật vật lý (FixedUpdate)
    public void PhysicsUpdate()
    {
        currentState?.PhysicsUpdate();   // Gọi phương thức PhysicsUpdate() của trạng thái hiện tại (nếu có)
    }
}
