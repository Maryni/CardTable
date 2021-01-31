using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> cards;
    [SerializeField] private Transform hand;
    [SerializeField] private string prefferSuit;
    [SerializeField] private Color hideColor;
    [SerializeField] private Color whiteColor;
    [SerializeField] private float testCount;
    private Card cardData;
    private CardInfo cardInfo;
    private GameObject temp;
    private string[] arr = { "C", "D", "H", "S" };
    private int rand;
    private int j = 0; //iteration 

    public Card GetCardDate() { return cardData; }
    [ContextMenu("ForStart")]
    public void ForStart() { CardToHand(); SetPrefferSuit(); ShowPrefferCards(); Sort(); print("Success"); }
    [ContextMenu("EachRound")]
    public void EachRound() { SetPrefferSuit();ShowPrefferCards();Sort(); }
    private void SetPrefferSuit()
    {
        rand = Random.Range(0, 4); // C, D, H, S 
        prefferSuit = arr[rand];
    }
    private void ShowPrefferCards() 
    {
            for (int j = 0; j < hand.childCount; j++)
            {
                temp = hand.GetChild(j).gameObject;
                cardInfo = temp.GetComponent<CardInfo>();
                cardData = cardInfo.GetCard();

                if (cardData.Suit != prefferSuit)
                {
                temp.GetComponent<Image>().color = hideColor;
                cardInfo.SetAvalible(false);
                }
                else { temp.GetComponent<Image>().color = whiteColor; cardInfo.SetAvalible(true); }
            }
    }
    private void CardToHand()
    {
        for (int i = 0; i < 13; i++)
        {
            rand = Random.Range(0, 51 - j);
            GameObject temp = cards[rand];
            temp.transform.SetParent(hand);
            j++;
        }
    }
    private void Sort() 
    {
        for(int i=0; i<4;i++)
         { 
            for (int j = 0; j < hand.childCount; j++)
            {
                temp = hand.GetChild(j).gameObject;
                cardData = temp.GetComponent<CardInfo>().GetCard();
                if(cardData.Suit==arr[i])
                {
                    temp.transform.SetSiblingIndex(0);
                }
            }
         }  
    }
    [ContextMenu("Test")]
    private void Test()
    {
        try
        {
            for (int i=0;i<testCount;i++)
            {
            EachRound();
            }
        }
        catch 
        {
            print("out found");
        }
        finally
        {
            print("All of "+ testCount+" test are finished");
        }
    }
}
