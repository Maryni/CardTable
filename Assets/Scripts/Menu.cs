using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    [SerializeField] private float timer;
    void FixedUpdate()
    {
        if (timer > 0f) timer -= 0.1f;
        if (timer < 0f) SceneManager.LoadSceneAsync("Game");
    }
}
