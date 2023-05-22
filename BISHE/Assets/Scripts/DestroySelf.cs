using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    float timer;


    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 6)
        {
            Destroy(this.gameObject);
        }
    }
}
