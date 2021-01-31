using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextureChanger : MonoBehaviour
{
    [SerializeField] private Image table;
    [SerializeField] private List<Sprite> textures;
    [SerializeField] private int intTexture; //0 - default, 1-4 - custom texture

    private void Awake(){ LoadGame();  }
    public void SetInt(int a) { intTexture = a; SaveGame(); }
    private void LoadGame()
    {
        if(PlayerPrefs.HasKey("intTexture"))
        {
            intTexture = PlayerPrefs.GetInt("intTexture");
            table.sprite = textures[intTexture];
        }
        else
        {
            SaveGame();
        }
    }

    private void SaveGame()
    {
        table.sprite = textures[intTexture];
        PlayerPrefs.SetInt("intTexture", intTexture);
        PlayerPrefs.Save();
    }
}
