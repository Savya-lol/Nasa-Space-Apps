using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Galaxymanager : MonoBehaviour
{
    public GameObject Loading;
    // Start is called before the first frame update
    public void andromeda()
    {
     SceneManager.LoadSceneAsync(19);
     Loading.SetActive(true);
    }
    public void milkyway()
    {
     SceneManager.LoadSceneAsync(18);
     Loading.SetActive(true);
    }
}
