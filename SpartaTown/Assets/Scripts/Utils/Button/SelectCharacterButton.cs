using UnityEngine;

public class SelectCharacterButton : MonoBehaviour
{
    public void SelectCharacter(int _index)
    {
        PlayerPrefs.SetInt("SelectedCharacter", _index);
    }

    public void ChangeCharacter()
    {
        GameManager.Instance.ChangeCharacter();
    }
}
