using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerAndOff : MonoBehaviour
{
    [SerializeField] private GameObject gameObjectGO;
    [SerializeField] private float timer;
    [SerializeField] private CardManager cardManager;

    private void FixedUpdate()
    {
        if (timer > 0f) timer -= 0.1f;
        if (timer < 0f)
        {
            gameObject.SetActive(false); 
            gameObjectGO.SetActive(true);
            cardManager.ForStart();
        }
    }
}
