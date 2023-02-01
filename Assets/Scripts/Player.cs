using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject gold;

    void Update()
    {
        transform.Translate(new Vector3(0, 0, 0.02f));
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gold);
    }
}
