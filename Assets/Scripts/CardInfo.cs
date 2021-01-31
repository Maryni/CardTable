using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo : MonoBehaviour
{
    [SerializeField] private Card cardData;
    [SerializeField] private bool isAvalible = true;

    public Card GetCard() { return cardData; }
    public void SetAvalible(bool value) { isAvalible = value; }
    public bool GetAvalible() { return isAvalible; }

}
