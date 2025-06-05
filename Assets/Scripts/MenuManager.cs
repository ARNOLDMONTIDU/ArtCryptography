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
        Debug.Log("Задания");
    }
    public void Loadex1Scene()
    {
        SceneManager.LoadScene(2);
        Debug.Log("3 на 3");
    }
    public void Loadex2Scene()
    {
        SceneManager.LoadScene(3);
        Debug.Log("4 на 4");
    }
    public void Loadex3Scene()
    {
        SceneManager.LoadScene(4);
        Debug.Log("5 на 5");
    }
    public void LoadeSquaresScene()
    {
        SceneManager.LoadScene(5);
        Debug.Log("квадраты");
    }


}       

