using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public bool isGrounded;
    public bool onSkateboard;
    public Skateboard equippedSkateboard;

    Rigidbody rb;
    public Rigidbody skateboardRb;

    Vector3 velocity;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (onSkateboard)
        {
            if(Input.GetAxis("Vertical") > 0)
                equippedSkateboard.acceleration = Input.GetAxis("Vertical") * 2;
            rb.position = new Vector3(skateboardRb.position.x, rb.position.y,
                                      skateboardRb.position.z);
        }
        else
        {
            equippedSkateboard.acceleration = 0;
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        }
    }

    public void Move(Vector3 _velocity)
    {
        velocity = _velocity;
    }

    public void Jump(float jumpForce)
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    public void OnSkateboard(Skateboard skateboard)
    {
        equippedSkateboard = skateboard;
        skateboardRb = equippedSkateboard.rb;
        onSkateboard = true;
    }

    public void OffSkateboard()
    {
        onSkateboard = false;
    }
}
