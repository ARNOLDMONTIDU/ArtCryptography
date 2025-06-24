using TMPro;
using UnityEngine;
using UnityEngine.UI;
//5 on 5

public class fiveOnFive : MonoBehaviour
{
    [SerializeField] GameObject questions;
    [SerializeField] Button btnClick;
    [SerializeField] TMP_InputField inputField;
    [SerializeField] TextMeshProUGUI resultText;
    public TMP_InputField[] zadanieinputfield = new TMP_InputField[25];


    void Start()
    {
        questions.SetActive(false);
        //string phrase = "АГЕНТ ПРОВАЛИЛСЯ";
        int[] massiv = 
        {
            17, 24,  1,  8, 15,
            23,  5,  7, 14, 16,
            4,  6, 13, 20, 22,
            10, 12, 19, 21,  3,
            11, 18, 25,  2,  9 
        };
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
        //прекрасные_летние_денёчки
        if (input == "ЕКПННЧРСТИКАЕЕНЕЛДЕЕ__ИРЫ")
        {
            resultText.text = "Правильно";
            questions.SetActive(true);
        }
        else
        {   
            resultText.text = "Неверно";
        }


    }

}
