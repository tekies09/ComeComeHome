using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeclearboard : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject clearboard;
    public GameObject resetbutton;
    public GameObject exitbutton;
    private Transform cltr, rbtr1, ebtr1;
   
    audios2 script;
   
    void Start()
    {
        cltr = clearboard.GetComponent<Transform>();
        rbtr1 = resetbutton.GetComponent<Transform>();
        ebtr1 = exitbutton.GetComponent<Transform>();
        GameObject audio1 = GameObject.Find("buttonclickbgm");
    script = audio1.GetComponent<audios2>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    { script.playbutton();
        cltr.position += new Vector3(0, 9, 0);
        rbtr1.position += new Vector3(0, 9, 0);
        ebtr1.position += new Vector3(0, 9, 0);
    }
}
