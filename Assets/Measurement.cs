using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Measurement : MonoBehaviour
{
    public Text textToEdit;

    float timeLeft = 15f;

    float A;
    int q = 670;
    float k;
    float F;
    double result = 0;

    // Start is called before the first frame update
    void Start()
    {
        k = UnityEngine.Random.Range(0.95f, 1.05f);
        A = float.Parse(PlayerPrefs.GetString("a1"));
        F = A * q * k;
        
    }

    // Update is called once per frame
    void StartMeasurement()
    {
        StartCoroutine("DoCheck");
    }

    IEnumerator DoCheck()
    {
        for (; ; )
        {
            if (result < F)
            {
                result += Math.Round(F/12, 2);
                textToEdit.text = Convert.ToInt32(result).ToString() + " Í";
            }
            else
            {
                result = Math.Round(F, 2);
                
            }

            PlayerPrefs.SetString("f1", Convert.ToInt32(result).ToString());
            yield return new WaitForSeconds(1);
        }
    }
}
