using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_UI : MonoBehaviour
{
    public void OnButtonClickFirst()
    {
        SceneManager.LoadScene("Facebook");
    }
    public void OnButtonClickSecond()
    {
        SceneManager.LoadScene("Gmail");
    }
    public void OnButtonClickThird()
    {
        SceneManager.LoadScene("Twitter");
    }

    public void OnButtonClickMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
