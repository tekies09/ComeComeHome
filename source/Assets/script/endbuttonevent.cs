using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endbuttonevent : MonoBehaviour
{
    public GameObject audio1;
    audios2 script;
   
             
    // Start is called before the first frame update
    void Start()
    {
        script = audio1.GetComponent<audios2>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    { 
        script.playbutton();

        Application.Quit();   
       
    }
}
