using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetNameButton : ButtonManager
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
