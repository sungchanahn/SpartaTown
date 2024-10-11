using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePlayerPrefs : MonoBehaviour
{
    public void DeleteKeyButton(string _key)
    {
        PlayerPrefs.DeleteKey(_key);
    }

    public void DeleteAllButton()
    {
        PlayerPrefs.DeleteAll();
    }
}
