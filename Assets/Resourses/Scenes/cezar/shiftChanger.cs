using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class shiftChanger : MonoBehaviour
{
    [SerializeField] Button IncreaseBTN;
    [SerializeField] Button ReduseBTN;
    [SerializeField] TMP_InputField sdvig;

    void Update()
    {
        
    }

    private void Increase()
    {
        int shift = int.Parse(sdvig.text);
        if (int.Parse(sdvig.text) < 32)
        {
            shift++;
            sdvig.text = shift.ToString();
        }
         
        
    }
    private void Reduse()
    {
        int shift = int.Parse(sdvig.text);
        if (int.Parse(sdvig.text) >-32 )
        {
            shift--;
            sdvig.text = shift.ToString();
        }
        
    }
}
