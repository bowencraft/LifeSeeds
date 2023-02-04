using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class backtomain : MonoBehaviour
{
    public void OnLoginButtonClick()
    {
        SceneManager.LoadScene("MainScene");
    }
}