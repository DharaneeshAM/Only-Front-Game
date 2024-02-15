using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMoment : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1200f;
    private float horizontalInput;
    public float moventspeed = 500f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //audioSource = GetComponent<AudioSource>();  
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        transform.Translate(Vector3.right * Time.deltaTime * moventspeed * horizontalInput);

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManger>().EngGame();
        }
    }
}