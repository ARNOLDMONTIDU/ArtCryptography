        using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ToMainMenu : MonoBehaviour
{
    public void LoadMenuScene()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Главное меню");
    }
    public void LoadЕxScene()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Переход на другую сцену");
    }
    public void Loadex1Scene()
    {
        SceneManager.LoadScene(2);
        Debug.Log("Переход на другую сцену");
    }
}       

