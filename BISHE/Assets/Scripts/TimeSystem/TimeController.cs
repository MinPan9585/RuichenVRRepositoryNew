using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public Transform directionalLight;
    public float rotationSpeed;
   
    
    
    public GameObject[] beike;
    public Material[] skyboxMaterial;


    
    public float fenzhenSpeed;
    public float shizhenSpeed;
    public GameObject Shizhen;
    public GameObject Fenzhen;

    
    
    public GameObject textObject;
    private void Update()
    {
        //太阳的旋转
        directionalLight.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
        //Rotate();
        //ClampRot(30, 150);
       
        

        Fenzhen.transform.Rotate(0, 0, fenzhenSpeed * Time.deltaTime);
        Shizhen.transform.Rotate(0, 0, shizhenSpeed * Time.deltaTime);

        //4-8分钟，第二阶段
        if(Time.time >= 240)
        {
            //换成中午的天空
            RenderSettings.skybox = skyboxMaterial[1];
            

            //beike[0].SetActive(false);
            //textObject.SetActive(true);
            //sky.material = skyboxMaterial;
            //instantiate(textObject,   );
        }
        //8-12分钟，第三阶段
        if (Time.time >= 480)
        {
            //换成下午的天空
            RenderSettings.skybox = skyboxMaterial[2];



            // beike[0].SetActive(true);
            //sky.material = skyboxes[3];
        }
    }
    /*void Rotate()
    {
        if(rotationSpeed * Time.deltaTime == 30)
        {
            directionalLight.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
        }
    }
    Vector3 v3;
    void ClampRot(float minX,float maxX)
    {
        v3 = transform.localEulerAngles;
        if(transform.localEulerAngles.x>maxX && transform.localEulerAngles.x<=maxX + 10)
        {
            v3.x = maxX;
        }
        else if (transform.localEulerAngles.z > 350 + minX && transform.localEulerAngles.z < 360 + minX)
        {
            v3.z = 360 + minX;
        }
        transform.localEulerAngles = v3;
    }*/

}
