using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fackel : MonoBehaviour
{

    // hi freddy
    public GameObject fireParticles;
    public Ball ballMachine;
    public GameObject torchLight;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Sphere") && ballMachine.currentState == ballState.red)
        {
            Debug.Log("Feuer frei");
            fireParticles.SetActive(true);
            torchLight.SetActive(true);
        }
    }

}
