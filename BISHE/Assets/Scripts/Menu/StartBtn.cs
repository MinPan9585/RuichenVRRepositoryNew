using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBtn : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("New Scene4.4");
    }
}
