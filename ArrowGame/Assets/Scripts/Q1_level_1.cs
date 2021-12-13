using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Q1_level_1 : MonoBehaviour
{
    public void OnTrueButton()
    {
        SceneManager.LoadScene(2);
    }

    public void OnFalseButton()
    {
        Application.Quit();
    }
}
