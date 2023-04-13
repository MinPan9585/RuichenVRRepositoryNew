using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yezi : MonoBehaviour
{
   
    public int Blood = 10;
    public Rigidbody rb;
    public Collider col;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Blood -= 2;
            if (Blood <= 0)
            {
                //Destroy(this.gameObject);
                rb.useGravity = true;
                col.isTrigger = false;
            }
        }
    }
}
