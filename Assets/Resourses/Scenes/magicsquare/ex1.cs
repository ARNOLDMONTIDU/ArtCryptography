using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ex1 : MonoBehaviour
{

    
    public Button btnClick;
    [SerializeField] TMP_InputField inputField; 
    [SerializeField] TextMeshProUGUI resultText;

    private void Start()
    {
             
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
    
        