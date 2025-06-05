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
    [SerializeField] TMP_InputField HUYNA;
    public GameObject[] objects = new GameObject[16];
    
    string phrase = "ÀÃÅÍÒ ÏĞÎÂÀËÈËÑß";

    private void Start()
    {
        //    phrase = "ÀÃÅÍÒ ÏĞÎÂÀËÈËÑß";
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

        if (input == "4")
        {
            inputField.text= "Ïğàâèëüíî!!!";
        }
        else
        {
            inputField.text = "Äóğàê ÷òî-ëè?";
        }

         
    }


}
    
        