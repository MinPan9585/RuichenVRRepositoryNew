using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Can : MonoBehaviour
{
    public void FoodReady()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetComponent<Rigidbody>().isKinematic = true;
    }

    public void FoodNotReady()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetComponent<Rigidbody>().isKinematic = false;
    }
}
