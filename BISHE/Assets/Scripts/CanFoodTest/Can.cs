using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Can : MonoBehaviour
{
    public static int foodAmount = 0;
    public void CanSelect()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        GameObject.FindWithTag("arrow").SetActive(false);
    }

    public void CanSelectExit()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }
}
