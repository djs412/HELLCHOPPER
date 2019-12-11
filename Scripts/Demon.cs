using UnityEngine;

public class Demon : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float speed = 2.0f;
    private Vector2 position;
    private float turnRate = 2.0f;
    private float turnTimer;
    

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        turnTimer = turnRate;
        
    }

    // Update is called once per frame

    void Update()
    {
        position = rb.position;
    }
    
    void FixedUpdate()
    {
        

        if (turnTimer > 0)
        {
            MoveRight();
        }
        else
        {
            MoveLeft();
        }

        turnTimer -= Time.deltaTime;
        if (turnTimer <= turnRate * -1)
        {
            turnTimer = turnRate;
        }

        rb.position = position;
    }

    void MoveRight()
    {
        position.x += speed * Time.deltaTime;
    }

    void MoveLeft()
    {
        position.x -= speed * Time.deltaTime;
    }

}
