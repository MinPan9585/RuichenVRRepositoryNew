using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tips1 : MonoBehaviour
{
    public GameObject Tips;
    public bool isTips1Active = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(isTips1Active == false && Vector3.Distance(transform.position, Camera.main.transform.position) <=5f)
        {
            isTips1Active = true;
        }

        if(isTips1Active == true && Vector3.Distance(transform.position, Camera.main.transform.position) >= 10f)
        {
            Destroy(this.gameObject);
        }
    }
}
