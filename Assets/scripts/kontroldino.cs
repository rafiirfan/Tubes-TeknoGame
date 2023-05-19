using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kontroldino : MonoBehaviour
{   
    public bool startGame = false;
    public float jumpForce = 5f;
    private bool isGrounded = false;
    public bool gameOver = false;
    Animator animator;
    Rigidbody2D rb;
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();   
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            isGrounded = true;
            animator.SetTrigger("run");
        } 
        if (collision.gameObject.tag == "obstacle")
        {
            gameOver = true;
            Time.timeScale = 0;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && gameOver)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            if (startGame == false) 
            startGame = true;
            animator.SetTrigger("jump");
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }
}
