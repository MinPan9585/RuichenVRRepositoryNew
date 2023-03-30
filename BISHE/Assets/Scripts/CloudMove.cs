using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove: MonoBehaviour
{
    public Transform[] waypoints;
    public int index = 0;
    public float speed;
    public Transform target;
    
    


    private void Start()
    {
        target = waypoints[index];
       
    }

    void Update()
    {

        transform.Translate(Vector3.Normalize(target.position - transform.position) * speed * Time.deltaTime, Space.World);
        transform.LookAt(target);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {

            index++;
            if (index == waypoints.Length)
            {
                index = 0;
            }
            target = waypoints[index];
        }
    }
}
