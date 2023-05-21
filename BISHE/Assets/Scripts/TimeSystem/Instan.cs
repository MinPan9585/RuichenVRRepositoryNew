using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instan : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject greenObject;
        
    private void Update()
    {
        if(Time.time==3)
        {
            GameObject plane = Instantiate(objectToSpawn, greenObject.transform.position, Camera.main.transform.rotation);
            plane.transform.Translate(new Vector3(0, 0, 10), Space.Self);
            Debug.Log("chuxian");

        }
    }

}
