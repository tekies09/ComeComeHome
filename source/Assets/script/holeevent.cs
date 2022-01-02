using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holeevent : MonoBehaviour
{
    audios2 script;
 
      
    public GameObject char1;
    private Transform cltr;
    public float firstx, firsty;
    // Start is called before the first frame update
    void Start()
    {   GameObject audio1 = GameObject.Find("holesound");
    script = audio1.GetComponent<audios2>();
        cltr = char1.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        script.playbutton();
        cltr.position = new Vector3(firstx, firsty, -5);
    }
}
