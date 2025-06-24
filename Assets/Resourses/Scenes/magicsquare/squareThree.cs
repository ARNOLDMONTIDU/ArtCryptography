using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// 3 on 3

public class squareThree : MonoBehaviour
{

    [SerializeField] Button btnClick;
    [SerializeField] TMP_InputField inputField;
    [SerializeField] TextMeshProUGUI resultText;
    public TMP_InputField[] zadanieinputfield = new TMP_InputField[9];
    [SerializeField] GameObject nextBtn;

    void Start()
    {
        nextBtn.SetActive(false);
        //string phrase = "агентский";
        int[] massiv =  {2,7,6,9,5,1,4,3,8};
        int i = 0;

        foreach (var inputField in zadanieinputfield)
        {   
            inputField.text = massiv[i].ToString();
            i++;
        }
    }

    public void ValidateInput()
    {
        string input = inputField.text.ToUpper();

        if (input == "ГКСЙТАНЕИ")
        {
            nextBtn.SetActive(true);
            resultText.text = "Правильно";
        }
        else
        {
            resultText.text = "Неверно";
        }


    }


}
