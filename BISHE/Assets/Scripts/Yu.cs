using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yu : MonoBehaviour
{
    public AudioSource sfxyu;
    public UIWheel uiwheel;
    public ParticleSystem ps;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ocean")
        {
            Debug.Log("wo shi yu");
            sfxyu.Play();
            uiwheel.score += 2;
            uiwheel.progress += 0.02f;
            ps.Play();
        }
    }
}
