using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instan : MonoBehaviour
{
    public GameObject objectToSpawn;
   

    float timer = 3;
        
    private void Update()
    {
        if(Time.time >= timer)
        {
            GameObject Begin = Instantiate(objectToSpawn, Camera.main.transform.position, Camera.main.transform.rotation);
            Begin.transform.Translate(new Vector3(0, 0, 10), Space.Self);
            Debug.Log("chuxian");
            timer = Mathf.Infinity;
        }

    }

}
