using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Q4_level_1 : MonoBehaviour
{
    public void OnTrueButton()
    {
        SceneManager.LoadScene(5);
    }

    public void OnFalseButton()
    {
        Application.Quit();
    }
}
