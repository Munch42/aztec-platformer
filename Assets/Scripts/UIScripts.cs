using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScripts : MonoBehaviour
{
    public GameObject mainButtons;
    public GameObject secondaryButtons;

    public void secondaryButtonsOn()
    {
        mainButtons.SetActive(false);
        secondaryButtons.SetActive(true);
    }

    public void mainButtonsOn()
    {
        mainButtons.SetActive(true);
        secondaryButtons.SetActive(false);
    }

    public void exit()
    {
        Application.Quit();
    }
}
