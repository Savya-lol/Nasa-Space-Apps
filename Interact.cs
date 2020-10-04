using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    public GameObject exit;

    public float range;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit,range))
        {
            if (hit.collider.tag == "Back")
            {
                exit.SetActive(true);
            }
            else
            {
                exit.SetActive(false);
            }
        }

        if (exit.activeSelf && Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadSceneAsync(5);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
