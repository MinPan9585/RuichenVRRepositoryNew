using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle : MonoBehaviour
{
    public GameObject particleSys;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(particleSys);
        }
    }
}
