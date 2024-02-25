using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody2D rd;
    public Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rd.AddForce(new Vector2(0,velocity.y));
        }
        if (Input.GetKey(KeyCode.S))
        {
        }
        if (Input.GetKey(KeyCode.D))
        {
            rd.AddForce(new Vector2(velocity.x, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rd.AddForce(new Vector2(-velocity.x, 0));
        }
    }
}
