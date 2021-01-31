using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSShow : MonoBehaviour
{
    [SerializeField] private float current;
    void Update()
    {
        current = (int)(1f / Time.unscaledDeltaTime);
    }
}
