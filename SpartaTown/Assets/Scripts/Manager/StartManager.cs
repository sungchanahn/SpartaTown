using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour
{
    public GameObject[] CharacterUI;
    public GameObject SelectedCharacterUI;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("SelectedCharacter"))
        {
            PlayerPrefs.SetInt("SelectedCharacter", 0);
        }
        SelectedCharacterUI = CharacterUI[PlayerPrefs.GetInt("SelectedCharacter", 0)];
        SelectedCharacterUI.SetActive(true);
    }
}
