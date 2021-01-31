using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Card", menuName = "Card Data")]
public class Card : ScriptableObject
{
    [SerializeField] private string name;
    [SerializeField] private string suit;
    [SerializeField] private int value;
    [SerializeField] private Sprite sprite;
    [SerializeField] private bool isAvalible;


    public string Name { get { return name; } }
    public string Suit { get { return suit; } }
    public int Value { get { return value; } }
    public Sprite Sprite { get { return sprite; } }
    public bool IsAvalible { get { return isAvalible; } set { } }
}
