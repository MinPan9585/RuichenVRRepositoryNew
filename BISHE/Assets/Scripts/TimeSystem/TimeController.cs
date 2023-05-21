using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public Transform directionalLight;
    public float rotationSpeed;
    private bool sunRotate = true;



    public GameObject[] beike;
    public Material[] skyboxMaterial;


    
    public float fenzhenSpeed;
    public float shizhenSpeed;
    public GameObject Shizhen;
    public GameObject Fenzhen;
   

    
    
    public GameObject textObject;
    private void Update()
    {
        //̫������ת
        if (sunRotate)
        {
            directionalLight.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
        }
        
       
        

        Fenzhen.transform.Rotate(0, 0, fenzhenSpeed * Time.deltaTime);
        Shizhen.transform.Rotate(0, 0, shizhenSpeed * Time.deltaTime);

        //4-8���ӣ��ڶ��׶�
        if(Time.time >= 240)
        {
            //������������
            RenderSettings.skybox = skyboxMaterial[1];
            
            //ɳ̲�ϵ����������
            foreach (var item in beike)
            {
                item.SetActive(false);
            }

            
            //beike[0].SetActive(false);
            //textObject.SetActive(true);
            //sky.material = skyboxMaterial;
            //instantiate(textObject,   );
        }
        //8-12���ӣ������׶�
        if (Time.time >= 480)
        {
            //������������
            RenderSettings.skybox = skyboxMaterial[2];
            //̫���ⲻת��
            sunRotate = false;
            //ɳ̲�ϵ���������
            foreach (var item in beike)
            {
                item.SetActive(true);
            }



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
