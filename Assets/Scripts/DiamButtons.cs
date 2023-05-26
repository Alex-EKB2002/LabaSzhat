using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DiamButtons : MonoBehaviour
{
    public Button butRight;
    public Button butLeft;
    public Text diamText;
    public string texter;
    public string LeftVol;
    public string RightVol;
    public bool rightBlock = false;
    public bool leftBlock = false;
    public int vol;
    private void Start()
    {
        diamText.text = texter;
    }
    public void OnClick()
    {
        diamText.text = (Convert.ToInt32(diamText.text) + vol).ToString();
    }
    private void Update()
    {
        
        if (diamText.text == LeftVol)
            leftBlock = true;
        if (diamText.text == RightVol)
            rightBlock = true;

        if (diamText.text != LeftVol)
        {
            leftBlock = false;
        }
        if (diamText.text != RightVol)
        {
            rightBlock = false;
        }

        if (leftBlock)
            butLeft.interactable = false;
        if (rightBlock)
            butRight.interactable = false;

         if (leftBlock == false)
        {
            butLeft.interactable = true;
        }
        if (rightBlock == false)
        {
            butRight.interactable = true;
        }

    }
}
