using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeasurementChement : MonoBehaviour
{
    public Text textToEdit;

    float A;
    int q = 40;
    float k;
    float F;
    double result = 0;

    // Start is called before the first frame update
    void Start()
    {
        k = UnityEngine.Random.Range(0.95f, 1.05f);
        A = float.Parse(PlayerPrefs.GetString("a2"));
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
                textToEdit.text = Convert.ToInt32(result).ToString() + " �";
            }
            else
            {
                result = Math.Round(F, 2);
                
            }

            PlayerPrefs.SetString("f2", Convert.ToInt32(result).ToString());
            yield return new WaitForSeconds(1);
        }
    }
}
