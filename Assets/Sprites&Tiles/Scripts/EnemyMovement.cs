using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    Rigidbody2D myRigidbody2D;
    BoxCollider2D myFeetCollider2D;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        myFeetCollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(IsFacingRight()){
            myRigidbody2D.velocity = new Vector2(moveSpeed, 0);
        }
        else{
            myRigidbody2D.velocity = new Vector2(-moveSpeed, 0);
        }
   
    }

    private bool IsFacingRight()
    {
        return transform.localScale.x > 0;
    }

    void turnAround()
    {
        if (myFeetCollider2D.IsTouchingLayers(LayerMask.GetMask("Ground")))
        { moveSpeed = -10; }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.localScale = new Vector2(-Mathf.Sign(myRigidbody2D.velocity.x), 1f);
        Debug.Log("hit something");
    }
}
