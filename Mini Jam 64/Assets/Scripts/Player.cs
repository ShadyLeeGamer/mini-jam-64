using UnityEngine;

public class Player : PlayerController
{
    public float moveSpeed;
    public float jumpForce;

    void Update()
    {
        transform.rotation = equippedSkateboard.transform.rotation;

        // MOVEMENT INPUT
        var moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0,
                                    Input.GetAxisRaw("Vertical"));
        var skateboardInput = Vector3.forward;

        var velocity = (onSkateboard ? skateboardInput :
                                       moveInput.normalized * moveSpeed);

        Move(velocity);

        /*if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            Jump(jumpForce);*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<KillZone>())
        {
            Destroy(gameObject);
        }
    }
}
