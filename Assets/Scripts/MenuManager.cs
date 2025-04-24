using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ToMainMenu : MonoBehaviour
{
    public void LoadMenuScene()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Переход на другую сцену");
    }
}       