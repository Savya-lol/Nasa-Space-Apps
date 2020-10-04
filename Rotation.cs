using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private float h;
    private float v;

    public float rotspeed;
    
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        
        transform.Rotate(new Vector3(v,-h,0) * rotspeed * Time.deltaTime);

    }
}
