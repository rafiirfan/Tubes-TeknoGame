using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclejalan : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "destroy")
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-15, rb.velocity.y );
    }
}
