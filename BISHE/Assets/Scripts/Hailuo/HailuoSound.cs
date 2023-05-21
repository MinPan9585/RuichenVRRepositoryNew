using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HailuoSound : MonoBehaviour
{
    private bool playSound = false;
    private AudioSource jingyusfx;
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
        if(playSound == true && Vector3.Distance(transform.position, Camera.main.transform.position)<= 1f)
        {
            jingyusfx.Play();
        }
        else
        {
            jingyusfx.Pause();
        }
    }
    
}
