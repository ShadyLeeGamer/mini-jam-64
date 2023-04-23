using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SkateboardController : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;
    public float followSpeed;
    public float acceleration;

    public Rigidbody rb;

    public Player player;
    public bool skateboarding;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();

        player = FindObjectOfType<Player>();
    }

    void FixedUpdate()
    {
        if (skateboarding)
            rb.MovePosition(rb.position + transform.forward * (moveSpeed + (acceleration * 2))
                                                            * Time.fixedDeltaTime);
    }

    public void Skateboarding(bool _skateboarding)
    {
        skateboarding = _skateboarding;
    }
}
