using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject loading;
    public GameObject panel;
    public GameObject Loading2;
    public SataliteSelect satsel;
   
    void Start()
    {
        satsel.CanSel = true;
    }

    // Update is called once per frame
    public void OnBack()
    {
        SceneManager.LoadSceneAsync(1);
        loading.SetActive(true);
    }

    public void OnMoon()
    {
        SceneManager.LoadSceneAsync(6);
        loading.SetActive(true);

    }
    public void OnMars()
    {
        SceneManager.LoadSceneAsync(8);
        loading.SetActive(true);
    }

    public void PanelOpen()
    {
        satsel.CanSel = false;
        panel.SetActive(true);
    }

    public void PanelClose()
    {
        satsel.CanSel = true;
        panel.SetActive(false);
    }

    public void Ceres()
    {
        SceneManager.LoadSceneAsync(13);
        Loading2.SetActive(true);
    }

    public void Eris()
    {
        SceneManager.LoadSceneAsync(14);
        Loading2.SetActive(true);
    }

    public void Haumea()
    {
        SceneManager.LoadSceneAsync(15);
        Loading2.SetActive(true);
    }
    public void OnGalaxy()
    {
     SceneManager.LoadSceneAsync(16);
     Loading2.SetActive(true);
    
    }

     public void AndromedaPanelOpen()
     {
         panel.SetActive(true);
     }
     public void AndromedaPanelclose()
     {
         panel.SetActive(false);
     }
}