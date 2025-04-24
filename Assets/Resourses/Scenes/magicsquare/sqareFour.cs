using System.Collections;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class sqareFour : MonoBehaviour
{
    
    [SerializeField] Button btnClick;
    [SerializeField] TMP_InputField inputField;
    [SerializeField] TextMeshProUGUI resultText;
    public TMP_InputField[] zadanieinputfield = new TMP_InputField[16];

    void Start()
    {
        string phrase = "АГЕНТ ПРОВАЛИЛСЯ";
        //string resphrase = phrase.Replace(" ", "");


        //int n = 4;
        //int[,] magicSquare = new int[n, n];

        //GenerateDoublyEvenMagicSquare(magicSquare, n);
        //PrintMagicSquare(magicSquare);

        //inputField.text = Random.Range(0, 16).ToString();

        foreach (var inputField in zadanieinputfield)
        {
            inputField.text = "1";
        }
    }



    //private void GenerateDoublyEvenMagicSquare(int[,] square, int n) //Генерация 4x4
    //{
    //    int num = 1;
    //    for (int i = 0; i < n; i++)
    //    {
    //        for (int j = 0; j < n; j++)
    //        {
    //            bool isDiag = (i % 4 == j % 4) || (i % 4 + j % 4 == 3);
    //            square[i, j] = isDiag ? num : n * n + 1 - num;
    //            num++;

    //        }
    //    }
  
    //}
    //public void PrintMagicSquare(int[,] square)
    //{

    //    int g = 0;

    //    for (int i = 0; i < 4; i++)
    //    {
    //        for (int j = 0; j < 4; j++)
    //        {

    //            zadanieinputfield[g].GetComponent<Text>().text = square[i, j].ToString();
    //            g++;
    //        }
    //    }

    //}



    public void ValidateInput()
    {
        string input = inputField.text;

        if (input == "4")
        {
            resultText.text = "Правильно!!!";
        }
        else
        {
            resultText.text = "Неверно";
        }


    }
}
