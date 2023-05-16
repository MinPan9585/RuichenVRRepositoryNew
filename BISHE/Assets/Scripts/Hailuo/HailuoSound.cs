using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HailuoSound : MonoBehaviour
{
    private bool playSound = false;
    public AudioSource sfxjingyu1;
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
        if(playSound == true && Vector3.Distance(transform.position, Camera.main.transform.position)<= 0.2f)
        {
            sfxjingyu1 .Play();
        }
        else
        {
            sfxjingyu1.Pause();
        }
    }
}
