using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class obuch : MonoBehaviour
{
    [SerializeField] Button btnClick;
    [SerializeField] TextMeshProUGUI theory;
    [SerializeField] TMP_InputField inputField;
    [SerializeField] TMP_InputField inputField1;
    [SerializeField] TMP_InputField inputField2;
    [SerializeField] TMP_InputField inputField3;
    int numPage = 1;
    [SerializeField] TextMeshProUGUI resultText;
    [SerializeField] GameObject nextBtn;
    public TMP_InputField[] zadanieinputfield = new TMP_InputField[9];
    void Start()
    {


        theory.text ="\tЭто магический квадрат 3 на 3 текст записывается в клетки квадрата в порядке, соответствующем. Но в магическом" +
                 " квадрате числа расположены в другом порядке, поэтому буквы вписываются не по порядку, а в соответствии с номерами клеток." +
                 " Находим, где в квадрате стоят числа от 1 до 9: " +
                 "\r\nНажмите на стрелку вперед";
    }
    public void Numer()
    { numPage++;

        if (numPage == 1)
        {
            theory.text = "\tЭто магический квадрат 3 на 3 текст записывается в клетки квадрата в порядке, соответствующем. Но в магическом" +
                 " квадрате числа расположены в другом порядке, поэтому буквы вписываются не по порядку, а в соответствии с номерами клеток." +
                 " Находим, где в квадрате стоят числа от 1 до 9: " +
                 "\r\n1Нажмите на стрелку вперед";
        }
        else if (numPage == 2)
        {
            theory.text = "\tЭто магический квадрат 3 на 3 текст записывается в клетки квадрата в порядке, соответствующем. Но в магическом" +
                " квадрате числа расположены в другом порядке, поэтому буквы вписываются не по порядку, а в соответствии с номерами клеток." +
                " Находим, где в квадрате стоят числа от 1 до 9: " +
                "\r\n1 > (2,3) > \"ш\"" +
                "\r\n" +
                "Нажмите на стрелку вперед";
            inputField1.text = "ш";

        }
        else if (numPage == 3)
        {
            theory.text = "\tЭто магический квадрат 3 на 3 текст записывается в клетки квадрата в порядке, соответствующем. Но в магическом квадрате числа расположены в другом порядке, поэтому буквы вписываются не по порядку, а в соответствии с номерами клеток. Находим, где в квадрате стоят числа от 1 до 9: \r\n1 > (2,3) > \"ш\"\r\n2 > (1,1) > \"п\"";
            inputField2.text = "п";
        }
        else if (numPage == 4)
        {

            theory.text = "\tЭто магический квадрат 3 на 3 текст записывается в клетки квадрата в порядке, соответствующем. Но в магическом квадрате числа расположены в другом порядке, поэтому буквы вписываются не по порядку, а в соответствии с номерами клеток. Находим, где в квадрате стоят числа от 1 до 9: \r\n1 > (2,3) > \"ш\"\r\n2 > (1,1) > \"п\"\r\n3 > (3,2) > \"а\"\r\nИ т.д.\r\nНажмите на стрелку вперед";
            inputField3.text = "а";

        }
        else if (numPage == 5)
        {
            theory.text = "\tЭто магический квадрат 3 на 3 текст записывается в клетки квадрата в порядке, соответствующем. Но в магическом квадрате числа расположены в другом порядке, поэтому буквы вписываются не по порядку, а в соответствии с номерами клеток. Находим, где в квадрате стоят числа от 1 до 9: \r\n1 > (2,3) > \"ш\"\r\n2 > (1,1) > \"п\"\r\n3 > (3,2) > \"а\"\r\nИ т.д.\r\nОтвет выписывается посточно\r\nНажмите на стрелку вперед";
            string[] massiv = { "П", "Л", "А", "А", "Г", "Ш", "Р", "А", "К" };
            int i = 0;

            foreach (var inputFields in zadanieinputfield)
            {
                inputFields.text = massiv[i].ToString();
                i++;

            }
        }
        else if (numPage == 6)
        {       
            inputField.text = "ПЛААГШРАК";
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        

    }
    public void ValidateInput()
    {
        string input = inputField.text.ToUpper();

        if (input == "ПЛААГШРАК")
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
