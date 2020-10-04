using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoverScript : MonoBehaviour
{
    public GameObject playercamera;
    private float mX;
    private float h;
    private float v;
    public float speed;
    public float Rotspeed;
    public float sensetivity;
    
    // Start is called before the first frame update
    void Start()
    {
       Cursor.lockState = CursorLockMode.Locked;
       Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        mX = Input.GetAxis("Mouse X");
      
        transform.Translate(new Vector3(0, 0, v)*speed*Time.deltaTime);
        transform.Rotate(new Vector3(0,h,0)*Rotspeed*Time.deltaTime);
        
        playercamera.transform.RotateAround(transform.position,Vector3.up, mX*sensetivity*Time.deltaTime);
    if(Input.GetKey(KeyCode.Escape))
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadSceneAsync(7);
    }
    }
}
