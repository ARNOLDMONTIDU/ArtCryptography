using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System;

public class ex1 : MonoBehaviour
{

    
    public Button btnClick;
    [SerializeField] TMP_InputField inputField; 
    [SerializeField] TextMeshProUGUI resultText;
    public GameObject[] objects = new GameObject[16];
    
    string phrase = "¿√≈Õ“ œ–Œ¬¿À»À—ﬂ";

    private void Start()
    {
        phrase = "¿√≈Õ“ œ–Œ¬¿À»À—ﬂ";
        string resphrase = phrase.Trim();
        for (int i = 0; i < objects.Length; i++)
        {
            string istring = Convert.ToString(i);
            objects[i].GetComponent<Text>().text = istring;
        }
    }

    public void ValidateInput()
    {
        string input = resultText.text;

        if (input == "123")
        {
            resultText.text= "aboba";
        }
        else
        {
            resultText.text = "amogus";
        }

         
    }


}
    
        