using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{

    public void OnPlayAgain()
    {
        SceneManager.LoadScene("Main Game");
    }

    public void OnRegister()
    {
        SceneManager.LoadScene("Registrasi");
    }
}
