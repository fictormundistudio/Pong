using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] InputAction moveUp;
    [SerializeField] InputAction moveDown;
    Rigidbody2D rb;
    float moveSpeed = 250f;

    void OnEnable()
    {
        moveUp.Enable();
        moveDown.Enable();
    }
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (moveUp.IsPressed())
        {
            rb.AddRelativeForce(Vector2.up * moveSpeed * Time.fixedDeltaTime);
        }
        if (moveDown.IsPressed())
        {
            rb.AddRelativeForce(Vector2.down * moveSpeed * Time.fixedDeltaTime);
        } 
    }
}
