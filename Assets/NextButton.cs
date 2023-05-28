using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextButton : MonoBehaviour
{
    public Button Button;

    void OffButton()
    {
        Button.interactable = true;
    }
}
