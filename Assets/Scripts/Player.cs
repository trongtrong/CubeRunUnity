using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D rigidBody;
    public float jumpForce;
    private bool isGround;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        
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
            //test github
            isGround = true;
        }
    }


}
