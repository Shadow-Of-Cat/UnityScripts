using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float  thrust;
    public float  thrustMultiplier;
    public float yawMultiplier;

    public float pitchMultiplier;

    new Rigidbody rigidbody; 

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float  pitch = Input.GetAxis("Vertical");
        float  yaw=Input.GetAxis("Horizontal");
        float  tangage  = Input.GetAxis("Tangential");
        rigidbody.AddRelativeForce(0f,0f,thrust*thrustMultiplier*Time.deltaTime);
        rigidbody.AddRelativeTorque(pitch*pitchMultiplier*Time.deltaTime,yaw*yawMultiplier*Time.deltaTime,-yaw*yawMultiplier*2*Time.deltaTime);

    }

    // Update is called once per frame

}
