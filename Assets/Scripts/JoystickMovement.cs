using UnityEngine;

public class JoystickMovement : MonoBehaviour
{
    public Joystick joystick;
    public float moveSpeed;
    public float jumpForce;

    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.velocity = new Vector3(joystick.Horizontal * moveSpeed, rb.velocity.y, 0);
        transform.rotation = new Quaternion(0, 0, 0, 0);
    }
    public void Jump()
    {
        if (Mathf.Abs(rb.velocity.y) < 0.001f)
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.y);
    }
}
