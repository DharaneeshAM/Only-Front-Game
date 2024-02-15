using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpSpeed = 5.0f;
    private float horizontalInput;
    private float forworldInput;
    private Rigidbody RB;

    void Start() 
    {
        RB = GetComponent<Rigidbody>();
    }

    void Update() 
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forworldInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forworldInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            RB.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
        }
    }
}
