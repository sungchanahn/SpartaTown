using UnityEngine;
using UnityEngine.SceneManagement;

public class JoinButton : MonoBehaviour
{
    public void Join()
    {
        if (!PlayerPrefs.HasKey("Name"))
        {
            PlayerPrefs.SetString("Name", "�̸���6���");
        }
        SceneManager.LoadScene("MainScene");
    }
}
