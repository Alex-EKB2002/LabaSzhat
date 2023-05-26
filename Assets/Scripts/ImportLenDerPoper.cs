using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class ImportLenDerPoper : MonoBehaviour
{
    public Text textt;
    public Button but;
    public Text a;
    public bool IsTrue = false;

    // Update is called once per frame
    void Update()
    {
        IsTrue = textt.text.All(char.IsDigit);

        if (IsTrue && textt.text != "" && Convert.ToInt32(textt.text) >= 20 && Convert.ToInt32(textt.text) <= 50)
        {
            but.interactable = true;
            a.text = string.Format("{0:0.##}", ((Convert.ToInt32(textt.text) * (Convert.ToInt32(textt.text)) + " êâ.ìì")));

        }
        else
        {
            but.interactable = false;

            a.text = "";
        }
        PlayerPrefs.SetString("h4", textt.text);
        PlayerPrefs.SetString("a4", a.text.Remove(a.text.Length - 6, 6));
    }
}
