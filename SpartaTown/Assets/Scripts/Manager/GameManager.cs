using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject[] CharacterPrefabs;
    public GameObject Player;
    public Transform SpawnPoint;
    public Vector2 CurrentPlayerPosition;
    public TMP_Text PlayerName;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        Player = Instantiate(CharacterPrefabs[PlayerPrefs.GetInt("SelectedCharacter", 0)], SpawnPoint);
        PlayerName = Player.GetComponentInChildren<TMP_Text>();
        PlayerName.text = PlayerPrefs.GetString("Name");
    }
}