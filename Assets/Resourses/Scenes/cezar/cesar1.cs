using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Windows;

public class cesar1 : MonoBehaviour
{

    [SerializeField] Button btnClick;
    [SerializeField] TMP_InputField inputField;
    [SerializeField] TMP_InputField sdvig;
    [SerializeField] TextMeshProUGUI resultText;
    public TMP_InputField[] alfavit = new TMP_InputField[33];
    public TMP_InputField[] zadanieinputfield = new TMP_InputField[33];
    [SerializeField] GameObject questions;

    

    void Start()
    {
        questions.SetActive(false);
    }

    public void ValidateInput()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        string phrase = "ĞÀÇÓÌÀËÈØÀÅÒÍÅÑÎÌÍÅÍÈÅÀÓÂÅĞÅÍÍÎÑÒÜ";
        string rightAnsver= "";
        string input = inputField.text.ToUpper();


        if (currentSceneIndex == 7)
        {
            phrase = "ĞÀÇÓÌÀËÈØÀÅÒÍÅÑÎÌÍÅÍÈÅÀÓÂÅĞÅÍÍÎÑÒÜ";
            rightAnsver = "ÕÅÌØÑÅĞÍİÅÉ×ÒÉÖÓÑÒÉÒÍÉÅØÆÉÕÉÒÒÓÖ×Á";        
        }
        else if (currentSceneIndex == 11)
        {
            phrase= "Ó ëóêîìîğüÿ äóá çåë¸íûé;Çëàòàÿ öåïü íà äóáå òîì:";
            questions.SetActive(true);
            rightAnsver = "ÛÓÛÒÖÔÖÆØÄËÛÈÏÌÓÍÕÃÑÙİÑÄÑĞÇÖÁÍßÑÕÅÒÖÄÀŞ";
        }       
        else if (currentSceneIndex == 12)
        {
            phrase = "Äàéòå ìíå òî÷êó îïîğû è ÿ ïåğåâåğíó çåìíîé øàğ";
            questions.SetActive(true);
            rightAnsver = "×Óİ¨ØÀÁØÕÑÚÍÖÑÒÑÓŞËÂÒÇÓÇÅÇÓĞÖÑÎÖ×ØÓÂÉÚ";

        }
        else if (currentSceneIndex == 16)
        {
            phrase = "Ñ÷àñòüå";
            questions.SetActive(true);
            rightAnsver = "ÔÚÃÔÕßÇ";

        }
        //ôúãôõÿç

        if (input == rightAnsver)
        {
            resultText.text = "Ïğàâèëüíî";
            questions.SetActive(true);
        }
        else
        {       
            resultText.text = "Íåâåğíî";
        }

    }
    void Update()
    {
      
        try
        {
            string[] àlphabet =
            {
            "À", "Á", "Â", "Ã", "Ä", "Å", "¨", "Æ", "Ç", "È", "É",
            "Ê", "Ë", "Ì", "Í", "Î", "Ï", "Ğ", "Ñ", "Ò", "Ó", "Ô",
            "Õ", "Ö", "×", "Ø", "Ù", "Ú", "Û", "Ü", "İ", "Ş", "ß"
            };
    
            int i = 0;


            int shift = -(int.Parse(sdvig.text));

            foreach (var inputField in zadanieinputfield)
            {

                inputField.text = àlphabet[i].ToString();
                i++;
            }

            string[] shiftedAlphabet = new string[àlphabet.Length];
            int currentIndex = 0;
            foreach (string letter in àlphabet)
            {
                // Âû÷èñëÿåì íîâûé èíäåêñ ñ ó÷åòîì ñäâèãà
                int newIndex = (currentIndex + shift) % àlphabet.Length;
                if (newIndex < 0)
                    newIndex += àlphabet.Length;

                // Çàïèñûâàåì áóêâó íà íîâóş ïîçèöèş
                shiftedAlphabet[newIndex] = letter;
                currentIndex++;
            }

            int j = 0;
            foreach (var inputField in zadanieinputfield)
            {
               
                inputField.text = shiftedAlphabet[j];
                j++;
            }

        }
        catch (FormatException) 
        {
            int shift = 0;
            sdvig.text = shift.ToString();
        }
    }   
}

