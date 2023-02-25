using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public void FoodGrab()
    {
        transform.parent = null;
    }

    public Bird bird;
    void Start()
    {
        bird = FindObjectOfType<Bird>();
        Invoke("AttractBird", 5f);
    }

    void AttractBird()
    {
        bird.isAttracted = true;
    }
}
