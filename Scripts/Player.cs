using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    private Vector2 position;
    public float playerSpeed = 3.0f;
    public GameObject bullet;
    

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        position = rb.transform.position;
    }

    void FixedUpdate()
    {
        position.x += playerSpeed * Time.deltaTime * Input.GetAxisRaw("Horizontal");
        position.y += playerSpeed * Time.deltaTime * Input.GetAxisRaw("Vertical");
        
        rb.transform.position = position;

        if (Input.GetKeyDown("space"))
        {
            Instantiate(bullet, position, Quaternion.identity);
        }
    }
}
