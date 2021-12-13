using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Q5_level_1 : MonoBehaviour
{
    public void OnTrueButton()
    {
        SceneManager.LoadScene(0);
    }

    public void OnFalseButton()
    {
        Application.Quit();
    }
}
