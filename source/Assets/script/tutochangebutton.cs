using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutochangebutton : MonoBehaviour
{
    audios2 script;
    tutoboardmanager tutoscript;
    public GameObject boardmanager;
    public int code;
    //code 1 = rightbutton code 2 =left button
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        tutoscript = boardmanager.GetComponent<tutoboardmanager>();
        GameObject audio1 = GameObject.Find("buttonclickbgm");
        script = audio1.GetComponent<audios2>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        script.playbutton();
        if (code == 1)
        {
            tutoscript.boardcodeplus();
        }
        else
        {
            tutoscript.boardcodeminus();
        }

    }
}
