using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetbutton : MonoBehaviour
{
    // Start is called before the first frame update
    
  
    audios2 script;
    
    void Start()
    {
GameObject audio1 = GameObject.Find("buttonclickbgm");
    script = audio1.GetComponent<audios2>();}

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {  script.playbutton();
        Debug.Log("resetbuttoncall");
            PlayerPrefs.SetInt("first", 0);
            PlayerPrefs.SetInt("second", 0);
            PlayerPrefs.SetInt("third", 0);
    }

}
