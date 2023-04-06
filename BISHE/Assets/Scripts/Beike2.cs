using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beike2 : MonoBehaviour
{
    public AudioSource sfxbeike;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Tong")
        {
            Destroy(this.gameObject);
            sfxbeike.Play();
        }
    }
}
