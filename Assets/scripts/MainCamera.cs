using System.ComponentModel.Design.Serialization;
using System.Xml.Schema;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private Transform target;
    [SerializeField] public float distanceToTarget = 10;
    
    private Vector3 previousPosition;
    private float zoom;
     public float FOV;
    public float minFOV;
    public float sensitivity;
     public float maxFOV;
    void Start()
     {
      transform.LookAt(target);
     
     }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);

       else if (Input.GetMouseButton(0))
        {
            Vector3 newPosition = cam.ScreenToViewportPoint(Input.mousePosition);
            Vector3 direction = previousPosition - newPosition;
            
            float rotationAroundYAxis = -direction.x * 180; // camera moves horizontally
            float rotationAroundXAxis = direction.y * 180; // camera moves vertically
            
            cam.transform.position = target.position;
            
            cam.transform.Rotate(new Vector3(1, 0, 0), rotationAroundXAxis);
            cam.transform.Rotate(new Vector3(0, 1, 0), rotationAroundYAxis, Space.World); // <— This is what makes it work!
            //distanceToTarget+=Input.mouseScrollDelta.y;
            
            cam.transform.Translate(new Vector3(0, 0, -distanceToTarget));
            
            previousPosition = newPosition;



        }
        
         FOV = Camera.main.fieldOfView;
         FOV += (Input.GetAxis("Mouse ScrollWheel") * sensitivity)*-1;
         FOV= Mathf.Clamp(FOV, minFOV, maxFOV);
         Camera.main.fieldOfView = FOV;
    }










//     [SerializeField] private Camera c;
//     public Transform plane;
//     public Vector3 offset;
//     public  float  rotatingSpeed;
//     private float speedMod = 10.0f;
//     //float rotate=1;
//     public float sensitivity = 1f; 
     
//     c
    
//      void Update ()
//      {
        
//         Vector3 direction  = c.ScreenToViewportPoint(Input.mousePosition);
//          var c = Camera.main.transform;
//         c.transform.position=plane.position+offset;
//         if(Input.GetMouseButton(0))
//           {
//             c.transform.position =new Vector3();

//             c.transform.Rotate(new Vector3(1,0,0),)
//           }  

//         // c.Rotate(0, 0, -Input.GetAxis("QandE")*90 * Time.deltaTime);
//         //  if (Input.GetMouseButtonDown(0))
//         //      Cursor.lockState = CursorLockMode.Locked;

//      }
    // Start is called before the first frame update
    // Update is called once per frame
    // void Update()
    // {
        
    //     transform.position=plane.position+offset;//float mouseX=input.GetAxis("Mouse X")*_mouseSe
    // }
}
