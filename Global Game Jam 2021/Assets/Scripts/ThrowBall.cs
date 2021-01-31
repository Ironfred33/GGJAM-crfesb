using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThrowBall : MonoBehaviour
{
    // Start is called before the first frame update

    
    public GameObject spherePos;

    public GameObject sphere;

    public Rigidbody rbSphere; 

    private Vector3 _spherePos;

    public GameObject player;

    private bool carriesSphere;

    public Image throwForceGUI;

    //public Transform SphereHolder;

    //public Transform parent;

    private float _maxForce;
    public float thrust;

    private float _timer = 0.0f; 
    public float maxHoldTime = 2.0f;

    void Start()
    {

        _maxForce = maxHoldTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        

        _spherePos = spherePos.transform.position;

        //Get the Screen positions of the object
         Vector2 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);
         
         //Get the Screen position of the mouse
         Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);
         
         //Get the angle between the points
         float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);
 
         //Ta Daaa
         transform.rotation = Quaternion.Euler(new Vector3(0f,-angle + 270, 0f));

         if (carriesSphere)
         {
            sphere.transform.position = _spherePos;

            player.GetComponent<PlayerMovement>().enabled = false;
         }
         else if(!carriesSphere)
         {
            player.GetComponent<PlayerMovement>().enabled = true;
         }
        

        if(carriesSphere)
        {

            throwForceGUI.enabled = true;

         if (Input.GetMouseButton(0))
        {
            Debug.Log("Pressed left click.");        

            
            
            if (_timer < maxHoldTime)
            {
                _timer += Time.deltaTime;
                
            }

               
                
            UpdateView();
            

        }

        if(Input.GetMouseButtonUp(0))
        {

            carriesSphere = false;

            //UnSetParent(SphereHolder);
            
            Debug.Log("Timer: " + _timer);

            rbSphere.AddForce(transform.forward * thrust * _timer);

            _timer = 0.0f;

        }
        }
        else
        {
            throwForceGUI.enabled = false;
            throwForceGUI.fillAmount = 0;
        }

    }

    
        float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
            return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
         }


        void OnTriggerEnter(Collider other) {
            if (other.gameObject.CompareTag("Sphere")) 
            
            {
            
                 sphere = other.gameObject;

                 sphere.transform.position = _spherePos;

                 rbSphere = other.gameObject.GetComponent<Rigidbody>();

                //SetTheParent(SphereHolder);
                 
                 carriesSphere = true;
                 
            }
        }

        void UpdateView()
        {
            throwForceGUI.fillAmount = _timer / _maxForce;
        }

       /* public void SetTheParent(Transform newParent)
    {
        // Sets "newParent" as the new parent of the child GameObject.
        sphere.transform.SetParent(newParent);

        // Same as above, except worldPositionStays set to false
        // makes the child keep its local orientation rather than
        // its global orientation.
        //child.transform.SetParent(newParent, false);

        // Setting the parent to ‘null’ unparents the GameObject
        // and turns child into a top-level object in the hierarchy
        //child.transform.SetParent(null);
    }

    public void UnSetParent(Transform newParent)
    {
        sphere.transform.SetParent(null);
    }
        

  */
}

