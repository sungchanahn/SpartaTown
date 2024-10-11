using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject[] CharacterPrefabs;
    public GameObject player;
    public Vector2 CurrentPlayerPosition;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        player = Instantiate(CharacterPrefabs[0]);
    }
}
