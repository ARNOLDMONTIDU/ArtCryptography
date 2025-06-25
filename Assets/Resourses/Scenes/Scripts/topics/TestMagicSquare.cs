using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class TestMagicSquare : MonoBehaviour
{
    public QuestionList[] questions;
    public TextMeshProUGUI qText;
    public TextMeshProUGUI[] answersText;
    public TextMeshProUGUI QuestionNumber;
    public GameObject qObject;
    public GameObject resObject;
    public GameObject Right;
    public GameObject Wrong;

    List<object> qList;
    QuestionList crntQ;
    int randQ;
    int qNumber;
    int rNumber;

    void Start()
    {
        qNumber = 1;
        rNumber = 0;
        resObject.SetActive(false);
        qList = new List<object>(questions);
        questionsGenerate();
    }
    void questionsGenerate()
    {
        if (qList.Count > 0)
        {
            Wrong.SetActive(false);
            Right.SetActive(false);
            QuestionNumber.text = "Вопрос " + qNumber + "/5";
            randQ = Random.Range(0, qList.Count);
            crntQ = qList[randQ] as QuestionList;
            qText.text = crntQ.question;
            List<string> answers = new List<string>(crntQ.answers);
            for (int i = 0; i < crntQ.answers.Length; i++)
            {
                int rand = Random.Range(0, answers.Count);
                answersText[i].text = answers[rand];
                answers.RemoveAt(rand);
            }
        }
        else
        {
            qObject.SetActive(false);
            resObject.SetActive(true);
            print("djghjcs rjyxbkbcm");
        }
        
    }
    public void answersBttns(int index)
    {
        if (answersText[index].text.ToString() == crntQ.answers[0])
        {
            
            rNumber++;
            Right.SetActive(true);

        }
        else Wrong.SetActive(true);
        
        qList.RemoveAt(randQ);
        if (qNumber < 5) qNumber++;
        questionsGenerate();
                
    }
    
    [System.Serializable]
    public class QuestionList
    {
        public string question;
        public string[] answers = new string[3];
    }
}
