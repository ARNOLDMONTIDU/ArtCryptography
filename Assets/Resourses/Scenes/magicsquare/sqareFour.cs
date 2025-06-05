using System.Collections;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

//4 on 4

public class sqareFour : MonoBehaviour
{
    
    [SerializeField] Button btnClick;
    [SerializeField] TMP_InputField inputField;
    [SerializeField] TextMeshProUGUI resultText;
    public TMP_InputField[] zadanieinputfield = new TMP_InputField[16];

    void Start()
    {
        string phrase = "ÀÃÅÍÒ ÏĞÎÂÀËÈËÑß";
        int[] massiv = {1,15,14,4,12,6,7,9,8,10,11,5,13,3,2,16};
        int i = 0;

        foreach (var inputField in zadanieinputfield)
        {
            //massiv[i] = Random.Range(0, 16);
            inputField.text = massiv[i].ToString();
            i++;
        }
    }




    public void ValidateInput()
    {
        string input = inputField.text;

        if (input == "àñäíë_ïîğâåòèåãÿ" || input == "ÀÑÄÍË_ÏÎĞÂÅÒÈÅÃß")
        {
            resultText.text = "Ïğàâèëüíî!!!";
        }
        else
        {
            resultText.text = "Íåâåğíî!!!";
        }


    }
}
