using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tor_Red_Trigger : MonoBehaviour
{
    // Start is called before the first frame update


    public Ball ballMachine;
    void Start()
    {
        
    }

    
    
     void OnTriggerEnter(Collider other) {

           
    if (other.gameObject.CompareTag("Sphere")  && ballMachine.currentState == ballState.red) 
            
    {
    Destroy(this.gameObject);

    Destroy(other.gameObject);
                 
    }
         


}
}
