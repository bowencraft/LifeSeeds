using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class pot : MonoBehaviour
{

    public void OnLoginButtonClick()
    {
        if (ToolUse.isDragging)
        {
            Debug.Log("Yes");
        }
        else
        {
            SceneManager.LoadScene("PotScene");
        }
    }
}
