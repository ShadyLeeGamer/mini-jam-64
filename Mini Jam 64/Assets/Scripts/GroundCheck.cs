using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    Player player;

    void Awake()
    {
        player = transform.parent.GetComponent<Player>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Skateboard>())
        {
            player.isGrounded = true;
            player.OnSkateboard(other.gameObject.GetComponent<Skateboard>());
        }
        if (other.CompareTag("Ground"))
        {
            player.isGrounded = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Skateboard>())
        {
            player.isGrounded = false;
            player.OffSkateboard();
        }
        if (other.CompareTag("Ground"))
            player.isGrounded = false;

    }
}
