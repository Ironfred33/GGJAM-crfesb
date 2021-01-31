using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    
    public bool blue;
    public bool red;
    public bool green;

    public GameObject sphereColor;

    
    

    void Start()
    {

        Light light = sphereColor.GetComponent<Light>();
        Renderer rend = sphereColor.GetComponent<Renderer>();
        if(blue)
        {
            light.color = Color.blue;
            rend.material.SetColor("_Color", Color.blue);

        }
        else if(red)
        {
            light.color = Color.red;
            rend.material.SetColor("_Color", Color.red);
        }
        else if(green)
        {
            light.color = Color.green;
            rend.material.SetColor("_Color", Color.green);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
