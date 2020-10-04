using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource voice;

    public GameObject mute;
    public GameObject speak;
    public AudioSource music;
    int click;
    public GameObject aboutship;
    
    // Start is called before the first frame update
    void Start()
    {
        voice = voice.GetComponent<AudioSource>();
        music= music.GetComponent<AudioSource>();
        
    }

    void Update() {
       
    }

    public void Speak()
    {
        click+=1;
        if (!voice.isPlaying)
        {
            mute.SetActive(true);
            speak.SetActive(false);
            voice.Play(0);
            Debug.Log("Playing");
            music.Pause();
        }

        if(voice.isPlaying&& click>=2)
        {
            mute.SetActive(false);
            speak.SetActive(true);
            voice.Stop();
            click = 0 ;
            Debug.Log("Stop");
            music.Play(0);
        }
      
    }
    public void OnOpen()
    {
        aboutship.SetActive(true);
    }
   public void OnClose()
   {
       aboutship.SetActive(false);
   }
 }


