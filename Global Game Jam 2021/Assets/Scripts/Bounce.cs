using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private AudioSource source;

    private bool _firstSoundPlayed = false;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Player" )
        {
            if(_firstSoundPlayed)
            {
            source.Play();
            Debug.Log("Sound played");
            }
            else{
                _firstSoundPlayed = true;
            }

        }
        
    }
}
