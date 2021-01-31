using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    private Vector3 moveInput;
    private Vector3 moveVelocity;
    private Rigidbody rb;
    public SceneLoader sceneload;

    private float verticalAxis;
    private float horizontalAxis;

    public float speed = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        //moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        //moveVelocity = moveInput * moveSpeed;



        verticalAxis = Input.GetAxis("Vertical");
        horizontalAxis = Input.GetAxis("Horizontal");


        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, verticalAxis * Time.deltaTime * speed, Space.World);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, verticalAxis * Time.deltaTime * speed, Space.World);

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(horizontalAxis * Time.deltaTime * speed, 0, 0, Space.World);
            
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(horizontalAxis * Time.deltaTime * speed, 0, 0, Space.World);

        }






        if(Input.GetKeyDown(KeyCode.F12))
        {
            sceneload.ReloadCurrentScene();
        }




        


        
        

    }

    /*
    private void FixedUpdate()
    {
       rb.velocity = moveVelocity;
    }

    */

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Deadly"))
        {
            sceneload.ReloadCurrentScene();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            sceneload.ReloadCurrentScene();
        }
    }
}
