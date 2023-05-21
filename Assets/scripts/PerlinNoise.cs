using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinNoise : MonoBehaviour
{
    public float i;
    public float j;
    float sid  =UnityEngine.Random.Range(0,1000);
    float zoom  =10f;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i <1000;i++)
            for(int j = 0; j <1000;j++)
            {
             Mathf.PerlinNoise(((i+sid)/zoom),(j+sid)/zoom); 
        }
    }

    // Update is called once per frame
    void Update()
    {
  
    }
}
