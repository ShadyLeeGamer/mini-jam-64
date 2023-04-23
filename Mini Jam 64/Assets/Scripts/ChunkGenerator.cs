using UnityEngine;

public class ChunkGenerator : MonoBehaviour
{
    public GameObject chunk;
    public GameObject obstacle;
    public Transform generationPoint;
    public float chunkDistance = 30;
    public float obstacleDistance;
    public Vector2 obstacleOffset;

    float oldPos;
    float obsataclePos;

    void Start()
    {
        oldPos = generationPoint.position.z;
        obsataclePos = oldPos;
    }

    void Update()
    {
        if(transform.position.z < generationPoint.position.z)
        {
            oldPos += 30;
            generationPoint.position = Vector3.forward * oldPos;

            transform.position = new Vector3(transform.position.x, transform.position.y,
                                 transform.position.z + chunkDistance);
            Instantiate(chunk, generationPoint.position, Quaternion.identity);
        }

        if(generationPoint.position.z > obsataclePos)
        {
            obsataclePos += obstacleDistance;
            Instantiate(obstacle, new Vector3(Random.Range(-obstacleOffset.x, obstacleOffset.x),
                                                        obstacleOffset.y,
                                                        generationPoint.position.z),
                                                        Quaternion.Euler(90,0,
                                                                         Random.Range(0f, 360f)));
        }
    }
}
