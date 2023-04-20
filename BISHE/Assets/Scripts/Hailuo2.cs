using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hailuo2 : MonoBehaviour
{
    public AudioSource sfxbeike;
    public UIWheel uiwheel;
    public ParticleSystem ps;
    public ParticleSystem ps2;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Tong")
        {
            Destroy(this.gameObject);
            uiwheel.score += 1;
            uiwheel.progress += 0.01f;
            sfxbeike.Play();
            ps.Play();

        }
        if (collision.gameObject.tag == "Ocean")
        {
            ps2.Play();
        }
    }
}
