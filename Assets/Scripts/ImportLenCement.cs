using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class ImportLenCement : MonoBehaviour
{
    public Text textt;
    public Button but;
    public Text a;
    public bool IsTrue = false;

    // Update is called once per frame
    void Update()
    {
        IsTrue = textt.text.All(char.IsDigit);

        if (IsTrue && textt.text != "" && Convert.ToInt32(textt.text) >= 50 && Convert.ToInt32(textt.text) <= 200)
        {
            but.interactable = true;
            a.text = string.Format("{0:0.##}", ((Convert.ToInt32(textt.text) * (Convert.ToInt32(textt.text)) + " êâ.ìì")));

        }
        else
        {
            but.interactable = false;
            
            a.text = "";
        }
        PlayerPrefs.SetString("h2", textt.text);
        PlayerPrefs.SetString("a2", a.text.Remove(a.text.Length - 6, 6));
    }
}
