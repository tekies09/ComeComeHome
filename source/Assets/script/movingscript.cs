using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingscript : MonoBehaviour
{
    audios2 script;

       
    public GameObject char1;
    private Vector3 char1pos;
    private Transform tr;
    private float fosx, fosy;
    public int gameOncode=1; 
    public float xchange, ychange, limitcountrx, limitcountlx, limitcountuy, limitcountdy;
    // Start is called before the first frame update
    void Start()
    {
        tr = char1.GetComponent<Transform>();
    GameObject audio1 = GameObject.Find("charmove");
    script = audio1.GetComponent<audios2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOncode == 0)
        { 
            char1pos = tr.position;
            fosx = char1pos.x;
            fosy = char1pos.y;
            if (Input.GetKeyDown(KeyCode.RightArrow) && (char1pos.x < limitcountrx))
            {
                script.playbutton();
               
                tr.position += new Vector3(xchange, 0, 0);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && (char1pos.x > limitcountlx))
            {
                script.playbutton();
                tr.position -= new Vector3(xchange, 0, 0);
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow) && (char1pos.y < limitcountuy))
            {script.playbutton();
                tr.position += new Vector3(0, ychange, 0);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && (char1pos.y > limitcountdy))
            {
                script.playbutton();
                tr.position -= new Vector3(0, ychange, 0);
            }
        }
    }
}
