using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Windows;

public class gamma : MonoBehaviour
{

    [SerializeField] TMP_InputField inputField;
    [SerializeField] TextMeshProUGUI resultText;
    [SerializeField] GameObject nextBtn;
    public TMP_InputField[] ishodn = new TMP_InputField[7];
    public TMP_InputField[] _gamma = new TMP_InputField[7];
    public TMP_InputField[] shifr = new TMP_InputField[7];

    void Start()
    {

        nextBtn.SetActive(false);

    }
    public void ValidateInput()
    {
        string input = inputField.text.ToUpper();
        if (input == "ВЧДАДОБ")
        {
            nextBtn.SetActive(true);

            resultText.text = "Правильно";
           
        }
        else
        {
            resultText.text = "Неверно";
        }

        
        

    }

    void Update()
    {
        
    }
}
