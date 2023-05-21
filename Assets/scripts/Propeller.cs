using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{

    public float  speed= 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        speed+=Time.deltaTime;
        if(Input.GetKey(KeyCode.S))
          speed-=Time.deltaTime;
        transform.Rotate(Vector3.forward *speed);
    }
}
