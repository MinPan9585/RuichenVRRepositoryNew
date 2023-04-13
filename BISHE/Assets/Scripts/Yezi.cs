using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yezi : MonoBehaviour
{
   
    public int Blood = 10;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Blood -= 2;
            if (Blood <= 0)
            {
                Destroy(this.gameObject);
            }
        }





    }





}
