using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] private float jumpForce = 5;

    [SerializeField] private InputManager inputManager;

    [Header("Ground Check")]
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Vector2 startPointOffset;
    [SerializeField] private float groundCheckDistance;

    private float _horizontalInput = 0f;
    private Rigidbody2D _playerRb;
    private bool _isOnGround;

    private int maxJumps = 2; // maximum jumps
    private int remainingJumps; // jumps left

    void Awake()
    {
        _playerRb = GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {
        inputManager.OnJump += HandleJumpInput;
        inputManager.OnMove += HandleMoveInput;
    }

    void OnDisable()
    {
        inputManager.OnJump -= HandleJumpInput;
        inputManager.OnMove -= HandleMoveInput;
    }

    void HandleJumpInput()
    {
        remainingJumps--; // remove a remaining jump after each jump
        
        // apply the jump force
        if (_playerRb == null) return;

        if (_isOnGround)
            remainingJumps = maxJumps; // reset jumps to max when ground hit

        if (remainingJumps > 0) // if more than 0 jumps left, apply jump force
        {
            _playerRb.AddForceY(jumpForce, ForceMode2D.Impulse);
        }
    }

    void HandleMoveInput(float value)
    {
        _horizontalInput = value;
    }

    void FixedUpdate()
    {
        HandleMovement();
        GroundCheck();
    }

    void HandleMovement()
    {
        if (_playerRb == null) return;

        float movementVelocity = moveSpeed * _horizontalInput;
        _playerRb.linearVelocityX = movementVelocity;
    }

    void GroundCheck()
    {
        _isOnGround = Physics2D.Raycast
        (
            (Vector2)transform.position + startPointOffset,
            Vector2.down,
            groundCheckDistance,
            groundLayer
        );
    }

   
    void OnDrawGizmos()
    {
        Debug.DrawLine
        (
            (Vector2)transform.position + startPointOffset,
            (Vector2)transform.position + startPointOffset + Vector2.down *  groundCheckDistance,
            _isOnGround ? Color.green : Color.red
        );
    }
}
