using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickActions : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private Transform point;
    [SerializeField] private CardInfo cardInfo;
    private RectTransform rectTransform;
    private float timer;
    public void Click()
    {
        cardInfo = gameObject.GetComponent<CardInfo>();
        if (cardInfo.GetAvalible())
        {
            rectTransform= gameObject.GetComponent<RectTransform>();
            MoveToPoint();
            gameObject.transform.SetParent(point);
            gameObject.transform.localScale = new Vector3(.5f, .5f, 1f);
            rectTransform.sizeDelta = new Vector2(211.8182f, 205.6363f);
            gameObject.transform.localPosition = new Vector3(0f, 0f, 0f);
            timer = 10f;
        }
    }
    private void MoveToPoint()
    {
        transform.position = point.position - transform.position;
    }
    private void FixedUpdate()
    {
     if (timer != 0f) timer -= 0.1f;
     if (timer < 0f) gameObject.SetActive(false);
     }
}
