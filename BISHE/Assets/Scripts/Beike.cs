using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beike : MonoBehaviour
{
    public AudioSource sfxbeike;
    public UIWheel uiwheel;
    

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Tong")
        {
            Destroy(this.gameObject);
            uiwheel.score += 1;
            uiwheel.progress += 0.01f;
           
            sfxbeike.Play();
        }
    }
}
