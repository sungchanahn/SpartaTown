using UnityEngine;

public class HoldInputSystemButton : UIManager
{
    public void HoldInputSystem()
    {
        if (SelectedUI.activeSelf)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
    }
}
