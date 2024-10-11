using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AlertNameSetting : MonoBehaviour
{
    public static AlertNameSetting Instance;

    [SerializeField] private GameObject AlertObject;
    [SerializeField] private TMP_Text AlertText;

    private void Awake()
    {
        Instance = this;
    }

    public void DisplayAlert()
    {
        AlertObject.SetActive(true);
        AlertText.color = Color.red;
        Invoke("ChangeAlertColor", 3f);
    }

    void ChangeAlertColor()
    {
        AlertText.color = Color.white;
    }
}