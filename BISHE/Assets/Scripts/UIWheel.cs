using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIWheel : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score = 0;
    public Image wheel;
    public float progress = 0.0f;

    public GameObject Can;
    public bool isCanActive = false;

    public GameObject Shuiqiang;
    public bool isShuiqiangActive = false;

    public GameObject Hailuo;
    public bool isHailuoActive = false;


    void Update()
    {
        if(score >= 30 && isCanActive == false)
        {
            Can.SetActive(true);
            isCanActive = true;
        }

        if (score >= 60 && isShuiqiangActive == false)
        {
           Shuiqiang.SetActive(true);
            isShuiqiangActive = true;
        }

        if (score >= 100 && isHailuoActive == false)
        {
            Hailuo.SetActive(true);
            isHailuoActive = true;
        }
        //if (score >= 100)
        //return;
        //if(progress>= 1f)
        //{
        //return;
        //}
        //if (Input.GetKeyDown(KeyCode.A))
        //{
           // score += 10;
            //progress += 0.1f;
        //}
        scoreText.text = score.ToString();
        wheel.fillAmount = progress;
    }
}
