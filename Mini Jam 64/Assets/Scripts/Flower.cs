using UnityEngine;

public class Flower : MonoBehaviour
{
    public Sprite[] flowerSprite;
    Transform cam;

    void Awake()
    {
        cam = FindObjectOfType<GameCamera>().transform;
        GetComponent<SpriteRenderer>().sprite = flowerSprite[Random.Range(0, flowerSprite.Length)];
    }

    void Update()
    {
        transform.LookAt(cam);
    }
}
