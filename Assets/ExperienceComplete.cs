using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceComplete : MonoBehaviour
{
    public string experience;
    // Start is called before the first frame update
    public void Complete()
    {
        PlayerPrefs.SetInt(experience, 1);
    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();
    }
}
