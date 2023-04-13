using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    private Rigidbody rb;
    public void FoodGrab()
    {
        //reset food amount
        Can can = transform.parent.parent.GetComponent<Can>();
        //Can.foodAmount = 0;
        rb.isKinematic = false;
        rb.useGravity = true;

        transform.parent = null;
        
    }

    Bird bird;
    void Start()
    {
        bird = FindObjectOfType<Bird>();
        Invoke("AttractBird", 7f);
        rb = GetComponent<Rigidbody>();
    }

    void AttractBird()
    {
        bird.isAttracted = true;
    }
}
