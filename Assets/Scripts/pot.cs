using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class pot : MonoBehaviour
{

    public void OnLoginButtonClick() {
      SceneManager.LoadScene("PotScene");
    }

    public void OnLoginButtonClick1()
    {
        SceneManager.LoadScene("RootGameScene");
    }
}
