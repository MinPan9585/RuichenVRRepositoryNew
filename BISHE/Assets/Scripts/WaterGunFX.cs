using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterGunFX : MonoBehaviour
{
    public ParticleSystem waterParticle;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            waterParticle.Play();
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            waterParticle.Stop();
        }
    }
}
