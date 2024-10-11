using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectionManager : MonoBehaviour
{
    public int index;

    public void SelectCharacter()
    {
        PlayerPrefs.SetInt("SelectedCharacter", index);
    }
}
