using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pot : MonoBehaviour
{

    public void OnLoginButtonClick()
    {
        SceneManager.LoadScene("PotScene");
    }
}
