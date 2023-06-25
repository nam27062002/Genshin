using UnityEngine;

public class PlayerMovementState : IState
{
    public virtual void Enter()
    {
        // Ghi lại trạng thái hiện tại
        Debug.Log("State: " + GetType().Name);
    }

    public virtual void Exit()
    {
        // Xử lý khi rời khỏi trạng thái
    }

    public virtual void HandleInput()
    {
        // Xử lý các tương tác đầu vào
    }

    public virtual void PhysicsUpdate()
    {
        // Xử lý logic liên quan đến vật lý (sử dụng FixedUpdate)
    }

    public virtual void Update()
    {
        // Xử lý logic cập nhật (sử dụng Update)
    }
}