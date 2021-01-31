using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    // Start is called before the first frame update


    public bool doorOpen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     void OnTriggerEnter(Collider other) {
            if (other.gameObject.CompareTag("Sphere") && !doorOpen) 
            
            {
                Destroy(this.gameObject);
                 
            }
        }
}
