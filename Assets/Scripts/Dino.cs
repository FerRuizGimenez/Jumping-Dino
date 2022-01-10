using UnityEngine;

public class Dino : MonoBehaviour
{
    public GameObject gameOver;
    Rigidbody2D rb;
    Animator anim;
    public float jumpForce = 5.0f;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;

            this.enabled = false;
            anim.SetBool("isJumping", true);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        this.enabled = true;
        anim.SetBool("isJumping", false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
        gameOver.SetActive(true);

        Time.timeScale = 0;
    }
}
