using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    public Button reset;

    bool chugun = false;
    bool chement = false;
    bool wood1 = false;
    bool wood2 = false;
    void Update()
    {
        if (PlayerPrefs.GetInt("chugun") > 0) { chugun = true; } else { chugun = false; }
        if (PlayerPrefs.GetInt("chement") > 0) { chement = true; } else { chement = false; }
        if (PlayerPrefs.GetInt("wood1") > 0) { wood1 = true; } else { wood1 = false; }
        if (PlayerPrefs.GetInt("wood2") > 0) { wood2 = true; } else { wood2 = false; }

        if ( chugun & chement & wood1 & wood2 )
        {
            reset.interactable = true;
        }
        else
        {
            reset.interactable = false;
        }
    }
}
