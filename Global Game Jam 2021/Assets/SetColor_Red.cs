using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor_Red : MonoBehaviour
{
    // Start is called before the first frame updat
    
    public GameObject sphereColor;

    void Start()
    {

        Light light = sphereColor.GetComponent<Light>();
        Renderer rend = sphereColor.GetComponent<Renderer>();
        
        
        light.color = Color.red;
        rend.material.SetColor("_Color", Color.red);
        
    }

    // Update is called once per frame
}

