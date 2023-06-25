using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public PlayerInputActions InputActions { get; private set; }
    public PlayerInputActions.PlayerActions PlayerActions { get; private set; }

    private void Awake()
    {
        // Khởi tạo đối tượng PlayerInputActions để quản lý các hành động người chơi
        InputActions = new PlayerInputActions();
        // Lấy ra hành động người chơi từ PlayerInputActions để sử dụng
        PlayerActions = InputActions.Player;
    }

    private void OnEnable()
    {
        // Bật kích hoạt các hành động người chơi
        InputActions.Enable();
    }

    private void OnDisable()
    {
        // Tắt kích hoạt các hành động người chơi
        InputActions.Disable();
    }
}