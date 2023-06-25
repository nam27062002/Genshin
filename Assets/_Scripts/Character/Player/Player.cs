using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
public class Player : MonoBehaviour
{
    public PlayerInput Input { get; private set; }
    private PlayerMovementStateMachine movementStateMachine;

    private void Awake()
    {
        // Lấy tham chiếu tới PlayerInput
        Input = GetComponent<PlayerInput>();
        
        // Khởi tạo trạng thái máy trạng thái di chuyển của người chơi
        movementStateMachine = new PlayerMovementStateMachine();
    }

    private void Start()
    {
        // Đặt trạng thái ban đầu của người chơi là trạng thái đứng yên
        movementStateMachine.ChangeState(movementStateMachine.IdlingState);
    }

    private void Update()
    {
        // Xử lý đầu vào từ người chơi và cập nhật trạng thái
        movementStateMachine.HandleInput();
        movementStateMachine.Update();
    }

    private void FixedUpdate()
    {
        // Cập nhật vật lý cho trạng thái di chuyển của người chơi
        movementStateMachine.PhysicsUpdate();
    }
}