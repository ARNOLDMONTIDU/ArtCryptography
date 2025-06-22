using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class cesar1 : MonoBehaviour
{

    [SerializeField] Button btnClick;
    [SerializeField] TMP_InputField inputField;
    [SerializeField] TMP_InputField sdvig;
    [SerializeField] TextMeshProUGUI resultText;
    public TMP_InputField[] alfavit = new TMP_InputField[33];
    public TMP_InputField[] zadanieinputfield = new TMP_InputField[33];
    

    void Start()
    {
        //string phrase = "ĞÀÇÓÌÀËÈØÀÅÒÍÅÑÎÌÍÅÍÈÅÀÓÂÅĞÅÍÍÎÑÒÜ";
        int[] massiv = {};
        int i = 0;
        
        //foreach (var inputField in alfavit)
        //{

        //    inputField.text = massiv[i].ToString(); 
        //    i++;      
        //}

        //foreach (var inputField in zadanieinputfield)
        //{

        //    inputField.text = massiv[i].ToString();   
        //    i++;
        //}
    }

    public void ValidateInput()
    {
        string input = inputField.text;

        if (input == "ÕÅÌØÑÅĞÍİÅÉ×ÒÉÖÓÑÒÉÒÍÉÅØÆÉÕÉÒÒÓÖ×Á" || input == "ÀÑÄÍË_ÏÎĞÂÅÒÈÅÃß")
        {
            resultText.text = "Ïğàâèëüíî!!!";
        }
        else
        {
            resultText.text = "Íåâåğíî!!!";
        }
    }

    public void Increase()// Óâåëè÷èòü
    {
        

    }

    public void Reduse()// Óìåíüøèòü
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
