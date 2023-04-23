using UnityEngine;

public class GameCamera : MonoBehaviour
{
    public Transform player;

    public float smoothSpeed;
    public Vector3 offset;

    void FixedUpdate()
    {
        if (player != null)
        {
            Vector3 desiredPos = player.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPos, smoothSpeed
                                                                                  * Time.deltaTime);
            transform.position = smoothedPosition;

            //transform.LookAt(player);
        }
    }
}
