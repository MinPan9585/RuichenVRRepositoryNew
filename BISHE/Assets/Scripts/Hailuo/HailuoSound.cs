using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HailuoSound : MonoBehaviour
{
    private bool playSound = false;
    private AudioSource jingyusfx;
    bool isPlaying = false;
    //public AudioSource sfxjingyu1;

    private void Start()
    {
        jingyusfx = GetComponent<AudioSource>();
    }
    public void HailuoGrabEnter()
    {
        playSound = true;
    }

    public void HailuoGrabExit()
    {
        playSound = false;
    }

    private void Update()
    {
        if(playSound && !isPlaying && Vector3.Distance(transform.position, Camera.main.transform.position) <= 0.5f)
        {
            jingyusfx.Play();
            isPlaying = true;
        }
        else if(!playSound)
        {
            jingyusfx.Pause();
            isPlaying = false;
        }
    }
    
}
