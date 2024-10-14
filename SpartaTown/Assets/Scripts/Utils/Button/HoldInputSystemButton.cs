using UnityEngine;

public class HoldInputSystemButton : UIManager
{
    public void HoldInputSystem()
    {
        if (SelectedUI.activeSelf)
        {
            GameManager.Instance.IsPlaying = false;
        }
        else
        {
            GameManager.Instance.IsPlaying = true;
        }
    }
}
