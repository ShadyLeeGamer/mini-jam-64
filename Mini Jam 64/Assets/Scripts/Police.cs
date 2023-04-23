using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Police : MonoBehaviour
{
    public float chaseSpeed;
    void Update()
    {
        if(FindObjectOfType<Player>() != null)
            transform.position += Vector3.forward * chaseSpeed * Time.deltaTime;
    }
}
