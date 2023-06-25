// Giao diện IState đại diện cho một trạng thái trong game
public interface IState
{
    // Phương thức được gọi khi vào trạng thái
    void Enter();

    // Phương thức được gọi khi ra khỏi trạng thái
    void Exit();

    // Phương thức xử lý các sự kiện đầu vào
    void HandleInput();

    // Phương thức được gọi trong mỗi khung cập nhật (update)
    void Update();

    // Phương thức được gọi trong mỗi khung cập nhật vật lý (FixedUpdate)
    void PhysicsUpdate();
}