using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tor_Green_Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Ball ballMachine;
    
     void OnTriggerEnter(Collider other) {

           
    if (other.gameObject.CompareTag("Sphere")  && ballMachine.currentState == ballState.green) 
            
    {
    Destroy(this.gameObject);

    Destroy(other.gameObject);
                 
    }
}
}