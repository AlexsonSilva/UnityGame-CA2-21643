using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Q2_level_1 : MonoBehaviour
{
    public void OnTrueButton()
    {
        Application.Quit();
    }

    public void OnFalseButton()
    {
        SceneManager.LoadScene(3);
        
    }
}
