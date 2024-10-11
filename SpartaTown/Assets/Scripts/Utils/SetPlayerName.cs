using UnityEngine;
using TMPro;

public class SetPlayerName : MonoBehaviour
{
    [SerializeField] private TMP_InputField setNameInputField;
    [SerializeField] private TMP_Text CurrentNameText;

    private void Awake()
    {
        DisplayCurrentName();
    }

    public void SetName()
    {
        if (setNameInputField.text.Length >= 2 && setNameInputField.text.Length <= 10)
        {
            PlayerPrefs.SetString("Name", setNameInputField.text);
            DisplayCurrentName();
        }
        else
        {
            AlertNameSetting.Instance.DisplayAlert();
        }
    }

    public void ChangeName()
    {
        if (GameManager.Instance.PlayerName.text != PlayerPrefs.GetString("Name"))
        {
            GameManager.Instance.PlayerName.text = PlayerPrefs.GetString("Name");
        }
    }

    public void DisplayCurrentName()
    {
        if (string.IsNullOrEmpty(CurrentNameText.text))
        {
            CurrentNameText.text = "현재 이름: ";
        }
        CurrentNameText.text = $"현재 이름: {PlayerPrefs.GetString("Name")}";
    }
}