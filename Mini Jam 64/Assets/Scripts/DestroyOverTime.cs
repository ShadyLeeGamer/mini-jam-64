using System.Collections;
using UnityEngine;

public class DestroyOverTime : MonoBehaviour
{
    public float delay;
    Player player;

    void Awake()
    {
        player = FindObjectOfType<Player>();
    }
    void Update()
    {
        if (player.transform.position.z > transform.position.z && player != null)
            StartCoroutine(Destroyy());
    }

    IEnumerator Destroyy()
    {
        yield return new WaitForSeconds(delay);
        if (player != null)
            Destroy(gameObject);
    }
}
