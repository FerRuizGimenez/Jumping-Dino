using UnityEngine;

public class ObstaclesGenerator : MonoBehaviour
{
    public GameObject[] obstaclesPrefabs;

    public float randomTime;

    void Start()
    {
        Generate();    
    }

    void Generate()
    {
        Obstacles.ExtraSpeed += 0.05f;

        int randomObstacle = Random.Range(0, 2);
        Instantiate(obstaclesPrefabs[randomObstacle]);

        randomTime = Random.Range(1.5f, 3f);

        Invoke("Generate", randomTime);
    }
}
