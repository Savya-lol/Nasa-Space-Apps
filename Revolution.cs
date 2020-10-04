using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    public GameObject planet; // plant /moon to revolve
    public GameObject revpoint; //point  to Revolve around
    public float revolvespeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        planet.transform.RotateAround(revpoint.transform.localPosition,Vector3.up,revolvespeed*Time.deltaTime);
    }
}