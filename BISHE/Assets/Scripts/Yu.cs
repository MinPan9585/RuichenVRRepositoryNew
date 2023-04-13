using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yu : MonoBehaviour
{
    public AudioSource sfxyu;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ocean")
        {

            sfxyu.Play();
        }
    }
}
