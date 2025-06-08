using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System;

//4 on 4

public class ex1 : MonoBehaviour
{
    [SerializeField] Button btnClick;
    [SerializeField] TMP_InputField inputField; 
    [SerializeField] TextMeshProUGUI resultText;
    public GameObject[] objects = new GameObject[25];
    
    string phrase = "";

    private void Start()
    {
        //    phrase = "АГЕНТ ПРОВАЛИЛСЯ";
        //    string resphrase = phrase.Trim();
        //    for (int i = 0; i < objects.Length; i++)
        //    {
        //        string istring = Convert.ToString(i);
        //        objects[i].GetComponent<Text>().text = istring;
        //    }
       
    }

    public void ValidateInput()
    {
        string input = inputField.text;

        if (input == "")
        {
            resultText.text= "Правильно!!!";
        }
        else
        {
            resultText.text = "Неверно!!!";
        }

         
    }


}
    
        