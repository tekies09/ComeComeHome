using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvfirstsetting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!(PlayerPrefs.HasKey("settingcheck")))
        {
            PlayerPrefs.SetInt("settingcheck", 1);
            PlayerPrefs.SetInt("first", 0);
            PlayerPrefs.SetInt("second", 0);
            PlayerPrefs.SetInt("third", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
