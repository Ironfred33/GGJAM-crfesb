using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor_Green : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sphereColor;

    void Start()
    {

        Light light = sphereColor.GetComponent<Light>();
        Renderer rend = sphereColor.GetComponent<Renderer>();
        
        
        light.color = Color.green;
        rend.material.SetColor("_Color", Color.green);
        
    }
}
