using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shitou : MonoBehaviour
{
    public AudioSource sfxshitou;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ocean")
        {
            
            sfxshitou.Play();
        }
    }
}
