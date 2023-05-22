using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tips1 : MonoBehaviour
{
    public GameObject Tips;
    public bool isTips1Active = false;
    MeshRenderer meshRend;

    void Start()
    {
        meshRend = GetComponent<MeshRenderer>();
    }

    
    void Update()
    {
        if(isTips1Active == false && Vector3.Distance(transform.position, Camera.main.transform.position) <=5f)
        {
            isTips1Active = true;
            meshRend.enabled = true;
            print("run");
        }

        if(isTips1Active == true && Vector3.Distance(transform.position, Camera.main.transform.position) >= 10f)
        {
            Destroy(this.gameObject);
        }
    }
}
