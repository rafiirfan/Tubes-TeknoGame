using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{   
    public GameLogic GameLogic;
    public float jumpForce = 5f;
    private bool isGrounded = false;
    private Animator animator;
    private Rigidbody2D rb;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        animator.SetTrigger("run");
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
            GameLogic.isGameOver = true;
            Time.timeScale = 0;
        }
    }

    void Update()
    {
        // If game is running 
        if (!GameLogic.isGameOver && !GameLogic.isGamePaused){

            // Jump
            if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && isGrounded)
            {
                animator.SetTrigger("jump");
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                isGrounded = false;
            }
        }
        
    }
}
