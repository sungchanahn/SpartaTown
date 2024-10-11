using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour
{
    public GameObject[] CharacterUI;
    public GameObject SelectedCharacterUI;

    private void Start()
    {
        SelectedCharacterUI = CharacterUI[PlayerPrefs.GetInt("SelectedCharacter", 0)];
        SelectedCharacterUI.SetActive(true);
    }
}
