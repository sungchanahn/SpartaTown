using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject[] CharacterPrefabs;
    [HideInInspector] public GameObject Player;

    public GameObject SpawnPoint;
    [HideInInspector] public Vector3 CurrentPlayerPosition;

    public TMP_Text PlayerName;
    [SerializeField] private TMP_Text timeText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        Player = Instantiate(CharacterPrefabs[PlayerPrefs.GetInt("SelectedCharacter")],
                             SpawnPoint.transform.position, Quaternion.identity, SpawnPoint.transform);
        PlayerName = Player.GetComponentInChildren<TMP_Text>();
        PlayerName.text = PlayerPrefs.GetString("Name");
        Time.timeScale = 1.0f;
    }

    private void Update()
    {
        timeText.text = DateTime.Now.ToString("HH:mm");
    }

    public void ChangeCharacter()
    {
        CurrentPlayerPosition = Player.transform.position;
        Destroy(Player);
        Player = Instantiate(CharacterPrefabs[PlayerPrefs.GetInt("SelectedCharacter")],
                             CurrentPlayerPosition, Quaternion.identity, SpawnPoint.transform);
        PlayerName = Player.GetComponentInChildren<TMP_Text>();
        PlayerName.text = PlayerPrefs.GetString("Name");
    }
}