﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
    // Start is called before the first frame update

    
    public GameObject spherePos;

    public GameObject sphere;

    private Vector3 _spherePos;

    private bool carriesSphere;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        _spherePos = spherePos.transform.position;

        //Debug.Log("Input Mouse X: " + Input.mousePosition.x);
        //Debug.Log("Input Mouse Y: " + Input.mousePosition.y);

        //Get the Screen positions of the object
         Vector2 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);
         
         //Get the Screen position of the mouse
         Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);
         
         //Get the angle between the points
         float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);
 
         //Ta Daaa
         transform.rotation = Quaternion.Euler(new Vector3(0f,-angle + 270, 0f));

         if (carriesSphere == true )
         {
            sphere.transform.position = _spherePos;
         }
        


            
         if(Input.GetKeyDown(KeyCode.G))
         {
             carriesSphere = false;
         }
          
        
    }
    
    float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
         return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }


        void OnTriggerEnter(Collider other) {
            if (other.gameObject.CompareTag("Sphere")) {
                 Debug.Log("Penis");

                 sphere.transform.position = _spherePos;
                 
                 carriesSphere = true;
                 
            }
        }

}
