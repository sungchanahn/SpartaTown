using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject SelectedUI;
    
    public void SetActiveUI()
    {
        SelectedUI.SetActive(!SelectedUI.activeSelf);
    }
}