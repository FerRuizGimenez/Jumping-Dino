using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public float speed;

    public static float ExtraSpeed;

    void Start()
    {
        speed = 0.1f + ExtraSpeed;
    }

    void FixedUpdate()
    {
        this.transform.Translate(-speed,0,0);
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
