using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tips1 : MonoBehaviour
{
    //public GameObject Tips;
    //public bool isTips1Active = false;
    MeshRenderer meshRend;
    public bool isMesh = false;


    void Start()
    {
        meshRend = GetComponent<MeshRenderer>();
    }

    
    void Update()
    {
        if(isMesh ==false && Vector3.Distance(transform.position, Camera.main.transform.position) <=3f)
        {
            isMesh = true;
            meshRend.enabled = true;
            //print("run");
        }

        //if(Vector3.Distance(transform.position, Camera.main.transform.position) >= 5f)
        //{
            //meshRend.enabled = false;
        //}
    }


    //isTips1Active == false && 
    //isTips1Active == true && 
    //isTips1Active = true;
    //Destroy(this.gameObject);
}
