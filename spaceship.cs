using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spaceship : MonoBehaviour
{
    public float initialspeed;
    public float finalspeed;
    public int SceneNumber;
    public float speed;
    public GameObject loading;
    // Start is called before the first frame update
    void Start()
    {
        speed = initialspeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back*speed*Time.deltaTime);
    }

    void OnTriggerEnter(Collider other) {
        if(other.tag.Equals("Speed"))
        {
            speed = finalspeed;
        }
        if(other.tag.Equals("Scene"))
        {
            loading.SetActive(true);
            SceneManager.LoadSceneAsync(SceneNumber);
        }
    }
}
