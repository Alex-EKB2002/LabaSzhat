using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class WhatsNext : MonoBehaviour
{
    public Text d1Zam;
    
    public Text h1Zam;
    public Text h2Zam;
    public Text h3Zam;
    public Text h4Zam;

    public Text a1Zam;
    public Text a2Zam;
    public Text a3Zam;
    public Text a4Zam;

    public Text P1Zam;
    public Text P2Zam;
    public Text P3Zam;
    public Text P4Zam;
    

    void Update()
    {
       
        d1Zam.text = PlayerPrefs.GetString("d1");

        h1Zam.text = PlayerPrefs.GetString("h1");
        h2Zam.text = PlayerPrefs.GetString("h2");
        h3Zam.text = PlayerPrefs.GetString("h3");
        h4Zam.text = PlayerPrefs.GetString("h4");

        a1Zam.text = PlayerPrefs.GetString("a1");
        a2Zam.text = PlayerPrefs.GetString("a2");
        a3Zam.text = PlayerPrefs.GetString("a3");
        a4Zam.text = PlayerPrefs.GetString("a4");

        P1Zam.text = PlayerPrefs.GetString("f1");
        P2Zam.text = PlayerPrefs.GetString("f2");
        P3Zam.text = PlayerPrefs.GetString("f3");
        P4Zam.text = PlayerPrefs.GetString("f4");



    }
}
