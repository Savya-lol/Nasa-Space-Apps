using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Maanager : MonoBehaviour
{
   public GameObject credits;
   public GameObject Loading;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClose()
    {
        credits.SetActive(false);
    }
    public void OnOpen()
    {
        credits.SetActive(true);
    }
    public void OnPlay()
    {
     SceneManager.LoadSceneAsync(1);
     Loading.SetActive(true);
    }
}
