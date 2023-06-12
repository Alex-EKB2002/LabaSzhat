using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestComplete : MonoBehaviour
{
    public GameObject panel;
    public string experience;
    static bool testComplete = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt(experience) > 0)
        {
            testComplete = true;
        }
        else
        {
            testComplete = false;
        }
        panel.SetActive(testComplete);
    }
}
