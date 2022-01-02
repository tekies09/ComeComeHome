using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutoboardmanager : MonoBehaviour
{
    public int tutocode = 0;
    public GameObject tuto1, tuto2, tuto3, tuto4;
    Transform tft1, tft2, tft3, tft4;
    // Start is called before the first frame update
    void Start()
    {
        tft1 = tuto1.GetComponent<Transform>();
        tft2 = tuto2.GetComponent<Transform>();
        tft3 = tuto3.GetComponent<Transform>();
        tft4 = tuto4.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void boardcodeplus()
    {
        if (tutocode != 3)
        {
            tutocode += 1;
        }
        else
        {
            tutocode = 0;
        }
        boardsetting();
    }
    public void boardcodeminus()
    {
        if (tutocode != 0)
        {
            tutocode -= 1;
        }
        else
        {
            tutocode = 3;
        }
        boardsetting();
    }
    public void boardsetting()
    {
        switch (tutocode)
        {
            case 0:
                tft1.position = new Vector3(0, 0, -8);
                tft2.position = new Vector3(0, 0, -7);
                tft3.position = new Vector3(0, 0, -7);
                tft4.position = new Vector3(0, 0, -7);
                break;
            case 1:
                tft1.position = new Vector3(0, 0, -7);
                tft2.position = new Vector3(0, 0, -8);
                tft3.position = new Vector3(0, 0, -7);
                tft4.position = new Vector3(0, 0, -7);
                break;
            case 2:
                tft1.position = new Vector3(0, 0, -7);
                tft2.position = new Vector3(0, 0, -7);
                tft3.position = new Vector3(0, 0, -8);
                tft4.position = new Vector3(0, 0, -7);
                break;
            case 3:
                tft1.position = new Vector3(0, 0, -7);
                tft2.position = new Vector3(0, 0, -7);
                tft3.position = new Vector3(0, 0, -7);
                tft4.position = new Vector3(0, 0, -8);
                break;
        }
    }
}
