using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public Transform directionalLight;
    public float rotationSpeed;
    public GameObject[] beike;
    public Material skybox1Material;

    public GameObject textObject;
    private void Update()
    {
        directionalLight.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
        if(Time.time >= 300)
        {
            beike[0].SetActive(false);
            textObject.SetActive(true);
            Destroy(beike[1]);
            //sky.material = skybox1Material;
            //instantiate(textObject,   );
        }
        if (Time.time >= 600)
        {
            beike[0].SetActive(true);
            //sky.material = skyboxes[3];
        }
    }
}
