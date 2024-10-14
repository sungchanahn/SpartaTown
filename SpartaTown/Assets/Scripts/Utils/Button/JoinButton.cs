using UnityEngine;
using UnityEngine.SceneManagement;

public class JoinButton : MonoBehaviour
{
    public void Join()
    {
        if (PlayerPrefs.HasKey("Name"))
        {
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            AlertNameSetting.Instance.DisplayAlert();
        }
    }
}