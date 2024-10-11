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
        //if (!PlayerPrefs.HasKey("Name"))
        //{
        //    PlayerPrefs.SetString("Name", "�̸���6���");
        //}
        //SceneManager.LoadScene("MainScene");
    }
}