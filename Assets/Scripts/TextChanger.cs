using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text textUpper;
    [SerializeField] private Text textCardName;
    private int current;
    public void ChangeTextClicking()
    {
       current = int.Parse(textUpper.text);
       current++;
       textUpper.text = current.ToString(); 
    }
    public void ChangeTextCardName(CardInfo cardInfo)
    {
        textCardName.text = cardInfo.GetCard().Name;
    }
}
