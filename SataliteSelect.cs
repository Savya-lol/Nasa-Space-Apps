using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SataliteSelect : MonoBehaviour
{
    public GameObject loading;
    public bool CanSel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CanSel)
        {
            if (Input.GetMouseButton(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.tag.Equals("Sun"))
                    {
                        SceneManager.LoadSceneAsync(2);
                        loading.SetActive(true);
                    }

                    if (hit.collider.tag.Equals("Mercury"))
                    {
                        SceneManager.LoadSceneAsync(3);
                        loading.SetActive(true);
                    }

                    if (hit.collider.tag.Equals("Venus"))
                    {
                        SceneManager.LoadSceneAsync(4);
                        loading.SetActive(true);
                    }

                    if (hit.collider.tag.Equals("Earth"))
                    {
                        SceneManager.LoadSceneAsync(5);
                        loading.SetActive(true);
                    }

                    if (hit.collider.tag.Equals("Mars"))
                    {
                        SceneManager.LoadSceneAsync(7);
                        loading.SetActive(true);
                    }

                    if (hit.collider.tag.Equals("Jupiter"))
                    {
                        SceneManager.LoadSceneAsync(9);
                        loading.SetActive(true);
                    }

                    if (hit.collider.tag.Equals("Saturn"))
                    {
                        SceneManager.LoadSceneAsync(10);
                        loading.SetActive(true);
                    }

                    if (hit.collider.tag.Equals("Uranus"))
                    {
                        SceneManager.LoadSceneAsync(11);
                        loading.SetActive(true);
                    }

                    if (hit.collider.tag.Equals("Neptune"))
                    {
                        SceneManager.LoadSceneAsync(12);
                        loading.SetActive(true);
                    }
                }
            }
        }
    }
        
}
