using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstmusicsetting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!(PlayerPrefs.HasKey("musicset")))
        {
            PlayerPrefs.SetInt("musicset", 1);
            PlayerPrefs.SetInt("bgm", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
