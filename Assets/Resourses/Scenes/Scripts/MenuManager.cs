using UnityEngine;
using UnityEngine.SceneManagement;


public class ToMainMenu : MonoBehaviour
{
    public void LoadЕxScene()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Задания практические");
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
    public void LoadCesarsScene()
    {
        SceneManager.LoadScene(6);
        Debug.Log("Цезари");
    }
    public void LoadCesar1Scene()
    {
        SceneManager.LoadScene(7);
        Debug.Log("Цезарь1");
    }
    public void LoadMenuScene()
    {
        SceneManager.LoadScene(8);
        Debug.Log("Главное меню");
    }
    public void TheoryMenu()
    {
        SceneManager.LoadScene(9);
        Debug.Log("Меню теории");

    }
    public void Report()
    {
        SceneManager.LoadScene(10);
        Debug.Log("report");

    }
    public void LoadCesar2Scene()
    {
        SceneManager.LoadScene(11);
        Debug.Log("Цезарь2");
    }
    public void LoadCesar3Scene()
    {
        SceneManager.LoadScene(12);
        Debug.Log("Цезарь3");
    }
    public void LoadMagicTheory()
    {
        SceneManager.LoadScene(13);
        Debug.Log("Магическая теория");
    }
    public void LoadMagicQuestions()
    {
        SceneManager.LoadScene(14);
        Debug.Log("контр вопросы");
    }
}
