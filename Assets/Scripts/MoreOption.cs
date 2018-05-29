using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreOption : Menu<MoreOption> {

    public static void Show()
    {
        Open();
    }

    public static void Hide()
    {
        Close();

    }

    public void ShowObjectChange()
    {
        OptionsMenu.Show();
    }

    public void ShowColorMenu()
    {
        ColorMenu.Show();
    }
}
