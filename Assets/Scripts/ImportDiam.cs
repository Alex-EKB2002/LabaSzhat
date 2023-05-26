using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class ImportDiam : MonoBehaviour
{
    public Text textt;
    public Button but;
    public Text len;
    public Text a;
    
    public bool IsTrue = false;

    // Update is called once per frame
    void Update()
    {
        IsTrue = textt.text.All(char.IsDigit);


        if (IsTrue && textt.text != "" && Convert.ToInt32(textt.text) >= 5 && Convert.ToInt32(textt.text) <= 25)
        {
            but.interactable = true;
            len.text = (Convert.ToInt32(textt.text) * 1.5).ToString() + " ìì";
            a.text = string.Format("{0:0.##}", (Convert.ToInt32(textt.text) * (Convert.ToInt32(textt.text) * Math.PI)) / 4) + " êâ.ìì";
            
        }
        else
        {
            but.interactable = false;
            len.text = "";
            a.text = "";
        }
        PlayerPrefs.SetString("d1",textt.text);
        PlayerPrefs.SetString("h1", len.text.Remove(len.text.Length - 3, 3));
        PlayerPrefs.SetString("a1", a.text.Remove(a.text.Length - 6,6));
    }
}
