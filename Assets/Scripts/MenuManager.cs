using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    //Called by buttons
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
