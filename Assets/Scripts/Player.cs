using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D rigidBody;
    public float jumpForce;
    private bool isGround;
    GameControlller m_gc;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        m_gc = FindObjectOfType<GameControlller>();


    }

    // Update is called once per frame
    void Update()
    {
        bool isJumpKeyPressed = Input.GetKeyDown(KeyCode.Space);
        if (isJumpKeyPressed && isGround)
        {
            //Debug.Log("Da an phim space"); 
            rigidBody.AddForce(Vector2.up * jumpForce);
            isGround = false;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            m_gc.setGameoverState(true);
            //Time.timeScale = 0f; pausegame
        }
    }

}
