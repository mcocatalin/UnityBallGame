using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    public Rigidbody ballRB;
    public float speed;


    void Update() // movement per frame
    {

    }

    void Start()
    {
        ballRB = new Rigidbody();
        ballRB = GetComponent<Rigidbody>();
        speed = 20f;
    }

    void FixedUpdate() // physics init
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 heading = new Vector3(moveHorizontal, 0.0f, moveVertical);

        ballRB.AddForce(heading * speed);
    }

}
