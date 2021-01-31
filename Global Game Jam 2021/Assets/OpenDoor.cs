using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    // Start is called before the first frame update


    public bool doorOpen;

    private string _doorColor;

    public SetColor colorset;
    public Ball ballMachine;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     void OnTriggerEnter(Collider other) {

           if(colorset.blue)
            {
                if (other.gameObject.CompareTag("Sphere") && !doorOpen && ballMachine.currentState == ballState.blue) 
            
            {
                Destroy(this.gameObject);
                Destroy(other.gameObject);
                 
            }
            else if(colorset.red)
            {
                if (other.gameObject.CompareTag("Sphere") && !doorOpen && ballMachine.currentState == ballState.red) 
            
            {
                Destroy(this.gameObject);
                Destroy(other.gameObject);
                 
            }
            else if(colorset.green)
            {
                if (other.gameObject.CompareTag("Sphere") && !doorOpen && ballMachine.currentState == ballState.green) 
            
            {
                Destroy(this.gameObject);
                Destroy(other.gameObject);
                 
            }


            }


        }
}}}
