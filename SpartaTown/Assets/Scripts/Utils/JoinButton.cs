using UnityEngine;
using UnityEngine.SceneManagement;

public class JoinButton : MonoBehaviour
{
    public void Join()
    {
        if (PlayerPrefs.GetString("Name").Length >= 2 && PlayerPrefs.GetString("Name").Length <= 10)
        {
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            AlertNameSetting.Instance.DisplayAlert();
        }
        //if (!PlayerPrefs.HasKey("Name"))
        //{
        //    PlayerPrefs.SetString("Name", "�̸���6���");
        //}
        //SceneManager.LoadScene("MainScene");
    }
}