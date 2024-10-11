using UnityEngine;
using TMPro;

public class SetPlayerName : MonoBehaviour
{
    [SerializeField] private TMP_InputField setNameInputField;

    public void ChangePlayerName()
    {
        if (setNameInputField == null) return;
        PlayerPrefs.SetString("Name", setNameInputField.text);
    }
}