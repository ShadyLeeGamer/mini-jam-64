using UnityEngine;

public class Skateboard : SkateboardController
{
    void Update()
    {
        Skateboarding(player.equippedSkateboard == this);

                if (skateboarding && player.onSkateboard)
            transform.Rotate(.0f, Input.GetAxis("Horizontal") * turnSpeed, .0f);
        else
        {
            Transform playerT = player.transform;
            Vector3 followPos = new Vector3(playerT.position.x, transform.position.y,
                                            playerT.position.z);
            transform.LookAt(followPos);
            transform.position = Vector3.MoveTowards(transform.position,
                                         player.equippedSkateboard.transform.position,
                                         followSpeed * Time.deltaTime);
        }
    }
}
