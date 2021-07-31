using UnityEngine;

public class P1BotMovement : MonoBehaviour
{
    public Joystick joystick;
    public float moveSpeed;
    public float jumpForce;

    public GameObject Ball;
    public Menu MenuScript;

    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MenuScript = FindObjectOfType<Menu>();
        if (MenuScript.TwoPGame)
        {
            rb.velocity = new Vector3(joystick.Horizontal * moveSpeed, rb.velocity.y, 0);
        }
        else
        {
            moveSpeed = (float)5.5;
            if (Ball.transform.position.x <= transform.position.x && Ball.transform.position.x >= transform.position.x - 1)
                Jump();
            else if (Ball.transform.position.x < transform.position.x)
                rb.velocity = new Vector3(-1 * moveSpeed, rb.velocity.y, 0);
            else if (Ball.transform.position.x > transform.position.x)
                rb.velocity = new Vector3(1 * moveSpeed, rb.velocity.y, 0);
        }
        transform.rotation = new Quaternion(0, 0, 0, 0);
    }
    public void Jump()
    {
        if (Mathf.Abs(rb.velocity.y) < 0.001f)
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.y);
    }
}
