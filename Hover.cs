using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hover : MonoBehaviour
{
    public Text Detail;
    private Scene scene;
    private void Start()
    {
        scene = SceneManager.GetActiveScene();
        Detail = Detail.GetComponent<Text>();
        Detail.text = scene.name == "SampleScene" ? "Solar System" : scene.name.ToString();
    }

    private void OnMouseOver()
    {
        Debug.Log("Hovered");
        Detail.text = gameObject.name.ToString()+" (Click for more)";
    }

    private void OnMouseExit()
    {
        Debug.Log("exit");
        Detail.text = scene.name == "SampleScene" ? "Solar System" : scene.name.ToString();
    }
}
