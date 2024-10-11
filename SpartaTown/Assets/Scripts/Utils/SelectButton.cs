using UnityEngine;

public class SelectButton : MonoBehaviour
{
    public void SelectCharacter(int _index)
    {
        PlayerPrefs.SetInt("SelectedCharacter", _index);
    }
}
