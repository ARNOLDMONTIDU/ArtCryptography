using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }

    private void Update()
    {
        //if (Input.GetKey(KeyCode.Mouse0))
        //{
        //    Debug.Log("Mouse 0 ");
        //        ToMenu();
        //}
    }
    private void Start()
    {
        
            
    }
    //private void Update()
    //{

    //    if (Input.GetMouseButtonDown(KeyCode.Mouse0))
    //    {
    //        SceneManager.LoadScene(0);  
    //    }
    //}

}