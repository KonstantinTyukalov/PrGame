using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOve : MonoBehaviour
{
    public float speed;
    public float jumpforce;
    //bool jump = false;
    float moveHorizontal = 0f;
    float moveVertical = 0f;
    private Rigidbody2D rb;
    /*float moveHorizontal = 0f;
    float moveVertical = 0f;*/

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

     void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        if (Input.GetKeyDown("space"))
        {
            //transform.Translate(Vector3.up * jumpforce * Time.deltaTime, Space.World);
            rb.AddForce(new Vector2(0, jumpforce));
        }
    }

    void FixedUpdate()
    {
       //  moveHorizontal = Input.GetAxis("Horizontal");
       //  moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

}
