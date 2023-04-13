using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Haixing1 : MonoBehaviour
{
    public AudioSource sfxbeike;
    public UIWheel uiwheel;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Tong")
        {
            Destroy(this.gameObject);
            uiwheel.score += 4;
            uiwheel.progress += 0.04f;
            sfxbeike.Play();
        }
    }
}
