using UnityEngine;

public class Ball : MonoBehaviour
{
    public float moveSpeed;

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(0, 4, 0);
        rb.velocity = new Vector3(moveSpeed * -1, moveSpeed, 0);
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.name == "RightCol")
            rb.velocity = new Vector3(moveSpeed * (float)1.5, moveSpeed * 2, 0);
        else if (col.collider.name == "LeftCol")
            rb.velocity = new Vector3(moveSpeed * (float)-1.5, moveSpeed * 2, 0);

        if (col.collider.name == "RightWall")
            rb.velocity = new Vector3(moveSpeed * (float)-0.5, moveSpeed * (float)1.5, 0);
        else if (col.collider.name == "LeftWall")
            rb.velocity = new Vector3(moveSpeed * (float)0.5, moveSpeed * (float)1.5, 0);

        if (col.collider.tag == "Ground")
        {
            transform.position = new Vector3(0, 4, 0);
            rb.velocity = new Vector3(moveSpeed * -1, moveSpeed, 0);
        }
    }
}
