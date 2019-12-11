using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 15.0f;
    private BoxCollider2D bc;
    private Rigidbody2D rb;
    public Vector2 position;
    void Start()
    {
        bc = this.GetComponent<BoxCollider2D>();
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        position = rb.transform.position;
    }

    void FixedUpdate()
    {
        position.y += bulletSpeed * Time.deltaTime;
        rb.position = position;

        if (position.y >= 50)
        {
            Destroy(gameObject);
        }
    }
}
