using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hailuo2 : MonoBehaviour
{
    public AudioSource sfxbeike;
    public UIWheel uiwheel;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Tong")
        {
            Destroy(this.gameObject);
            uiwheel.score += 3;
            uiwheel.progress += 0.03f;
            sfxbeike.Play();
        }
    }
}
